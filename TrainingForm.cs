using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private WorkingOutForm workForm = new WorkingOutForm();
        private WorkoutRoutine routineForm = new WorkoutRoutine();
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
        public Areas areasForm = new Areas();
        private BMI bmiForms = new BMI();

        public int workoutNameLbl;
        int x = 26;
        int y = 81;
        int width = 767;
        int height = 285;
        int addX = 325;

        public Random randNum = new Random();
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            Label TrainingLbl = new Label();
            TrainingLbl.AutoSize = true;
            TrainingLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TrainingLbl.ForeColor = System.Drawing.Color.White;
            TrainingLbl.Location = new System.Drawing.Point(18, 0);
            TrainingLbl.Name = "TrainingLbl";
            TrainingLbl.Size = new System.Drawing.Size(176, 45);
            TrainingLbl.TabIndex = 1;
            TrainingLbl.Text = "TRAINING";
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(TrainingLbl);
            
            if (isLoggedIn == false)
            {
                int setByGender = (gender == "Male") ? 4 : 3;
                Image absMuscleDiag = global::GWT.Properties.Resources.muscleAbsGWT;
                if (areasForm.back == true)
                {
                    setPanel("Back Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", absMuscleDiag, viewAll_LinkClicked);
                }
                
            } else
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string qry = "SELECT `username`, `gender`, `id` FROM `users` WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Username", user_name);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    gender = reader.GetString("gender");
                    int userId = reader.GetInt32("id");
                    MySqlConnection connect = new MySqlConnection(connstring);
                    connect.Open();
                    string query = "SELECT * FROM `areasfocused` WHERE userId = @userId";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.AddWithValue("@userId", userId);
                    MySqlDataReader reader2 = command.ExecuteReader();
                    if (reader2.Read())
                    {
                        int back = reader2.GetInt32("back");
                        int shoulder = reader2.GetInt32("shoulder");
                        int arm = reader2.GetInt32("arm");
                        int chest = reader2.GetInt32("chest");
                        int abs = reader2.GetInt32("abs");
                        int butt = reader2.GetInt32("butt");
                        int leg = reader2.GetInt32("leg");
                        int setByGender = (gender == "Male") ? 4 : 3;
                        
                        Image absMuscleDiag = global::GWT.Properties.Resources.muscleAbsGWT;
                        Image backMuscleDiag = global::GWT.Properties.Resources.muscleBackGWT;
                        Image chestMuscleDiag = global::GWT.Properties.Resources.muscleChestGWT;
                        Image armMuscleDiag = global::GWT.Properties.Resources.muscleArmGWT;
                        Image shoulderMuscleDiag = global::GWT.Properties.Resources.muscleShoulderGWT;
                        Image buttMuscleDiag = global::GWT.Properties.Resources.muscleButtGWT;
                        Image legMuscleDiag = global::GWT.Properties.Resources.muscleLegGWT;

                        if (back == 1)
                        {
                            setPanel("Back Workout", 6, backExercises.BackName[0], setByGender, backExercises.BackReps[0], backExercises.BackName[1], setByGender, backExercises.BackReps[1], backExercises.BackName[2], setByGender, backExercises.BackReps[2], backMuscleDiag, viewAll_LinkClicked);
                        }
                        if (shoulder == 1)
                        {
                            setPanel("Shoulder Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", shoulderMuscleDiag, viewAll2_LinkClicked);
                        }
                        if (arm == 1)
                        {
                            setPanel("Arm Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", armMuscleDiag, viewAll3_LinkClicked);
                        }
                        if (chest == 1)
                        {
                            setPanel("Chest Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", chestMuscleDiag, viewAll4_LinkClicked);
                        }
                        if (abs == 1)
                        {
                            setPanel("Abs Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", absMuscleDiag, viewAll5_LinkClicked);
                        }
                        if (butt == 1)
                        {
                            setPanel("Butt Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", buttMuscleDiag, viewAll6_LinkClicked);
                        }
                        if (leg == 1)
                        {
                            setPanel("Leg Workout", 6, "Reverse Crunch", setByGender, "8", "Bicycle Crunch", setByGender, "8", "Plank", setByGender, "00:30", legMuscleDiag, viewAll7_LinkClicked);
                        }

                    }
                }

            }
            
            backBtn.Location = new Point(20, 60);
            startBtn.Location = new Point(513, 440);
            regenBtn.Location = new Point(813, 457);
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
            int setByGender = (gender == "Male") ? 4 : 3;
            Control[] trainingPanels = { NavPanel, mainPanel };
            workForm.workoutLbl.Text = "Back Workout";
            workForm.MuscleDiagram.Image = global::GWT.Properties.Resources.muscleBackGWT;
            workForm.exercisePanel.Controls.Clear();
            int panelY = 18;
            int panelGaps = 79;
            workOutSet(backExercises.BackImgs[0], backExercises.BackName[0], setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[1], backExercises.BackName[1], setByGender, backExercises.BackReps[1], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[2], backExercises.BackName[2], setByGender, backExercises.BackReps[2], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[3], backExercises.BackName[3], setByGender, backExercises.BackReps[3], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[4], backExercises.BackName[4], setByGender, backExercises.BackReps[4], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[5], backExercises.BackName[5], setByGender, backExercises.BackReps[5], panelY);

            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);

            backBtn.Visible = true;
            startBtn.Visible = true;
            regenBtn.Visible = true;
        }
        private void viewAll2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int setByGender = (gender == "Male") ? 4 : 3;
            Control[] trainingPanels = { NavPanel, mainPanel };
            workForm.workoutLbl.Text = "Shoulder Workout";
            workForm.MuscleDiagram.Image = global::GWT.Properties.Resources.muscleAbsGWT;
            workForm.exercisePanel.Controls.Clear();
            int panelY = 18;
            
            int panelGaps = 79;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            panelY += panelGaps;
            workOutSet(global::GWT.Properties.Resources.ReverseCrunchGwt, "Reverse Crunch", setByGender, backExercises.BackReps[0], panelY);
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);

            backBtn.Visible = true;
        }
        private void viewAll3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] trainingPanels = { NavPanel, mainPanel };
            workForm.workoutLbl.Text = "Arm Workout";
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);
            backBtn.Visible = true;
        }
        private void viewAll4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] trainingPanels = { NavPanel, mainPanel };
            workForm.workoutLbl.Text = "Chest Workout";
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);
            backBtn.Visible = true;
        }
        private void viewAll5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            workForm.workoutLbl.Text = "Abs Workout";
            Control[] trainingPanels = { NavPanel, mainPanel };
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);
            backBtn.Visible = true;
        }
        private void viewAll6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            workForm.workoutLbl.Text = "Butt Workout";
            Control[] trainingPanels = { NavPanel, mainPanel };
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);
            backBtn.Visible = true;
        }
        private void viewAll7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            workForm.workoutLbl.Text = "Leg Workout";
            Control[] trainingPanels = { NavPanel, mainPanel };
            foreach (Control cont in trainingPanels)
            {
                ContentsPanel.Controls.Remove(cont);
            }
            ContentsPanel.Controls.Add(workForm.WorkMainPanel);
            backBtn.Visible = true;
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
            int[] indexes = RandomIndexer(0, 11, 6);
            
            workForm.exercisePanel.Controls.Clear();
            int setByGender = (gender == "Male") ? 4 : 3;
            int panelY = 18;
            int panelGaps = 79;
            workOutSet(backExercises.BackImgs[indexes[0]], backExercises.BackName[indexes[0]], setByGender, backExercises.BackReps[indexes[0]], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[indexes[1]], backExercises.BackName[indexes[1]], setByGender, backExercises.BackReps[indexes[1]], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[indexes[2]], backExercises.BackName[indexes[2]], setByGender, backExercises.BackReps[indexes[2]], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[indexes[3]], backExercises.BackName[indexes[3]], setByGender, backExercises.BackReps[indexes[3]], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[indexes[4]], backExercises.BackName[indexes[4]], setByGender, backExercises.BackReps[indexes[4]], panelY);
            panelY += panelGaps;
            workOutSet(backExercises.BackImgs[indexes[5]], backExercises.BackName[indexes[5]], setByGender, backExercises.BackReps[indexes[5]], panelY);
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
            this.Hide();

        }
    }

    public class BackExer
    {
        public string[] BackName = { "Pull Ups", "Bent Over Rows", "Dead Hang", "Lat Pull Downs", "Seated Cable Rows", "One Arm Dumbbell Row",
            "Deadlift", "Alternating Renegade Row", "Farmers Walk", "Band Lat Pull Down", "Chest Supported Rows", "Barbell Dead Row" };
        public string[] BackReps = { "6", "12", "00:20 secs", "8", "12", "12", "4-8", "8-12", "00:30 secs", "12", "8", "12" };      
        public Image[] BackImgs = { global::GWT.Properties.Resources.PullUpsimgGWT, global::GWT.Properties.Resources.BentOverRowsimgGWT, global::GWT.Properties.Resources.deadHangimgGWT, global::GWT.Properties.Resources.latPullDownimgGWT, global::GWT.Properties.Resources.seatedCableRowsimgGWT, global::GWT.Properties.Resources.oneArmDumbbellRowimgGWT,
        global::GWT.Properties.Resources.deadliftimgGWT, global::GWT.Properties.Resources.renegadeRowsimgGWT, global::GWT.Properties.Resources.farmersWalkimgGWT, global::GWT.Properties.Resources.bandLatPulldownimgGWT, global::GWT.Properties.Resources.chestBellRowimgGWT, global::GWT.Properties.Resources.barbellRowimgGWT };
    }

}
