﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GWT
{
    public partial class TrainingForm : Form
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        public bool isLoggedIn = false;
        private string user_name;
        private BackExer backExercises = new BackExer();
        private ShoulderExer shoulderExercises = new ShoulderExer();
        private ArmExer armExercises = new ArmExer();
        private ChestExer chestExercises = new ChestExer();
        private AbsExer absExercises = new AbsExer();
        private ButtExer buttExercises = new ButtExer();
        private LegExer legExercises = new LegExer();

        private WorkingOutForm workForm = new WorkingOutForm();
        private WorkoutRoutine routineForm = new WorkoutRoutine();
        private WorkoutReport reportForm = new WorkoutReport();
        private UserProfile profileForm = new UserProfile();
        
        public string username
        {
            get { return user_name; }
            set
            {
                user_name = value;
                displayUsername();
            }
        }
        public string gender { get; set; }
        public double userHeight { get; set; }
        public double userWeight { get; set; }
        public string bodyType { get; set; }
        public int userId;
        public double bmi { get; set; }
        public Areas areasForm = new Areas();
        private BMI bmiForms = new BMI();

        public int workoutNameLbl;
        int x = 26;
        int y = 81;
        int width = 767;
        int height = 285;
        int addX = 325;

        public Random randNum = new Random();
        private int[] indexes = { 0, 1, 2, 3, 4, 5 };
        int index = 1;

        public int back, shoulder, arm, chest, abs, butt, leg;

        bool isWorkingOut = false;
        int TimeMs, TimeS, TimeM, TimeH;
        int workoutTotal, workoutMinutes, workoutDays, workoutToday = 0;

        Guna.UI2.WinForms.Guna2CheckBox checkbox1 = new Guna.UI2.WinForms.Guna2CheckBox();
        Guna.UI2.WinForms.Guna2CheckBox checkbox2 = new Guna.UI2.WinForms.Guna2CheckBox();
        Guna.UI2.WinForms.Guna2CheckBox checkbox3 = new Guna.UI2.WinForms.Guna2CheckBox();
        Guna.UI2.WinForms.Guna2CheckBox checkbox4 = new Guna.UI2.WinForms.Guna2CheckBox();

        bool isBack = false, isShoulder = false, isArm = false, isChest = false, isAbs = false, isButt = false, isLeg = false;
        public TrainingForm()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void timeTo0()
        {
            TimeMs = 0;
            TimeS = 0;
            TimeM = 0;
            TimeH = 0;
        }
        
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if (!isLoggedIn)
            {
                int setByGender = (gender == "Male") ? 4 : 3;
                int exerNumByBmi = 6;
                if (bodyType == "Under Weight")
                {
                    exerNumByBmi = 5;
                }
                else if (bodyType == "Healthy")
                {
                    exerNumByBmi = 6;
                }
                else if (bodyType == "Over Weight")
                {
                    exerNumByBmi = 7;
                }
                Image absMuscleDiag = global::GWT.Properties.Resources.muscleAbsGWT;
                Image backMuscleDiag = global::GWT.Properties.Resources.muscleBackGWT;
                Image chestMuscleDiag = global::GWT.Properties.Resources.muscleChestGWT;
                Image armMuscleDiag = global::GWT.Properties.Resources.muscleArmGWT;
                Image shoulderMuscleDiag = global::GWT.Properties.Resources.muscleShoulderGWT;
                Image buttMuscleDiag = global::GWT.Properties.Resources.muscleButtGWT;
                Image legMuscleDiag = global::GWT.Properties.Resources.muscleLegGWT;

                if (back == 1)
                {
                    setPanel("Back Workout", exerNumByBmi, backExercises.BackName[indexes[0]], setByGender, backExercises.BackReps[indexes[0]], backExercises.BackName[indexes[1]], setByGender, backExercises.BackReps[indexes[1]], backExercises.BackName[indexes[2]], setByGender, backExercises.BackReps[indexes[2]], backMuscleDiag, viewAll_LinkClicked);
                }
                if (shoulder == 1)
                {
                    setPanel("Shoulder Workout", exerNumByBmi, shoulderExercises.ShoulderName[indexes[0]], setByGender, shoulderExercises.ShoulderReps[indexes[0]], shoulderExercises.ShoulderName[indexes[1]], setByGender, shoulderExercises.ShoulderReps[indexes[1]], shoulderExercises.ShoulderName[indexes[2]], setByGender, shoulderExercises.ShoulderReps[indexes[2]], shoulderMuscleDiag, viewAll2_LinkClicked);
                }
                if (arm == 1)
                {
                    setPanel("Arm Workout", exerNumByBmi, armExercises.ArmName[indexes[0]], setByGender, armExercises.ArmReps[indexes[0]], armExercises.ArmName[indexes[1]], setByGender, armExercises.ArmReps[indexes[1]], armExercises.ArmName[indexes[2]], setByGender, armExercises.ArmReps[indexes[2]], armMuscleDiag, viewAll3_LinkClicked);
                }
                if (chest == 1)
                {
                    setPanel("Chest Workout", exerNumByBmi, chestExercises.ChestName[indexes[0]], setByGender, chestExercises.ChestReps[indexes[0]], chestExercises.ChestName[indexes[1]], setByGender, chestExercises.ChestReps[indexes[1]], chestExercises.ChestName[indexes[2]], setByGender, chestExercises.ChestReps[indexes[2]], chestMuscleDiag, viewAll4_LinkClicked);
                }
                if (abs == 1)
                {
                    setPanel("Abs Workout", exerNumByBmi, absExercises.AbsName[indexes[0]], setByGender, absExercises.AbstReps[indexes[0]], absExercises.AbsName[indexes[1]], setByGender, absExercises.AbstReps[indexes[1]], absExercises.AbsName[indexes[2]], setByGender, absExercises.AbstReps[indexes[2]], absMuscleDiag, viewAll5_LinkClicked);
                }
                if (butt == 1)
                {
                    setPanel("Butt Workout", exerNumByBmi, buttExercises.ButtName[indexes[0]], setByGender, buttExercises.ButtReps[indexes[0]], buttExercises.ButtName[indexes[1]], setByGender, buttExercises.ButtReps[indexes[1]], buttExercises.ButtName[indexes[2]], setByGender, buttExercises.ButtReps[indexes[2]], buttMuscleDiag, viewAll6_LinkClicked);
                }
                if (leg == 1)
                {
                    setPanel("Leg Workout", exerNumByBmi, legExercises.LegName[indexes[0]], setByGender, legExercises.LegReps[indexes[0]], legExercises.LegName[indexes[1]], setByGender, legExercises.LegReps[indexes[1]], legExercises.LegName[indexes[2]], setByGender, legExercises.LegReps[indexes[2]], legMuscleDiag, viewAll7_LinkClicked);
                }

                reportForm.historyContent.Controls.Clear();
               

            } else
            {
                getAreasFocused();
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "SELECT * FROM `report` WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    workoutTotal = reader.GetInt32("workout- number");
                    workoutMinutes = reader.GetInt32("minutes");
                    workoutDays = reader.GetInt32("day");
                }
                con.Close();
                reportForm.workoutTotal.Text = Convert.ToString(workoutTotal);
                reportForm.minuteTotal.Text = Convert.ToString(workoutMinutes);
                reportForm.daysTotal.Text = Convert.ToString(workoutDays);
                reportForm.Minutes = workoutMinutes;
                reportForm.workToday.Text = Convert.ToString(workoutToday);
                reportForm.historyContent.Controls.Clear();
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string query = "SELECT * FROM `history` WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    FlowLayoutPanel histPanel = new FlowLayoutPanel();
                    histPanel.Size = new System.Drawing.Size(754, 62);

                    Label dateLbl = new Label();
                    dateLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dateLbl.Location = new System.Drawing.Point(3, 0);
                    dateLbl.Name = "date";
                    dateLbl.Size = new System.Drawing.Size(145, 62);
                    dateLbl.TabIndex = 0;
                    dateLbl.Text = reader2.GetString("date");
                    dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Label workoutLbl = new Label();
                    workoutLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    workoutLbl.Location = new System.Drawing.Point(154, 0);
                    workoutLbl.Name = "workout";
                    workoutLbl.Size = new System.Drawing.Size(456, 62);
                    workoutLbl.TabIndex = 1;
                    workoutLbl.Text = reader2.GetString("workout");
                    workoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Label timeLbl = new Label();
                    timeLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    timeLbl.Location = new System.Drawing.Point(616, 0);
                    timeLbl.Name = "time";
                    timeLbl.Size = new System.Drawing.Size(133, 62);
                    timeLbl.TabIndex = 2;
                    timeLbl.Text = reader2.GetString("time");
                    timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    histPanel.Controls.Add(dateLbl);
                    histPanel.Controls.Add(workoutLbl);
                    histPanel.Controls.Add(timeLbl);
                    reportForm.historyContent.Controls.Add(histPanel);
                }
                    
            }

            timeTo0();
            backBtn.Location = new Point(20, 60);
            startBtn.Location = new Point(513, 440);
            startBtn.BackColor = Color.FromArgb(156, 255, 255, 255);
            regenBtn.Location = new Point(813, 457);
            nextSetBtn.Location = new Point(651, 471);
            nextSetBtn.BackColor = Color.FromArgb(156, 255, 255, 255);
            changePassBtn.Location = new Point(343, 294);
            heightEdit.Location = new Point(580, 227);
            weightEdit.Location = new Point(920, 228);
            usernameEdit.Location = new Point(727, 165);
            signOutBtn.Location = new Point(902, 491);
            signUpBtn.Location = new Point(313, 487);
        }
        
        private void getAreasFocused()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string qry = "SELECT * FROM `users` WHERE username = @Username";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@Username", user_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                gender = reader.GetString("gender");
                userId = reader.GetInt32("id");
                bodyType = reader.GetString("body-type");
                userHeight = reader.GetDouble("height");
                userWeight = reader.GetDouble("weight");
                bmi = reader.GetDouble("bmi");
                MySqlConnection connect = new MySqlConnection(connstring);
                connect.Open();
                string query = "SELECT * FROM `areasfocused` WHERE userId = @userId";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    back = reader2.GetInt32("back");
                    shoulder = reader2.GetInt32("shoulder");
                    arm = reader2.GetInt32("arm");
                    chest = reader2.GetInt32("chest");
                    abs = reader2.GetInt32("abs");
                    butt = reader2.GetInt32("butt");
                    leg = reader2.GetInt32("leg");
                    int setByGender = (gender == "Male") ? 4 : 3;
                    int exerNumByBmi = 6;
                    if (bodyType == "Under Weight")
                    {
                        exerNumByBmi = 5;
                    }
                    else if (bodyType == "Healthy")
                    {
                        exerNumByBmi = 6;
                    }
                    else if (bodyType == "Over Weight")
                    {
                        exerNumByBmi = 7;
                    }


                    Image absMuscleDiag = global::GWT.Properties.Resources.muscleAbsGWT;
                    Image backMuscleDiag = global::GWT.Properties.Resources.muscleBackGWT;
                    Image chestMuscleDiag = global::GWT.Properties.Resources.muscleChestGWT;
                    Image armMuscleDiag = global::GWT.Properties.Resources.muscleArmGWT;
                    Image shoulderMuscleDiag = global::GWT.Properties.Resources.muscleShoulderGWT;
                    Image buttMuscleDiag = global::GWT.Properties.Resources.muscleButtGWT;
                    Image legMuscleDiag = global::GWT.Properties.Resources.muscleLegGWT;

                    if (back == 1)
                    {
                        setPanel("Back Workout", exerNumByBmi, backExercises.BackName[indexes[0]], setByGender, backExercises.BackReps[indexes[0]], backExercises.BackName[indexes[1]], setByGender, backExercises.BackReps[indexes[1]], backExercises.BackName[indexes[2]], setByGender, backExercises.BackReps[indexes[2]], backMuscleDiag, viewAll_LinkClicked);
                    }
                    if (shoulder == 1)
                    {
                        setPanel("Shoulder Workout", exerNumByBmi, shoulderExercises.ShoulderName[indexes[0]], setByGender, shoulderExercises.ShoulderReps[indexes[0]], shoulderExercises.ShoulderName[indexes[1]], setByGender, shoulderExercises.ShoulderReps[indexes[1]], shoulderExercises.ShoulderName[indexes[2]], setByGender, shoulderExercises.ShoulderReps[indexes[2]], shoulderMuscleDiag, viewAll2_LinkClicked);
                    }
                    if (arm == 1)
                    {
                        setPanel("Arm Workout", exerNumByBmi, armExercises.ArmName[indexes[0]], setByGender, armExercises.ArmReps[indexes[0]], armExercises.ArmName[indexes[1]], setByGender, armExercises.ArmReps[indexes[1]], armExercises.ArmName[indexes[2]], setByGender, armExercises.ArmReps[indexes[2]], armMuscleDiag, viewAll3_LinkClicked);
                    }
                    if (chest == 1)
                    {
                        setPanel("Chest Workout", exerNumByBmi, chestExercises.ChestName[indexes[0]], setByGender, chestExercises.ChestReps[indexes[0]], chestExercises.ChestName[indexes[1]], setByGender, chestExercises.ChestReps[indexes[1]], chestExercises.ChestName[indexes[2]], setByGender, chestExercises.ChestReps[indexes[2]], chestMuscleDiag, viewAll4_LinkClicked);
                    }
                    if (abs == 1)
                    {
                        setPanel("Abs Workout", exerNumByBmi, absExercises.AbsName[indexes[0]], setByGender, absExercises.AbstReps[indexes[0]], absExercises.AbsName[indexes[1]], setByGender, absExercises.AbstReps[indexes[1]], absExercises.AbsName[indexes[2]], setByGender, absExercises.AbstReps[indexes[2]], absMuscleDiag, viewAll5_LinkClicked);
                    }
                    if (butt == 1)
                    {
                        setPanel("Butt Workout", exerNumByBmi, buttExercises.ButtName[indexes[0]], setByGender, buttExercises.ButtReps[indexes[0]], buttExercises.ButtName[indexes[1]], setByGender, buttExercises.ButtReps[indexes[1]], buttExercises.ButtName[indexes[2]], setByGender, buttExercises.ButtReps[indexes[2]], buttMuscleDiag, viewAll6_LinkClicked);
                    }
                    if (leg == 1)
                    {
                        setPanel("Leg Workout", exerNumByBmi, legExercises.LegName[indexes[0]], setByGender, legExercises.LegReps[indexes[0]], legExercises.LegName[indexes[1]], setByGender, legExercises.LegReps[indexes[1]], legExercises.LegName[indexes[2]], setByGender, legExercises.LegReps[indexes[2]], legMuscleDiag, viewAll7_LinkClicked);
                    }

                }
                connect.Close();
            }
            conn.Close();
        }
        public void displayUsername()
        {
            usernameLbl.Text = user_name.ToUpper();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void viewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isBack = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, backExercises.BackName, backExercises.BackImgs, backExercises.BackReps, "Back", global::GWT.Properties.Resources.muscleBackGWT);
        }
        private void viewAll2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isShoulder = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, shoulderExercises.ShoulderName, shoulderExercises.ShoulderImgs, shoulderExercises.ShoulderReps, "Shoulder", global::GWT.Properties.Resources.muscleShoulderGWT);
        }
        private void viewAll3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isArm = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, armExercises.ArmName, armExercises.ArmImgs, armExercises.ArmReps, "Arm", global::GWT.Properties.Resources.muscleArmGWT);
        }
        private void viewAll4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isChest = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, chestExercises.ChestName, chestExercises.ChestImgs, chestExercises.ChestReps, "Chest", global::GWT.Properties.Resources.muscleChestGWT);
        }
        private void viewAll5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isAbs = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, absExercises.AbsName, absExercises.AbsImgs, absExercises.AbstReps, "Abs", global::GWT.Properties.Resources.muscleAbsGWT);
        }
        private void viewAll6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isButt = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, buttExercises.ButtName, buttExercises.ButtImgs, buttExercises.ButtReps, "Butt", global::GWT.Properties.Resources.muscleButtGWT);
        }
        private void viewAll7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLeg = true;
            TitleLbl.Visible = false;
            viewAllFunc(indexes, legExercises.LegName, legExercises.LegImgs, legExercises.LegReps, "Leg", global::GWT.Properties.Resources.muscleLegGWT);
        }

        public void setPanel(string WorkoutName, int numberExercise, string exerciseName1, int setNum1, string repsNum1, string exerciseName2, int setNum2, string repsNum2, string exerciseName3, int setNum3, string repsNum3, Image musclesDiag, System.Windows.Forms.LinkLabelLinkClickedEventHandler viewAllEvent)
        {
            Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel();
            panel.Location = new Point(x, y);
            panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(196)))));
            panel.Name = "pullUpPanel";
            panel.BorderRadius = 20;
            panel.Size = new System.Drawing.Size(width, height);
            panel.TabIndex = 2;

            Label workoutName = new Label();
            workoutName.AutoSize = true;
            workoutName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workoutName.ForeColor = System.Drawing.Color.Black;
            workoutName.Location = new System.Drawing.Point(26, 18);
            workoutName.Name = "workOutName";
            workoutName.Size = new System.Drawing.Size(143, 30);
            workoutName.TabIndex = 0;
            workoutName.Text = WorkoutName;

            Label exerciseNum = new Label();
            exerciseNum.AutoSize = true;
            exerciseNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exerciseNum.Location = new System.Drawing.Point(27, 48);
            exerciseNum.Name = "exerciseNum";
            exerciseNum.Size = new System.Drawing.Size(85, 20);
            exerciseNum.TabIndex = 1;
            exerciseNum.Text = Convert.ToString(numberExercise) +  " Exercises";

            Label exercise1 = new Label();
            exercise1.AutoSize = true;
            exercise1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exercise1.Location = new System.Drawing.Point(28, 120);
            exercise1.Name = "Exercise1";
            exercise1.Size = new System.Drawing.Size(115, 20);
            exercise1.TabIndex = 2;
            exercise1.Text = exerciseName1;

            Label exer1Set = new Label();
            exer1Set.AutoSize = true;
            exer1Set.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exer1Set.Location = new System.Drawing.Point(316, 120);
            exer1Set.Name = "exer1Set";
            exer1Set.TabIndex = 6;
            exer1Set.Text = Convert.ToString(setNum1) + " x " + Convert.ToString(repsNum1);

            Label exercise2 = new Label();
            exercise2.AutoSize = true;
            exercise2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exercise2.Location = new System.Drawing.Point(28, 154);
            exercise2.Name = "Exercise1";
            exercise2.Size = new System.Drawing.Size(115, 20);
            exercise2.TabIndex = 2;
            exercise2.Text = exerciseName2;

            Label exer2Set = new Label();
            exer2Set.AutoSize = true;
            exer2Set.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exer2Set.Location = new System.Drawing.Point(316, 154);
            exer2Set.Name = "exer1Set";
            exer2Set.TabIndex = 6;
            exer2Set.Text = Convert.ToString(setNum2) + " x " + Convert.ToString(repsNum2);

            Label exercise3 = new Label();
            exercise3.AutoSize = true;
            exercise3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exercise3.Location = new System.Drawing.Point(28, 186);
            exercise3.Name = "Exercise1";
            exercise3.Size = new System.Drawing.Size(115, 20);
            exercise3.TabIndex = 2;
            exercise3.Text = exerciseName3;

            Label exer3Set = new Label();
            exer3Set.AutoSize = true;
            exer3Set.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exer3Set.Location = new System.Drawing.Point(316, 186);
            exer3Set.Name = "exer1Set";
            exer3Set.TabIndex = 6;
            exer3Set.Text = Convert.ToString(setNum3) + " x " + Convert.ToString(repsNum3);

            LinkLabel viewAll = new LinkLabel();
            viewAll.AutoSize = true;
            viewAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewAll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            viewAll.Location = new System.Drawing.Point(144, 246);
            viewAll.Name = "viewAll";
            viewAll.Size = new System.Drawing.Size(59, 17);
            viewAll.TabIndex = 5;
            viewAll.TabStop = true;
            viewAll.Text = "View All";
            viewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(viewAllEvent);

            Guna.UI2.WinForms.Guna2PictureBox musclePic = new Guna.UI2.WinForms.Guna2PictureBox();
            musclePic.Image = musclesDiag;
            musclePic.Location = new System.Drawing.Point(608, 18);
            musclePic.Name = "guna2PictureBox1";
            musclePic.ShadowDecoration.Parent = this.guna2PictureBox1;
            musclePic.Size = new System.Drawing.Size(129, 245);
            musclePic.TabIndex = 9;
            musclePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            musclePic.TabStop = false;

            mainPanel.Controls.Add(panel);
            panel.Controls.Add(exercise1);
            panel.Controls.Add(exer1Set);
            panel.Controls.Add(exercise2);
            panel.Controls.Add(exer2Set);
            panel.Controls.Add(exercise3);
            panel.Controls.Add(exer3Set);
            panel.Controls.Add(viewAll);
            panel.Controls.Add(musclePic);
            panel.Controls.Add(exerciseNum);
            panel.Controls.Add(workoutName);
            y += addX;
        }

        private void ContentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (ContentsPanel.Controls.Contains(workForm.WorkMainPanel))
            {
                Control[] trainingPanels = { NavPanel, mainPanel };
                ContentsPanel.Controls.Remove(workForm.WorkMainPanel);
                foreach(Control cont in trainingPanels)
                {
                    ContentsPanel.Controls.Add(cont);
                }
                backBtn.Visible = false;
                regenBtn.Visible = false;
                startBtn.Visible = false;
                TitleLbl.Visible = true;
                if (isBack)
                {
                    isBack = false;
                } else if (isShoulder)
                {
                    isShoulder = false;
                }
                
            } else if (ContentsPanel.Controls.Contains(routineForm.RoutMainPanel))
            {
                
                
                if (index != 5 || !checkbox1.Checked || !checkbox2.Checked || !checkbox3.Checked || !checkbox4.Checked)
                {
                    DialogResult dialog = MessageBox.Show("You want to quit?", "Your Workout Session is not finished yet", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        isWorkingOut = false;
                        ContentsPanel.Controls.Remove(routineForm.RoutMainPanel);
                        ContentsPanel.Controls.Add(workForm.WorkMainPanel);
                        regenBtn.Visible = true;
                        startBtn.Visible = true;
                        nextSetBtn.Visible = false;
                    } 
                }
            }
        }

        private void btnsForProfileClose()
        {
            changePassBtn.Visible = false;
            usernameEdit.Visible = false;
            heightEdit.Visible = false;
            weightEdit.Visible = false;
            signOutBtn.Visible = false;
            signUpBtn.Visible = false;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "PROFILE";
            profileBtn.FillColor = Color.FromArgb(226, 105, 114);
            trainingBtn.FillColor = Color.Transparent;
            exercisesBtn.FillColor = Color.Transparent;
            reportBtn.FillColor = Color.Transparent;
            changePassBtn.Visible = true;
            usernameEdit.Visible = true;
            heightEdit.Visible = true;
            weightEdit.Visible = true;
            signOutBtn.Visible = true;
            if (!isLoggedIn)
            {
                signUpBtn.Visible = true;
                signOutBtn.Visible = false;
                changePassBtn.Visible = false;
            } 
            mainPanel.Controls.Clear();

            profileForm.userName.Text = username;
            profileForm.HeightNum.Text = Convert.ToString(userHeight);
            profileForm.WeightNum.Text = Convert.ToString(userWeight);
            profileForm.BmiNum.Text = Convert.ToString(bmi);
            profileForm.BodyType.Text = bodyType;

            mainPanel.Controls.Add(profileForm.mainPanel);
        }
        bool isEditingUsername = false, isEditingHeight = false, isEditingWeight = false;

        private void weightEdit_Click(object sender, EventArgs e)
        {
            if (!isEditingWeight)
            {
                isEditingWeight = true;
                profileForm.weightTxt.Text = Convert.ToString(userWeight);
                profileForm.weightTxt.Visible = true;
                weightEdit.Image = global::GWT.Properties.Resources.Done;
            }
            else
            {
                isEditingWeight = false;
                userWeight = Convert.ToDouble(profileForm.weightTxt.Text);
                profileForm.WeightNum.Text = Convert.ToString(userWeight);
                bmi = userWeight / (userHeight * userHeight);
                if (bmi <= 18.5)
                {
                    bodyType = "Under Weight";
                }
                else if (bmi >= 18.6 && bmi <= 25)
                {
                    bodyType = "Healthy";
                }
                else if (bmi > 25)
                {
                    bodyType = "Over Weight";
                }
                profileForm.BodyType.Text = bodyType;
                profileForm.BmiNum.Text = bmi.ToString("#.##");
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `users` SET `weight`= @weight, `bmi`= @bmi, `body-type` = @bodyType WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@weight", userWeight);
                cmd.Parameters.AddWithValue("@bmi", bmi);
                cmd.Parameters.AddWithValue("@bodyType", bodyType);
                cmd.Parameters.AddWithValue("Id", userId);
                cmd.ExecuteNonQuery();
                con.Close();
                profileForm.weightTxt.Visible = false;
                weightEdit.Image = global::GWT.Properties.Resources.Edit__1_;
            }
        }
        bool isChangingPass = false;
        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (!isChangingPass)
            {
                isChangingPass = true;
                profileForm.changePassPanel.Visible = true;
            } else
            {
                if (string.IsNullOrEmpty(profileForm.currPassTxt.Text) && string.IsNullOrEmpty(profileForm.newPassTxt.Text))
                {
                    profileForm.changePassPanel.Visible = false;
                    isChangingPass = false;
                } else if (string.IsNullOrEmpty(profileForm.currPassTxt.Text) || string.IsNullOrEmpty(profileForm.newPassTxt.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                } else if (profileForm.newPassTxt.Text.Length < 8)
                {
                    MessageBox.Show("Password must be contain atleast 8 characters");
                } else
                {
                    try
                    {
                        string newPass = profileForm.newPassTxt.Text;
                        string currPass = profileForm.currPassTxt.Text;
                        MySqlConnection con = new MySqlConnection(connstring);
                        con.Open();
                        string qry = "UPDATE `users` SET `password` = @pass WHERE id = @Id AND password = @currPass";
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@pass", HashPassword(newPass));
                        cmd.Parameters.AddWithValue("@currPass", HashPassword(currPass));
                        cmd.Parameters.AddWithValue("Id", userId);
                        int changed = cmd.ExecuteNonQuery();
                        if (changed > 0)
                        {
                            isChangingPass = false;
                            profileForm.changePassPanel.Visible = false;
                        } else
                        {
                            MessageBox.Show("Wrong Current Password");
                        }
                        
                    } catch (MySqlException ex)
                    {
                        switch (ex.Number)
                        {
                            case 0:
                                MessageBox.Show("Cannot connect to server. Contact administrator.");
                                break;
                            case 1042:
                                MessageBox.Show("Can't connect To server");
                                break;
                            default:
                                MessageBox.Show($"MySQL error number: {ex.Number}. Message: {ex.Message}");
                                break;
                        }
                    }
                }
            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm signUp = new signUpForm();
            signUp.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void usernameEdit_Click(object sender, EventArgs e)
        {
            if (!isEditingUsername)
            {
                isEditingUsername = true;
                profileForm.userNameTxt.Text = username;
                profileForm.userNameTxt.Visible = true;
                usernameEdit.Image = global::GWT.Properties.Resources.Done;
            } else
            {
                isEditingUsername = false;
                username = profileForm.userNameTxt.Text;
                profileForm.userName.Text = username;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `users` SET `username`= @userName WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("Id", userId);
                cmd.ExecuteNonQuery();
                con.Close();
                profileForm.userNameTxt.Visible = false;
                usernameEdit.Image = global::GWT.Properties.Resources.Edit__1_;
            }
        }

        private void heightEdit_Click(object sender, EventArgs e)
        {
            if (!isEditingHeight)
            {
                isEditingHeight = true;
                profileForm.heightTxt.Text = Convert.ToString(userHeight);
                profileForm.heightTxt.Visible = true;
                heightEdit.Image = global::GWT.Properties.Resources.Done;
            } else
            {
                isEditingHeight = false;
                userHeight = Convert.ToDouble(profileForm.heightTxt.Text);
                profileForm.HeightNum.Text = Convert.ToString(userHeight);
                bmi = userWeight / (userHeight * userHeight);
                if (bmi <= 18.5)
                {
                    bodyType = "Under Weight";
                } else if (bmi >= 18.6 && bmi <= 25) {
                    bodyType = "Healthy";
                } else if (bmi > 25)
                {
                    bodyType = "Over Weight";
                }
                profileForm.BodyType.Text = bodyType;
                profileForm.BmiNum.Text = bmi.ToString("#.##");
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `users` SET `height`= @height, `bmi` = @bmi, `body-type` = @bodyType WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@height", userHeight);
                cmd.Parameters.AddWithValue("@bmi", bmi);
                cmd.Parameters.AddWithValue("@bodyType", bodyType);
                cmd.Parameters.AddWithValue("Id", userId);
                cmd.ExecuteNonQuery();
                con.Close();
                
                profileForm.heightTxt.Visible = false;
                heightEdit.Image = global::GWT.Properties.Resources.Edit__1_;
            }
        }

        private void workOutSet(Image workoutIllus, string workoutName, int exerSet, string exerReps, int panelY)
        {

            Guna.UI2.WinForms.Guna2Panel exerciseType = new Guna.UI2.WinForms.Guna2Panel();
            exerciseType.BorderRadius = 15;
            exerciseType.Controls.Add(this.guna2PictureBox1);
            exerciseType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            exerciseType.Location = new System.Drawing.Point(140, panelY);
            exerciseType.Name = "exerciseType";
            exerciseType.ShadowDecoration.Parent = exerciseType;
            exerciseType.Size = new System.Drawing.Size(410, 73);
            exerciseType.TabIndex = 2;

            Guna.UI2.WinForms.Guna2PictureBox exerIllust = new Guna.UI2.WinForms.Guna2PictureBox();
            exerIllust.Image = workoutIllus;
            exerIllust.Location = new System.Drawing.Point(15, 7);
            exerIllust.Name = "guna2PictureBox1";
            exerIllust.ShadowDecoration.Parent = exerIllust;
            exerIllust.Size = new System.Drawing.Size(89, 61);
            exerIllust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            exerIllust.TabIndex = 0;
            exerIllust.TabStop = false;

            Label exerName = new Label();
            exerName.AutoSize = true;
            exerName.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exerName.Location = new System.Drawing.Point(132, 7);
            exerName.Name = "exerName";
            exerName.Size = new System.Drawing.Size(171, 30);
            exerName.TabIndex = 1;
            exerName.Text = workoutName;

            Label exerSets = new Label();
            exerSets.AutoSize = true;
            exerSets.Location = new System.Drawing.Point(184, 46);
            exerSets.Name = "label2";
            exerSets.Size = new System.Drawing.Size(75, 13);
            exerSets.TabIndex = 2;
            if (exerReps.Contains("secs") || exerReps.Contains("mins"))
            {
                exerSets.Text = Convert.ToString(exerSet) + " sets x " + exerReps;
            } else
            {
                exerSets.Text = Convert.ToString(exerSet) + " sets x " + exerReps + " reps";
            }
            
            workForm.exercisePanel.Controls.Add(exerciseType);
            exerciseType.Controls.Add(exerIllust);
            exerciseType.Controls.Add(exerName);
            exerciseType.Controls.Add(exerSets);

        }
        
        private void regenBtn_Click(object sender, EventArgs e)
        {
            indexes = RandomIndexer(0, 11, 6);
            
            workForm.exercisePanel.Controls.Clear();
            int setByGender = (gender == "Male") ? 4 : 3;
            int panelY = 18;
            int panelGaps = 79;
            int indexNum = 0;
            int exerNumByBmi = 6;
            if (bodyType == "Under Weight")
            {
                exerNumByBmi = 5;
            }
            else if (bodyType == "Healthy")
            {
                exerNumByBmi = 6;
            }
            else if (bodyType == "Over Weight")
            {
                exerNumByBmi = 7;
            }
            if (isBack)
            {
                for(int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(backExercises.BackImgs[indexes[indexNum]], backExercises.BackName[indexes[indexNum]], setByGender, backExercises.BackReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isShoulder)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(shoulderExercises.ShoulderImgs[indexes[indexNum]], shoulderExercises.ShoulderName[indexes[indexNum]], setByGender, shoulderExercises.ShoulderReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isArm)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(armExercises.ArmImgs[indexes[indexNum]], armExercises.ArmName[indexes[indexNum]], setByGender, armExercises.ArmReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isChest)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(chestExercises.ChestImgs[indexes[indexNum]], chestExercises.ChestName[indexes[indexNum]], setByGender, chestExercises.ChestReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isAbs)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(absExercises.AbsImgs[indexes[indexNum]], absExercises.AbsName[indexes[indexNum]], setByGender, absExercises.AbstReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isButt)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(buttExercises.ButtImgs[indexes[indexNum]], buttExercises.ButtName[indexes[indexNum]], setByGender, buttExercises.ButtReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            } else if (isLeg)
            {
                for (int i = 1; i <= exerNumByBmi; i++)
                {
                    workOutSet(legExercises.LegImgs[indexes[indexNum]], legExercises.LegName[indexes[indexNum]], setByGender, legExercises.LegReps[indexes[indexNum]], panelY);
                    panelY += panelGaps;
                    indexNum++;
                }
            }
        }

        private void workoutTimer_Tick(object sender, EventArgs e)
        {
            if (isWorkingOut)
            {
                TimeMs++;
                if (TimeMs >= 100)
                {
                    TimeMs = 0;
                    TimeS++;
                    if (TimeS < 10)
                    {
                        routineForm.SecondLbl.Text = "0" + Convert.ToString(TimeS);
                    } else
                    {
                        routineForm.SecondLbl.Text = Convert.ToString(TimeS);
                    }
                    if (TimeS >= 59)
                    {
                        TimeS = 0;
                        TimeM++;
                        if (TimeM < 10)
                        {
                            routineForm.MinuteLbl.Text = "0" + Convert.ToString(TimeM);
                        } else
                        {
                            routineForm.MinuteLbl.Text = Convert.ToString(TimeM);
                        }
                        if (TimeM >= 59)
                        {
                            TimeM = 0;
                            TimeH++;
                            if (TimeH < 10)
                            {
                                routineForm.HourLbl.Text = "0" + Convert.ToString(TimeH);
                            } else
                            {
                                routineForm.HourLbl.Text = Convert.ToString(TimeH);
                            }
                        }
                    }
                }
            }
        }

        
        private int[] RandomIndexer(int min, int max, int count)
        {
            HashSet<int> index = new HashSet<int>();

            while (index.Count < count)
            {
                int number = randNum.Next(min, max + 1);
                index.Add(number);
            }
            return index.ToArray();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (ContentsPanel.Controls.Contains(workForm.WorkMainPanel)) {
                ContentsPanel.Controls.Remove(workForm.WorkMainPanel);
                ContentsPanel.Controls.Add(routineForm.RoutMainPanel);

                isWorkingOut = true;
                int gaps = 79;
                int panelsY = 13;
                int checkNum = (gender == "Male") ? 4 : 3;
                int checkTypeNum = 0;
                System.EventHandler[] checkEvents = { check1Changed, check2Changed, check3Changed, check4Changed };
                Guna.UI2.WinForms.Guna2CheckBox[] checkBoxxes = { checkbox1, checkbox2, checkbox3, checkbox4 };
                
                if (isBack)
                {
                    routineFormLoad(backExercises.BackGifs[indexes[0]], backExercises.BackName[indexes[0]]);
                    for(int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(backExercises.BackReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isShoulder)
                {
                    routineFormLoad(shoulderExercises.ShoulderGifs[indexes[0]], shoulderExercises.ShoulderName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(shoulderExercises.ShoulderReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isArm)
                {
                    routineFormLoad(armExercises.ArmGifs[indexes[0]], armExercises.ArmName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(armExercises.ArmReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isChest) {
                    routineFormLoad(chestExercises.ChestGifs[indexes[0]], chestExercises.ChestName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(chestExercises.ChestReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isAbs)
                {
                    routineFormLoad(absExercises.AbsGifs[indexes[0]], absExercises.AbsName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(absExercises.AbstReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isButt)
                {
                    routineFormLoad(buttExercises.ButtGifs[indexes[0]], buttExercises.ButtName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(buttExercises.ButtReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                } else if (isLeg)
                {
                    routineFormLoad(legExercises.LegGifs[indexes[0]], legExercises.LegName[indexes[0]]);
                    for (int i = 1; i <= checkNum; i++)
                    {
                        setCheckMaker(legExercises.LegReps[indexes[0]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                        panelsY += gaps;
                        checkTypeNum++;
                    }
                }
                regenBtn.Visible = false;
                startBtn.Visible = false;
                nextSetBtn.Visible = true;
            }
            
        }

        private void exercisesBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "EXERCISES";
            y = 81;
            trainingBtn.FillColor = Color.Transparent;
            exercisesBtn.FillColor = Color.FromArgb(255, 226, 105, 114);
            reportBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            btnsForProfileClose();
            mainPanel.Controls.Clear();
            int setByGender = (gender == "Male") ? 4 : 3;
            int exerNumByBmi = 6;
            if (bodyType == "Under Weight")
            {
                exerNumByBmi = 5;
            }
            else if (bodyType == "Healthy")
            {
                exerNumByBmi = 6;
            }
            else if (bodyType == "Over Weight")
            {
                exerNumByBmi = 7;
            }
            Image absMuscleDiag = global::GWT.Properties.Resources.muscleAbsGWT;
            Image backMuscleDiag = global::GWT.Properties.Resources.muscleBackGWT;
            Image chestMuscleDiag = global::GWT.Properties.Resources.muscleChestGWT;
            Image armMuscleDiag = global::GWT.Properties.Resources.muscleArmGWT;
            Image shoulderMuscleDiag = global::GWT.Properties.Resources.muscleShoulderGWT;
            Image buttMuscleDiag = global::GWT.Properties.Resources.muscleButtGWT;
            Image legMuscleDiag = global::GWT.Properties.Resources.muscleLegGWT;

            setPanel("Back Workout", exerNumByBmi, backExercises.BackName[indexes[0]], setByGender, backExercises.BackReps[indexes[0]], backExercises.BackName[indexes[1]], setByGender, backExercises.BackReps[indexes[1]], backExercises.BackName[indexes[2]], setByGender, backExercises.BackReps[indexes[2]], backMuscleDiag, viewAll_LinkClicked);
            setPanel("Shoulder Workout", exerNumByBmi, shoulderExercises.ShoulderName[indexes[0]], setByGender, shoulderExercises.ShoulderReps[indexes[0]], shoulderExercises.ShoulderName[indexes[1]], setByGender, shoulderExercises.ShoulderReps[indexes[1]], shoulderExercises.ShoulderName[indexes[2]], setByGender, shoulderExercises.ShoulderReps[indexes[2]], shoulderMuscleDiag, viewAll2_LinkClicked);
            setPanel("Arm Workout", exerNumByBmi, armExercises.ArmName[indexes[0]], setByGender, armExercises.ArmReps[indexes[0]], armExercises.ArmName[indexes[1]], setByGender, armExercises.ArmReps[indexes[1]], armExercises.ArmName[indexes[2]], setByGender, armExercises.ArmReps[indexes[2]], armMuscleDiag, viewAll3_LinkClicked);
            setPanel("Chest Workout", exerNumByBmi, chestExercises.ChestName[indexes[0]], setByGender, chestExercises.ChestReps[indexes[0]], chestExercises.ChestName[indexes[1]], setByGender, chestExercises.ChestReps[indexes[1]], chestExercises.ChestName[indexes[2]], setByGender, chestExercises.ChestReps[indexes[2]], chestMuscleDiag, viewAll4_LinkClicked);
            setPanel("Abs Workout", exerNumByBmi, absExercises.AbsName[indexes[0]], setByGender, absExercises.AbstReps[indexes[0]], absExercises.AbsName[indexes[1]], setByGender, absExercises.AbstReps[indexes[1]], absExercises.AbsName[indexes[2]], setByGender, absExercises.AbstReps[indexes[2]], absMuscleDiag, viewAll5_LinkClicked);
            setPanel("Butt Workout", exerNumByBmi, buttExercises.ButtName[indexes[0]], setByGender, buttExercises.ButtReps[indexes[0]], buttExercises.ButtName[indexes[1]], setByGender, buttExercises.ButtReps[indexes[1]], buttExercises.ButtName[indexes[2]], setByGender, buttExercises.ButtReps[indexes[2]], buttMuscleDiag, viewAll6_LinkClicked);
            setPanel("Leg Workout", exerNumByBmi, legExercises.LegName[indexes[0]], setByGender, legExercises.LegReps[indexes[0]], legExercises.LegName[indexes[1]], setByGender, legExercises.LegReps[indexes[1]], legExercises.LegName[indexes[2]], setByGender, legExercises.LegReps[indexes[2]], legMuscleDiag, viewAll7_LinkClicked);
            
        }

        private void trainingBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "TRAINING";
            mainPanel.Controls.Clear();
            trainingBtn.FillColor = Color.FromArgb(226, 105, 114);
            exercisesBtn.FillColor = Color.Transparent;
            reportBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            btnsForProfileClose();
            y = 81;
            getAreasFocused();
        }

        private void routineFormLoad(Image exGif, string exName)
        {
            routineForm.exerciseGif.Image = exGif;
            routineForm.ExerciseName.Text = exName;
            int x = ((routineForm.exerciseGif.Location.X + routineForm.exerciseGif.Width) / 2) - (routineForm.ExerciseName.Width / 2);
            int y = routineForm.ExerciseName.Location.Y;
            routineForm.ExerciseName.Location = new Point(x, y);
            routineForm.setPanel.Controls.Clear();
        }

        private void viewAllFunc(int[] arr1, string[] arr2,Image[] arr3, string[] arr4, string Title, Image diag)
        {
            int setByGender = (gender == "Male") ? 4 : 3;
            Control[] trainingPanels = { NavPanel, mainPanel };
            workForm.workoutLbl.Text = Title + " Workout";
            routineForm.routineLbl.Text = Title + " Workout";
            workForm.MuscleDiagram.Image = diag;
            workForm.exercisePanel.Controls.Clear();
            int panelY = 18;
            int panelGaps = 79;
            int indexP = 0;
            int exerNumByBmi = 6;
            if (bodyType == "Under Weight")
            {
                exerNumByBmi = 5;
            }
            else if (bodyType == "Healthy")
            {
                exerNumByBmi = 6;
            }
            else if (bodyType == "Over Weight")
            {
                exerNumByBmi = 7;
            }

            for (int i = 1; i <= exerNumByBmi; i++)
            {
                workOutSet(arr3[arr1[indexP]], arr2[arr1[indexP]], setByGender, arr4[arr1[indexP]], panelY);
                indexP++;
                panelY += panelGaps;
            }

            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);

            backBtn.Visible = true;
            startBtn.Visible = true;
            regenBtn.Visible = true;
        }
        
        private void setCheckMaker(string reps, int PanelY, System.EventHandler checkChange, Guna.UI2.WinForms.Guna2CheckBox checkbox)
        {
            Guna.UI2.WinForms.Guna2Panel setPanel = new Guna.UI2.WinForms.Guna2Panel();
            setPanel.BorderRadius = 15;
            setPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            setPanel.Location = new System.Drawing.Point(70, PanelY);
            setPanel.Name = "guna2Panel2";
            setPanel.ShadowDecoration.Parent = setPanel;
            setPanel.Size = new System.Drawing.Size(330, 64);
            setPanel.TabIndex = 0;
            

            checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            checkbox.CheckedState.BorderRadius = 2;
            checkbox.CheckedState.BorderThickness = 0;
            checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            checkbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkbox.Location = new System.Drawing.Point(13, 7);
            checkbox.Size = new System.Drawing.Size(306, 50);
            checkbox.TabIndex = 0;
            checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            checkbox.UncheckedState.BorderRadius = 2;
            checkbox.UncheckedState.BorderThickness = 0;
            checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += new System.EventHandler(checkChange);
            if (reps.Contains("secs") || reps.Contains("mins"))
            {
                checkbox.Text = "Set 1 x " + reps;
            } else
            {
                checkbox.Text = "Set 1 x " + reps + " reps";
            }
            routineForm.setPanel.Controls.Add(setPanel);
            setPanel.Controls.Add(checkbox);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "REPORT";
            reportBtn.FillColor = Color.FromArgb(226, 105, 114);
            trainingBtn.FillColor = Color.Transparent;
            exercisesBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            btnsForProfileClose();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(reportForm.mainPanel);
            
        }

        private void check1Changed(object sender, EventArgs e)
        {
            if (checkbox1.Checked && checkbox2.Checked && checkbox3.Checked && checkbox4.Checked)
            {
                nextSetBtn.Enabled = true;
            } else
            {
                nextSetBtn.Enabled = false;
            }
        }

        private void check2Changed(object sender, EventArgs e)
        {
            if (checkbox1.Checked && checkbox2.Checked && checkbox3.Checked && checkbox4.Checked)
            {
                nextSetBtn.Enabled = true;
            }
            else
            {
                nextSetBtn.Enabled = false;
            }
        }
        private void check3Changed(object sender, EventArgs e)
        {
            if (checkbox1.Checked && checkbox2.Checked && checkbox3.Checked && checkbox4.Checked)
            {
                nextSetBtn.Enabled = true;
            }
            else
            {
                nextSetBtn.Enabled = false;
            }
        }
        private void check4Changed(object sender, EventArgs e)
        {
            if (checkbox1.Checked && checkbox2.Checked && checkbox3.Checked && checkbox4.Checked)
            {
                nextSetBtn.Enabled = true;
            }
            else
            {
                nextSetBtn.Enabled = false;
            }
        }
        bool isWorkedOutToday = false;
        private void nextSetBtn_Click(object sender, EventArgs e)
        {
            int exerNumByBmi = 6;
            if (bodyType == "Under Weight")
            {
                exerNumByBmi = 5;
            }
            else if (bodyType == "Healthy")
            {
                exerNumByBmi = 6;
            }
            else if (bodyType == "Over Weight")
            {
                exerNumByBmi = 7;
            }
            if (index < exerNumByBmi - 1)
            {
                nextSetBtn.Text = "NEXT";
                UpdateNextContent(index);
                index++;
            } else if (index == exerNumByBmi - 1)
            {
                UpdateNextContent(index);
                nextSetBtn.Text = "FINISH";
                index++;
            } else
            {
                
                ContentsPanel.Controls.Remove(routineForm.RoutMainPanel);
                Control[] trainingPanels = { NavPanel, mainPanel };
                foreach (Control cont in trainingPanels)
                {
                    ContentsPanel.Controls.Add(cont);
                }
                backBtn.Visible = false;
                nextSetBtn.Visible = false;
                TitleLbl.Visible = true;
                workoutTotal++;
                reportForm.seconds += TimeS;
                if (reportForm.seconds > 60)
                {
                    reportForm.Minutes++;
                }
                reportForm.Minutes += TimeM;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `report` SET `workout- number`= @workoutNum,`minutes`= @minutes WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@minutes", reportForm.Minutes);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@workoutNum", workoutTotal);
                cmd.ExecuteNonQuery();
                con.Close();
                reportForm.workoutTotal.Text = Convert.ToString(workoutTotal);
                reportForm.minuteTotal.Text = Convert.ToString(reportForm.Minutes);
                workoutToday++;
                if (!isWorkedOutToday)
                {
                    workoutDays++;
                    MySqlConnection conn = new MySqlConnection(connstring);
                    conn.Open();
                    string query = "UPDATE `report` SET `day`= @day WHERE id = @Id";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@day", workoutDays);
                    command.Parameters.AddWithValue("@Id", userId);
                    command.ExecuteNonQuery();
                    conn.Close();
                    isWorkedOutToday = true;
                }
                reportForm.daysTotal.Text = Convert.ToString(workoutDays);
                reportForm.workToday.Text = Convert.ToString(workoutToday);
                string workoutType = "Back Workout";
                if (isBack)
                {
                    workoutType = "Back Workout";
                } else if (isShoulder)
                {
                    workoutType = "Shoulder Workout";
                }

                DateTime datenow = DateTime.Today;
                string dateSplit = Convert.ToString(datenow);
                string[] date = dateSplit.Split(' ');
                string time = TimeM + " minutes, " + TimeS + " seconds";
                MySqlConnection connection = new MySqlConnection(connstring);
                connection.Open();
                string QRY = "INSERT INTO `history`(`id`, `date`, `workout`, `time`) VALUES (?,?,?,?)";
                MySqlCommand comm = new MySqlCommand(QRY, connection);
                comm.Parameters.AddWithValue("param1", userId);
                comm.Parameters.AddWithValue("param2", date[0]);
                comm.Parameters.AddWithValue("param3", workoutType);
                comm.Parameters.AddWithValue("param4", time);
                comm.ExecuteNonQuery();
                connection.Close();

                FlowLayoutPanel histPanel = new FlowLayoutPanel();
                histPanel.Size = new System.Drawing.Size(754, 62);

                Label dateLbl = new Label();
                dateLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dateLbl.Location = new System.Drawing.Point(3, 0);
                dateLbl.Name = "date";
                dateLbl.Size = new System.Drawing.Size(145, 62);
                dateLbl.TabIndex = 0;
                dateLbl.Text = date[0];
                dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                Label workoutLbl = new Label();
                workoutLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                workoutLbl.Location = new System.Drawing.Point(154, 0);
                workoutLbl.Name = "workout";
                workoutLbl.Size = new System.Drawing.Size(456, 62);
                workoutLbl.TabIndex = 1;
                workoutLbl.Text = workoutType;
                workoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                Label timeLbl = new Label();
                timeLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                timeLbl.Location = new System.Drawing.Point(616, 0);
                timeLbl.Name = "time";
                timeLbl.Size = new System.Drawing.Size(133, 62);
                timeLbl.TabIndex = 2;
                timeLbl.Text = time;
                timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                histPanel.Controls.Add(dateLbl);
                histPanel.Controls.Add(workoutLbl);
                histPanel.Controls.Add(timeLbl);
                reportForm.historyContent.Controls.Add(histPanel);
                timeTo0();
                isBack = false;
                isShoulder = false;
                isArm = false;
                isChest = false;
                isAbs = false;
                isButt = false;
                isLeg = false;
                nextSetBtn.Text = "NEXT";
                index = 1;
                UpdateNextContent(index);
            }
        }

        private  void UpdateNextContent(int index)
        {
            int gaps = 79;
            int panelsY = 13;
            int checkNum = (gender == "Male") ? 4 : 3;
            int checkTypeNum = 0;
            System.EventHandler[] checkEvents = { check1Changed, check2Changed, check3Changed, check4Changed };
            Guna.UI2.WinForms.Guna2CheckBox[] checkBoxxes = { checkbox1, checkbox2, checkbox3, checkbox4 };
            if (isBack)
            {
                routineFormLoad(backExercises.BackGifs[indexes[index]], backExercises.BackName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(backExercises.BackReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isShoulder)
            {
                routineFormLoad(shoulderExercises.ShoulderGifs[indexes[index]], shoulderExercises.ShoulderName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(shoulderExercises.ShoulderReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isArm)
            {
                routineFormLoad(armExercises.ArmGifs[indexes[index]], armExercises.ArmName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(armExercises.ArmReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isChest)
            {
                routineFormLoad(chestExercises.ChestGifs[indexes[index]], chestExercises.ChestName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(chestExercises.ChestReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isAbs)
            {
                routineFormLoad(absExercises.AbsGifs[indexes[index]], absExercises.AbsName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(absExercises.AbstReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isButt)
            {
                routineFormLoad(buttExercises.ButtGifs[indexes[index]], buttExercises.ButtName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(buttExercises.ButtReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            else if (isLeg)
            {
                routineFormLoad(legExercises.LegGifs[indexes[index]], legExercises.LegName[indexes[index]]);
                for (int i = 1; i <= checkNum; i++)
                {
                    setCheckMaker(legExercises.LegReps[indexes[index]], panelsY, checkEvents[checkTypeNum], checkBoxxes[checkTypeNum]);
                    panelsY += gaps;
                    checkTypeNum++;
                }
            }
            
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            checkbox3.Checked = false;
            checkbox4.Checked = false;
        }

    }


    // Workout Datas
    public class BackExer
    {
        public string[] BackName = { "Pull Ups", "Bent Over Rows", "Dead Hang", "Lat Pull Downs", "Seated Cable Rows", "One Arm Dumbbell Row",
            "Deadlift", "Alternate Renegade Row", "Farmers Walk", "Band Lat Pull Down", "Chest Supported Rows", "Barbell Dead Row" };
        public string[] BackReps = { "6", "12", "00:20 secs", "8", "12", "12", "4-8", "8-12", "00:30 secs", "12", "8", "12" };      
        public Image[] BackImgs = { global::GWT.Properties.Resources.PullUpsimgGWT, global::GWT.Properties.Resources.BentOverRowsimgGWT, global::GWT.Properties.Resources.deadHangimgGWT, global::GWT.Properties.Resources.latPullDownimgGWT, global::GWT.Properties.Resources.seatedCableRowsimgGWT, global::GWT.Properties.Resources.oneArmDumbbellRowimgGWT,
        global::GWT.Properties.Resources.deadliftimgGWT, global::GWT.Properties.Resources.renegadeRowsimgGWT, global::GWT.Properties.Resources.farmersWalkimgGWT, global::GWT.Properties.Resources.bandLatPulldownimgGWT, global::GWT.Properties.Resources.chestBellRowimgGWT, global::GWT.Properties.Resources.barbellRowimgGWT };
        public Image[] BackGifs = { global::GWT.Properties.Resources.PullUpsgifGWT, global::GWT.Properties.Resources.BentOverRowsgifGWT, global::GWT.Properties.Resources.deadHanggifGWT, global::GWT.Properties.Resources.latPullDowngifGWT, global::GWT.Properties.Resources.seatedCableRowsgifGWT, global::GWT.Properties.Resources.oneArmDumbbellRowgifGWT,
        global::GWT.Properties.Resources.deadliftgifGWT, global::GWT.Properties.Resources.renegadeRowsgifGWT, global::GWT.Properties.Resources.farmersWalkgifGWT, global::GWT.Properties.Resources.bandLatPulldowngifGWT, global::GWT.Properties.Resources.chestBellRowgifGWT, global::GWT.Properties.Resources.barbellRowgifGWT };
    }

    public class ShoulderExer
    {
        public string[] ShoulderName = { "Dumbbell Shoulder Press", "Seated Barbell Shoulder Press", "Arm Circles", "Dumbbell Lateral Raise", "Side Arm Raise", "Cable Lateral Raise", "Machine Shoulder Press", "Overhead Press", "Dumbbell 4 Way Lateral Raise", "Seated Behind Neck Press", "Arnold Press", "Bent Over Lateral Raise" };
        public string[] ShoulderReps = { "8", "8", "20", "12", "12", "6", "8", "8", "8", "5", "8", "12" };
        public Image[] ShoulderImgs = { global::GWT.Properties.Resources.Dumbbell_Shoulder_PressimgGWT, global::GWT.Properties.Resources.Seated_Shoulder_PressimgGWT, global::GWT.Properties.Resources.armCirclesShouldersimgGWT, global::GWT.Properties.Resources.Dumbbell_Lateral_RaiseimgGWT, global::GWT.Properties.Resources.side_arm_raiseimgGWT, global::GWT.Properties.Resources.one_arm_Cable_Lateral_RaiseimgGWT,
            global::GWT.Properties.Resources.Machine_Shoulder_PressimgGWT, global::GWT.Properties.Resources.Overhead_PressimgGWT,global::GWT.Properties.Resources.Dumbbell_4_Ways_Lateral_RaiseimgGWT, global::GWT.Properties.Resources.Seated_Behind_the_Neck_PressimgGWT, global::GWT.Properties.Resources.ArnoldPressimgGWT, global::GWT.Properties.Resources.Bent_Over_Lateral_RaiseimgGWT };
        public Image[] ShoulderGifs = { global::GWT.Properties.Resources.Dumbbell_Shoulder_PressgifGWT, global::GWT.Properties.Resources.Seated_Shoulder_PressgifGWT, global::GWT.Properties.Resources.armCirclesShouldersgifGWT, global::GWT.Properties.Resources.Dumbbell_Lateral_RaisegifGWT, global::GWT.Properties.Resources.side_arm_raisegifGWT, global::GWT.Properties.Resources.one_arm_Cable_Lateral_RaisegifGWT,
            global::GWT.Properties.Resources.Machine_Shoulder_PressgifGWT, global::GWT.Properties.Resources.Overhead_PressgifGWT, global::GWT.Properties.Resources.Dumbbell_4_Ways_Lateral_RaisegifGWT, global::GWT.Properties.Resources.Seated_Behind_the_Neck_PressgifGWT, global::GWT.Properties.Resources.ArnoldPressgifGWT, global::GWT.Properties.Resources.Bent_Over_Lateral_RaisegifGWT };

    }

    public class ChestExer
    {
        public string[] ChestName = { "Incline Chest Fly Machine", "Bench Press", "Pec Deck Fly", "Dumbbell Pullover", "Low Cable Crossover", "High Cable Crossover", "Cable Upper Chest Crossover", "Incline Barbell Bench Press", "Dumbbell Fly", "Dumbbell Press", "Incline Dumbbell Fly", "Machine Fly" };
        public string[] ChestReps = { "12", "10", "10", "8", "8", "8", "8", "12", "10", "12", "10", "10" };
        public Image[] ChestImgs = { global::GWT.Properties.Resources.Incline_Chest_Fly_MachineimgGWT, global::GWT.Properties.Resources.Barbell_Bench_PressimgGWT, global::GWT.Properties.Resources.Pec_Deck_FlyimgGWT, global::GWT.Properties.Resources.Dumbbell_PulloverimgGWT, global::GWT.Properties.Resources.Low_Cable_CrossoverimgGWT, global::GWT.Properties.Resources.High_Cable_CrossoverimgGWT,
        global::GWT.Properties.Resources.Cable_Upper_Chest_CrossoversimgGWT, global::GWT.Properties.Resources.Incline_Barbell_Bench_PressimgGWT, global::GWT.Properties.Resources.Dumbbell_FlyimgGWT, global::GWT.Properties.Resources.Dumbbell_PressimgGWT, global::GWT.Properties.Resources.Incline_dumbbell_FlyimgGWT, global::GWT.Properties.Resources.Machine_FlyimgGWT };
        public Image[] ChestGifs = { global::GWT.Properties.Resources.Incline_Chest_Fly_MachinegifGWT, global::GWT.Properties.Resources.Barbell_Bench_PressgifGWT, global::GWT.Properties.Resources.Pec_Deck_FlygifGWT, global::GWT.Properties.Resources.Dumbbell_PullovergifGWT, global::GWT.Properties.Resources.Low_Cable_CrossovergifGWT, global::GWT.Properties.Resources.High_Cable_CrossovergifGWT,
        global::GWT.Properties.Resources.Cable_Upper_Chest_CrossoversgifGWT, global::GWT.Properties.Resources.Incline_Barbell_Bench_PressgifGWT, global::GWT.Properties.Resources.Dumbbell_FlygifGWT, global::GWT.Properties.Resources.Dumbbell_PressgifGWT, global::GWT.Properties.Resources.Incline_dumbbell_FlygifGWT, global::GWT.Properties.Resources.Machine_FlygifGWT };

    }

    public class AbsExer
    {
        public string[] AbsName = { "Medicine Ball Rotational Throw", "Dragon Flag", "Ab Coaster Machine", "Cross Crunch", "Standing Cable Crunch", "Seated Bench Leg Pull In", "Cross Body Mountain Climber", "Alternate Leg Raises", "Crunches", "Mountain Climber", "Bicycle Crunch", "Oblique Floor Crunches" };
        public string[] AbstReps = { "6", "5", "10", "20", "12", "12", "15", "26", "25", "20", "20", "15" };
        public Image[] AbsImgs = { global::GWT.Properties.Resources.Medicine_Ball_Rotational_ThrowimgGWT, global::GWT.Properties.Resources.Dragon_FlagimgGWT, global::GWT.Properties.Resources.Ab_Coaster_MachineimgGWT, global::GWT.Properties.Resources.Cross_CrunchimgGWT, global::GWT.Properties.Resources.Standing_Cable_CrunchimgGWT, global::GWT.Properties.Resources.Seated_Bench_Leg_Pull_inimgGWT,
        global::GWT.Properties.Resources.Cross_Body_Mountain_ClimberimgGWT, global::GWT.Properties.Resources.Alternate_Leg_RaisesimgGWT, global::GWT.Properties.Resources.CrunchimgGWT, global::GWT.Properties.Resources.Mountain_climberimgGWT, global::GWT.Properties.Resources.Bicycle_CrunchimgGWT, global::GWT.Properties.Resources.Oblique_Floor_CrunchesimgGWT };
        public Image[] AbsGifs = { global::GWT.Properties.Resources.Medicine_Ball_Rotational_ThrowgifGWT, global::GWT.Properties.Resources.Dragon_FlaggifGWT, global::GWT.Properties.Resources.Ab_Coaster_MachinegifGWT, global::GWT.Properties.Resources.Cross_CrunchgifGWT, global::GWT.Properties.Resources.Standing_Cable_CrunchgifGWT, global::GWT.Properties.Resources.Seated_Bench_Leg_Pull_ingifGWT,
        global::GWT.Properties.Resources.Cross_Body_Mountain_ClimbergifGWT, global::GWT.Properties.Resources.Alternate_Leg_RaisesgifGWT, global::GWT.Properties.Resources.CrunchgifGWT, global::GWT.Properties.Resources.Mountain_climbergifGWT, global::GWT.Properties.Resources.Bicycle_CrunchgifGWT, global::GWT.Properties.Resources.Oblique_Floor_CrunchesgifGWT };

    }

    public class LegExer
    {
        public string[] LegName = { "Dumbbell Goblet Squat", "Curtsy Lunge", "Standing Leg Circles", "Static Lunge", "Dumbbell Walking Lunge", "Dumbbell Squat", "Dumbbell Deadlift", "Dumbbell Sumo Deadlift", "Barbell Squat", "Leg Press", "Deadlift", "Leg Curl" };
        public string[] LegReps = { "10", "8", "8", "12", "12", "12", "8", "6", "10", "12", "6", "20" };
        public Image[] LegImgs = { global::GWT.Properties.Resources.Dumbbell_Goblet_SquatimgGWT, global::GWT.Properties.Resources.curtsy_lungeimgGWT, global::GWT.Properties.Resources.Standing_Leg_CirclesimgGWT, global::GWT.Properties.Resources.Static_LungeimgGWT, global::GWT.Properties.Resources.dumbbell_lungesimgGWT, global::GWT.Properties.Resources.Dumbbell_SquatimgGWT,
        global::GWT.Properties.Resources.dumbbell_deadliftsimgGWT, global::GWT.Properties.Resources.dumbbell_sumo_deadliftimgGWT, global::GWT.Properties.Resources.BARBELL_SQUATimgGWT, global::GWT.Properties.Resources.Leg_PressimgGWT, global::GWT.Properties.Resources.deadliftimgGWT, global::GWT.Properties.Resources.Leg_CurlimgGWT };
        public Image[] LegGifs = { global::GWT.Properties.Resources.Dumbbell_Goblet_SquatgifGWT, global::GWT.Properties.Resources.curtsy_lungegifGWT, global::GWT.Properties.Resources.Standing_Leg_CirclesgifGWT, global::GWT.Properties.Resources.Static_LungegifGWT, global::GWT.Properties.Resources.dumbbell_deadliftsimgGWT, global::GWT.Properties.Resources.Dumbbell_SquatgifGWT,
        global::GWT.Properties.Resources.dumbbell_deadliftsgifGWT, global::GWT.Properties.Resources.dumbbell_sumo_deadliftgifGWT, global::GWT.Properties.Resources.BARBELL_SQUATgifGWT, global::GWT.Properties.Resources.Leg_PressgifGWT, global::GWT.Properties.Resources.deadliftgifGWT, global::GWT.Properties.Resources.Leg_PressgifGWT };

    }

    public class ArmExer
    {
        public string[] ArmName = { "Medicine Ball Overhead Throw", "One Arm Triceps Pushdown", "Dumbbell KickBack", "One Arm Reverse Pushdown", "Pushdown", "Bench Dips", "Triceps Dips", "Cable Rope Overhead Triceps Extension", "Lever Triceps Dip", "Triceps Dips On Floor", "Wall Push Up", "Seated Dumbbell Triceps Extension" };
        public string[] ArmReps = { "6", "10", "12", "10", "15", "10", "12", "12", "10", "10", "50", "12" };
        public Image[] ArmImgs = { global::GWT.Properties.Resources.Medicine_Ball_Overhead_ThrowimgGWT, global::GWT.Properties.Resources.One_arm_triceps_pushdownimgGWT, global::GWT.Properties.Resources.Dumbbell_KickbackimgGWT, global::GWT.Properties.Resources.One_Arm_Reverse_Push_DownimgGWT, global::GWT.Properties.Resources.PushdownimgGWT, global::GWT.Properties.Resources.Bench_DipsimgGWT,
        global::GWT.Properties.Resources.Triceps_DipsimgGWT, global::GWT.Properties.Resources.Cable_Rope_Overhead_Triceps_ExtensionimgGWT, global::GWT.Properties.Resources.Lever_Overhand_Triceps_DipimgGWT, global::GWT.Properties.Resources.Triceps_dips_on_floorsimgGWT, global::GWT.Properties.Resources.Wall_Push_upsimgGWT, global::GWT.Properties.Resources.Seated_Dumbbell_Triceps_ExtensionimgGWT };
        public Image[] ArmGifs = { global::GWT.Properties.Resources.Medicine_Ball_Overhead_ThrowgifGWT, global::GWT.Properties.Resources.One_arm_triceps_pushdowngifGWT, global::GWT.Properties.Resources.Dumbbell_KickbackgifGWT, global::GWT.Properties.Resources.One_Arm_Reverse_Push_DowngifGWT, global::GWT.Properties.Resources.PushdowngifGWT, global::GWT.Properties.Resources.Bench_DipsgifGWT,
        global::GWT.Properties.Resources.Triceps_DipsgifGWT, global::GWT.Properties.Resources.Cable_Rope_Overhead_Triceps_ExtensiongifGWT, global::GWT.Properties.Resources.Lever_Overhand_Triceps_DipgifGWT, global::GWT.Properties.Resources.Triceps_dips_on_floorsgifGWT, global::GWT.Properties.Resources.Wall_Push_upsgifGWT, global::GWT.Properties.Resources.Seated_Dumbbell_Triceps_ExtensiongifGWT };

    }

    public class ButtExer
    {
        public string[] ButtName = { "Barbell Lateral Lunge", "Standing Hip Abduction", "Kettlebell Single Leg Deadlift", "Side Lying Clam", "Reverse Lunge Knee Lift", "Curtsy Squat", "Jump Squat", "Standing Hip Extension", "Bodyweight Hip Thrust", "Wall Sit", "KettleBell Swing", "Bodyweight Single Leg Deadlift" };
        public string[] ButtReps = { "10", "12", "12", "10", "10", "8", "12", "8", "20", "00:30 secs", "6", "8" };
        public Image[] ButtImgs = { global::GWT.Properties.Resources.Barbell_Lateral_LungeimgGWT, global::GWT.Properties.Resources.Standing_Hip_Abduction_1imgGWT, global::GWT.Properties.Resources.Kettlebell_Single_Leg_DeadliftimgGWT, global::GWT.Properties.Resources.Side_Lying_ClamimgGWT, global::GWT.Properties.Resources.Reverse_Lunge_KneeimgGWT, global::GWT.Properties.Resources.Curtsey_SquatimgGWT,
        global::GWT.Properties.Resources.Jump_SquatimgGWT, global::GWT.Properties.Resources.Standing_Hip_ExtensionimgGWT, global::GWT.Properties.Resources.bodyweight_hip_thrustimgGWT, global::GWT.Properties.Resources.Wall_SitimgGWT, global::GWT.Properties.Resources.Kettlebell_SwingsimgGWT, global::GWT.Properties.Resources.Bodyweight_Single_Leg_DeadliftimgGWT };
        public Image[] ButtGifs = { global::GWT.Properties.Resources.Barbell_Lateral_LungegifGWT, global::GWT.Properties.Resources.Standing_Hip_Abduction_1gifGWT, global::GWT.Properties.Resources.Kettlebell_Single_Leg_DeadliftgifGWT, global::GWT.Properties.Resources.Side_Lying_ClamgifGWT, global::GWT.Properties.Resources.Reverse_Lunge_KneegifGWT, global::GWT.Properties.Resources.Curtsey_SquatgifGWT,
        global::GWT.Properties.Resources.Jump_SquatgifGWT, global::GWT.Properties.Resources.Standing_Hip_ExtensiongifGWT, global::GWT.Properties.Resources.bodyweight_hip_thrustgifGWT, global::GWT.Properties.Resources.Wall_SitimgGWT, global::GWT.Properties.Resources.Kettlebell_SwingsgifGWT, global::GWT.Properties.Resources.Bodyweight_Single_Leg_DeadliftgifGWT };

    }
}