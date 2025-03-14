namespace Younes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelMenu = new Panel();
            btnLogout = new Button();
            btnTeam = new Button();
            btnTasks = new Button();
            btnProjects = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            panelMembreEquipe = new Panel();
            label4 = new Label();
            textBox4 = new TextBox();
            panelChefEquipe = new Panel();
            label3 = new Label();
            textBox3 = new TextBox();
            panel6 = new Panel();
            panelChefProjet = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            panelAdmin = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panelMembreEquipe.SuspendLayout();
            panelChefEquipe.SuspendLayout();
            panelChefProjet.SuspendLayout();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 449);
            panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnTeam);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnProjects);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 449);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(0, 200);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 43);
            btnLogout.TabIndex = 4;
            btnLogout.Text = " Déconnexion";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button5_Click;
            // 
            // btnTeam
            // 
            btnTeam.Location = new Point(0, 146);
            btnTeam.Margin = new Padding(2, 2, 2, 2);
            btnTeam.Name = "btnTeam";
            btnTeam.Size = new Size(150, 43);
            btnTeam.TabIndex = 3;
            btnTeam.Text = "Équipe";
            btnTeam.UseVisualStyleBackColor = true;
            btnTeam.Click += button4_Click;
            // 
            // btnTasks
            // 
            btnTasks.Location = new Point(0, 92);
            btnTasks.Margin = new Padding(2, 2, 2, 2);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(150, 44);
            btnTasks.TabIndex = 2;
            btnTasks.Text = " Tâches";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += button3_Click;
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(0, 44);
            btnProjects.Margin = new Padding(2, 2, 2, 2);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(148, 45);
            btnProjects.TabIndex = 1;
            btnProjects.Text = " Projets";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(2, 2, 2, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Tableau de Bord";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(149, 4);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 452);
            panel2.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(checkedListBox1);
            panelMain.Controls.Add(panelMembreEquipe);
            panelMain.Controls.Add(panelChefEquipe);
            panelMain.Controls.Add(panelChefProjet);
            panelMain.Controls.Add(panelAdmin);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(150, 0);
            panelMain.Margin = new Padding(2, 2, 2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(568, 449);
            panelMain.TabIndex = 1;
            // 
            // panelMembreEquipe
            // 
            panelMembreEquipe.Controls.Add(label4);
            panelMembreEquipe.Controls.Add(textBox4);
            panelMembreEquipe.Location = new Point(428, 16);
            panelMembreEquipe.Margin = new Padding(2, 2, 2, 2);
            panelMembreEquipe.Name = "panelMembreEquipe";
            panelMembreEquipe.Size = new Size(114, 92);
            panelMembreEquipe.TabIndex = 3;
            panelMembreEquipe.Visible = false;
            panelMembreEquipe.Paint += panelMembreEquipe_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 1;
            label4.Text = "Membre d’Équipe";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 55);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 31);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // panelChefEquipe
            // 
            panelChefEquipe.Controls.Add(label3);
            panelChefEquipe.Controls.Add(textBox3);
            panelChefEquipe.Controls.Add(panel6);
            panelChefEquipe.Location = new Point(295, 17);
            panelChefEquipe.Margin = new Padding(2, 2, 2, 2);
            panelChefEquipe.Name = "panelChefEquipe";
            panelChefEquipe.Size = new Size(112, 92);
            panelChefEquipe.TabIndex = 2;
            panelChefEquipe.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Chef d’Équipe";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 55);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 31);
            textBox3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Location = new Point(133, 0);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(167, 156);
            panel6.TabIndex = 0;
            // 
            // panelChefProjet
            // 
            panelChefProjet.Controls.Add(label2);
            panelChefProjet.Controls.Add(textBox2);
            panelChefProjet.Location = new Point(140, 17);
            panelChefProjet.Margin = new Padding(2, 2, 2, 2);
            panelChefProjet.Name = "panelChefProjet";
            panelChefProjet.Size = new Size(118, 92);
            panelChefProjet.TabIndex = 1;
            panelChefProjet.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Chef de Projet";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 55);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 31);
            textBox2.TabIndex = 0;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(label1);
            panelAdmin.Controls.Add(textBox1);
            panelAdmin.Location = new Point(12, 17);
            panelAdmin.Margin = new Padding(2, 2, 2, 2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(110, 92);
            panelAdmin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "Administrateur";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 55);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 31);
            textBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(355, 127);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 449);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMembreEquipe.ResumeLayout(false);
            panelMembreEquipe.PerformLayout();
            panelChefEquipe.ResumeLayout(false);
            panelChefEquipe.PerformLayout();
            panelChefProjet.ResumeLayout(false);
            panelChefProjet.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMenu;
        private Panel panel2;
        private Panel panelMain;
        private Button btnLogout;
        private Button btnTeam;
        private Button btnTasks;
        private Button btnProjects;
        private Button btnDashboard;
        private Panel panelMembreEquipe;
        private TextBox textBox4;
        private Panel panelChefEquipe;
        private TextBox textBox3;
        private Panel panel6;
        private Panel panelChefProjet;
        private TextBox textBox2;
        private Panel panelAdmin;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}
