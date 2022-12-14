namespace EzraReinforcementExp
{
    partial class FrmQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            this.LblQuestion = new System.Windows.Forms.Label();
            this.LblReinforcement = new System.Windows.Forms.Label();
            this.TbResponse = new System.Windows.Forms.TextBox();
            this.Lblcorrectanswer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PbCheck = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.Location = new System.Drawing.Point(28, 54);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(1165, 72);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "label1";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblReinforcement
            // 
            this.LblReinforcement.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblReinforcement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblReinforcement.Location = new System.Drawing.Point(79, 301);
            this.LblReinforcement.Name = "LblReinforcement";
            this.LblReinforcement.Size = new System.Drawing.Size(1101, 72);
            this.LblReinforcement.TabIndex = 1;
            this.LblReinforcement.Text = "label2";
            this.LblReinforcement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbResponse
            // 
            this.TbResponse.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbResponse.Location = new System.Drawing.Point(315, 162);
            this.TbResponse.Name = "TbResponse";
            this.TbResponse.Size = new System.Drawing.Size(628, 61);
            this.TbResponse.TabIndex = 2;
            this.TbResponse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbResponse_KeyPress);
            // 
            // Lblcorrectanswer
            // 
            this.Lblcorrectanswer.AutoSize = true;
            this.Lblcorrectanswer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lblcorrectanswer.Location = new System.Drawing.Point(557, 247);
            this.Lblcorrectanswer.Name = "Lblcorrectanswer";
            this.Lblcorrectanswer.Size = new System.Drawing.Size(130, 54);
            this.Lblcorrectanswer.TabIndex = 3;
            this.Lblcorrectanswer.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PbCheck
            // 
            this.PbCheck.Image = ((System.Drawing.Image)(resources.GetObject("PbCheck.Image")));
            this.PbCheck.Location = new System.Drawing.Point(252, 162);
            this.PbCheck.Name = "PbCheck";
            this.PbCheck.Size = new System.Drawing.Size(57, 61);
            this.PbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCheck.TabIndex = 4;
            this.PbCheck.TabStop = false;
            // 
            // pbX
            // 
            this.pbX.Image = global::EzraReinforcementExp.Properties.Resources.OIP;
            this.pbX.Location = new System.Drawing.Point(252, 162);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(57, 61);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbX.TabIndex = 4;
            this.pbX.TabStop = false;
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 405);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.PbCheck);
            this.Controls.Add(this.Lblcorrectanswer);
            this.Controls.Add(this.TbResponse);
            this.Controls.Add(this.LblReinforcement);
            this.Controls.Add(this.LblQuestion);
            this.Name = "FrmQuiz";
            this.Text = "Quizaroo";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblQuestion;
        private Label LblReinforcement;
        private TextBox TbResponse;
        private Label Lblcorrectanswer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox PbCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbX;
    }
}