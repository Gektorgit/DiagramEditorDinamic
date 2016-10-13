namespace Lesson_2_DiagramEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelForWhom = new System.Windows.Forms.Label();
            this.labelHowMany = new System.Windows.Forms.Label();
            this.textBox_ForWhom = new System.Windows.Forms.TextBox();
            this.textBox_HowMany = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.textBox_HowManyCandidates = new System.Windows.Forms.TextBox();
            this.label_HowManyCandidates = new System.Windows.Forms.Label();
            this.button_FullReset = new System.Windows.Forms.Button();
            this.button_SavePopulation = new System.Windows.Forms.Button();
            this.textBox_Population = new System.Windows.Forms.TextBox();
            this.label_Eopulation = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.listBox_List = new System.Windows.Forms.ListBox();
            this.groupBox_Graphs = new System.Windows.Forms.GroupBox();
            this.pictureBox_Diagramm = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_Graphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Diagramm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForWhom
            // 
            resources.ApplyResources(this.labelForWhom, "labelForWhom");
            this.labelForWhom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelForWhom.Name = "labelForWhom";
            // 
            // labelHowMany
            // 
            resources.ApplyResources(this.labelHowMany, "labelHowMany");
            this.labelHowMany.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelHowMany.Name = "labelHowMany";
            // 
            // textBox_ForWhom
            // 
            this.textBox_ForWhom.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.textBox_ForWhom, "textBox_ForWhom");
            this.textBox_ForWhom.Name = "textBox_ForWhom";
            this.textBox_ForWhom.TextChanged += new System.EventHandler(this.textBox_ForWhom_TextChanged);
            this.textBox_ForWhom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ForWhom_KeyPress);
            // 
            // textBox_HowMany
            // 
            this.textBox_HowMany.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.textBox_HowMany, "textBox_HowMany");
            this.textBox_HowMany.Name = "textBox_HowMany";
            this.textBox_HowMany.TextChanged += new System.EventHandler(this.textBox_HowMany_TextChanged);
            this.textBox_HowMany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HowMany_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Edit);
            this.groupBox1.Controls.Add(this.textBox_HowManyCandidates);
            this.groupBox1.Controls.Add(this.label_HowManyCandidates);
            this.groupBox1.Controls.Add(this.button_FullReset);
            this.groupBox1.Controls.Add(this.button_SavePopulation);
            this.groupBox1.Controls.Add(this.textBox_Population);
            this.groupBox1.Controls.Add(this.label_Eopulation);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Controls.Add(this.button_Draw);
            this.groupBox1.Controls.Add(this.listBox_List);
            this.groupBox1.Controls.Add(this.labelForWhom);
            this.groupBox1.Controls.Add(this.textBox_HowMany);
            this.groupBox1.Controls.Add(this.labelHowMany);
            this.groupBox1.Controls.Add(this.textBox_ForWhom);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.button_Edit, "button_Edit");
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBox_HowManyCandidates
            // 
            this.textBox_HowManyCandidates.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.textBox_HowManyCandidates, "textBox_HowManyCandidates");
            this.textBox_HowManyCandidates.Name = "textBox_HowManyCandidates";
            this.textBox_HowManyCandidates.TextChanged += new System.EventHandler(this.textBox_HowManyCandidates_TextChanged);
            this.textBox_HowManyCandidates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HowManyCandidates_KeyPress);
            // 
            // label_HowManyCandidates
            // 
            resources.ApplyResources(this.label_HowManyCandidates, "label_HowManyCandidates");
            this.label_HowManyCandidates.Name = "label_HowManyCandidates";
            // 
            // button_FullReset
            // 
            resources.ApplyResources(this.button_FullReset, "button_FullReset");
            this.button_FullReset.ForeColor = System.Drawing.Color.DarkRed;
            this.button_FullReset.Name = "button_FullReset";
            this.button_FullReset.UseVisualStyleBackColor = true;
            this.button_FullReset.Click += new System.EventHandler(this.button_FullReset_Click);
            // 
            // button_SavePopulation
            // 
            resources.ApplyResources(this.button_SavePopulation, "button_SavePopulation");
            this.button_SavePopulation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_SavePopulation.Name = "button_SavePopulation";
            this.button_SavePopulation.UseVisualStyleBackColor = true;
            this.button_SavePopulation.Click += new System.EventHandler(this.button_SavePopulation_Click);
            // 
            // textBox_Population
            // 
            this.textBox_Population.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.textBox_Population, "textBox_Population");
            this.textBox_Population.Name = "textBox_Population";
            this.textBox_Population.TextChanged += new System.EventHandler(this.textBox_Population_TextChanged);
            this.textBox_Population.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label_Eopulation
            // 
            resources.ApplyResources(this.label_Eopulation, "label_Eopulation");
            this.label_Eopulation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_Eopulation.Name = "label_Eopulation";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.button_Add, "button_Add");
            this.button_Add.Name = "button_Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.button_Reset, "button_Reset");
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.button_Draw, "button_Draw");
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.UseVisualStyleBackColor = false;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // listBox_List
            // 
            this.listBox_List.BackColor = System.Drawing.Color.Azure;
            this.listBox_List.FormattingEnabled = true;
            resources.ApplyResources(this.listBox_List, "listBox_List");
            this.listBox_List.Name = "listBox_List";
            this.listBox_List.DoubleClick += new System.EventHandler(this.listBox_List_DoubleClick);
            this.listBox_List.Enter += new System.EventHandler(this.listBox_List_Enter);
            // 
            // groupBox_Graphs
            // 
            this.groupBox_Graphs.Controls.Add(this.pictureBox_Diagramm);
            resources.ApplyResources(this.groupBox_Graphs, "groupBox_Graphs");
            this.groupBox_Graphs.Name = "groupBox_Graphs";
            this.groupBox_Graphs.TabStop = false;
            // 
            // pictureBox_Diagramm
            // 
            this.pictureBox_Diagramm.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.pictureBox_Diagramm, "pictureBox_Diagramm");
            this.pictureBox_Diagramm.Name = "pictureBox_Diagramm";
            this.pictureBox_Diagramm.TabStop = false;
            this.pictureBox_Diagramm.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Diagramm_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox_Graphs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Graphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Diagramm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelForWhom;
        private System.Windows.Forms.Label labelHowMany;
        private System.Windows.Forms.TextBox textBox_ForWhom;
        private System.Windows.Forms.TextBox textBox_HowMany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.ListBox listBox_List;
        private System.Windows.Forms.GroupBox groupBox_Graphs;
        private System.Windows.Forms.PictureBox pictureBox_Diagramm;
        private System.Windows.Forms.Label label_Eopulation;
        private System.Windows.Forms.TextBox textBox_Population;
        private System.Windows.Forms.Button button_SavePopulation;
        private System.Windows.Forms.Button button_FullReset;
        private System.Windows.Forms.TextBox textBox_HowManyCandidates;
        private System.Windows.Forms.Label label_HowManyCandidates;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Edit;
    }
}

