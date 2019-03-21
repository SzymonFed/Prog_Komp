namespace Zad_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuotes = new System.Windows.Forms.Button();
            this.txtQuotesInput = new System.Windows.Forms.TextBox();
            this.txtQuotesOutput = new System.Windows.Forms.TextBox();
            this.txtResolveOutput = new System.Windows.Forms.TextBox();
            this.txtResolveInput = new System.Windows.Forms.TextBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnEcho = new System.Windows.Forms.Button();
            this.txtEchoInput = new System.Windows.Forms.TextBox();
            this.txtEchoOutput = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.txtTimeOutput = new System.Windows.Forms.TextBox();
            this.btnPublic = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.txtPublicInputZamawiajacy = new System.Windows.Forms.TextBox();
            this.txtWeatherInput = new System.Windows.Forms.TextBox();
            this.txtPublicOutput = new System.Windows.Forms.TextBox();
            this.txtWeatherOutput = new System.Windows.Forms.TextBox();
            this.txtPublicInputWojewodztwo = new System.Windows.Forms.TextBox();
            this.txtPublicInputZamowienie = new System.Windows.Forms.TextBox();
            this.txtQuotesWatch = new System.Windows.Forms.TextBox();
            this.txtResolveWatch = new System.Windows.Forms.TextBox();
            this.txtEchoWatch = new System.Windows.Forms.TextBox();
            this.txtTimeWatch = new System.Windows.Forms.TextBox();
            this.txtPublicWatch = new System.Windows.Forms.TextBox();
            this.txtWeatherWatch = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAsynchronous = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAsynchronousWatch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuotes
            // 
            this.btnQuotes.Location = new System.Drawing.Point(112, 16);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(75, 23);
            this.btnQuotes.TabIndex = 0;
            this.btnQuotes.Text = "Quotes";
            this.btnQuotes.UseVisualStyleBackColor = true;
            this.btnQuotes.Click += new System.EventHandler(this.btnQuotes_Click);
            // 
            // txtQuotesInput
            // 
            this.txtQuotesInput.Location = new System.Drawing.Point(6, 16);
            this.txtQuotesInput.Name = "txtQuotesInput";
            this.txtQuotesInput.Size = new System.Drawing.Size(100, 20);
            this.txtQuotesInput.TabIndex = 1;
            // 
            // txtQuotesOutput
            // 
            this.txtQuotesOutput.Location = new System.Drawing.Point(190, 19);
            this.txtQuotesOutput.Name = "txtQuotesOutput";
            this.txtQuotesOutput.Size = new System.Drawing.Size(100, 20);
            this.txtQuotesOutput.TabIndex = 1;
            // 
            // txtResolveOutput
            // 
            this.txtResolveOutput.Location = new System.Drawing.Point(190, 13);
            this.txtResolveOutput.Name = "txtResolveOutput";
            this.txtResolveOutput.Size = new System.Drawing.Size(100, 20);
            this.txtResolveOutput.TabIndex = 4;
            // 
            // txtResolveInput
            // 
            this.txtResolveInput.Location = new System.Drawing.Point(6, 16);
            this.txtResolveInput.Name = "txtResolveInput";
            this.txtResolveInput.Size = new System.Drawing.Size(100, 20);
            this.txtResolveInput.TabIndex = 3;
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(112, 13);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 2;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnEcho
            // 
            this.btnEcho.Location = new System.Drawing.Point(109, 14);
            this.btnEcho.Name = "btnEcho";
            this.btnEcho.Size = new System.Drawing.Size(75, 23);
            this.btnEcho.TabIndex = 2;
            this.btnEcho.Text = "Echo";
            this.btnEcho.UseVisualStyleBackColor = true;
            this.btnEcho.Click += new System.EventHandler(this.btnEcho_Click);
            // 
            // txtEchoInput
            // 
            this.txtEchoInput.Location = new System.Drawing.Point(6, 16);
            this.txtEchoInput.Name = "txtEchoInput";
            this.txtEchoInput.Size = new System.Drawing.Size(100, 20);
            this.txtEchoInput.TabIndex = 3;
            // 
            // txtEchoOutput
            // 
            this.txtEchoOutput.Location = new System.Drawing.Point(190, 17);
            this.txtEchoOutput.Name = "txtEchoOutput";
            this.txtEchoOutput.Size = new System.Drawing.Size(100, 20);
            this.txtEchoOutput.TabIndex = 4;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(112, 16);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtTimeOutput
            // 
            this.txtTimeOutput.Location = new System.Drawing.Point(190, 16);
            this.txtTimeOutput.Name = "txtTimeOutput";
            this.txtTimeOutput.Size = new System.Drawing.Size(100, 20);
            this.txtTimeOutput.TabIndex = 1;
            // 
            // btnPublic
            // 
            this.btnPublic.Location = new System.Drawing.Point(113, 45);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(75, 23);
            this.btnPublic.TabIndex = 2;
            this.btnPublic.Text = "Public Order";
            this.btnPublic.UseVisualStyleBackColor = true;
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(114, 19);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(75, 23);
            this.btnWeather.TabIndex = 2;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // txtPublicInputZamawiajacy
            // 
            this.txtPublicInputZamawiajacy.Location = new System.Drawing.Point(7, 19);
            this.txtPublicInputZamawiajacy.Name = "txtPublicInputZamawiajacy";
            this.txtPublicInputZamawiajacy.Size = new System.Drawing.Size(100, 20);
            this.txtPublicInputZamawiajacy.TabIndex = 3;
            // 
            // txtWeatherInput
            // 
            this.txtWeatherInput.Location = new System.Drawing.Point(8, 20);
            this.txtWeatherInput.Name = "txtWeatherInput";
            this.txtWeatherInput.Size = new System.Drawing.Size(100, 20);
            this.txtWeatherInput.TabIndex = 3;
            // 
            // txtPublicOutput
            // 
            this.txtPublicOutput.Location = new System.Drawing.Point(187, 19);
            this.txtPublicOutput.Name = "txtPublicOutput";
            this.txtPublicOutput.Size = new System.Drawing.Size(209, 20);
            this.txtPublicOutput.TabIndex = 4;
            // 
            // txtWeatherOutput
            // 
            this.txtWeatherOutput.Location = new System.Drawing.Point(195, 21);
            this.txtWeatherOutput.Name = "txtWeatherOutput";
            this.txtWeatherOutput.Size = new System.Drawing.Size(100, 20);
            this.txtWeatherOutput.TabIndex = 4;
            // 
            // txtPublicInputWojewodztwo
            // 
            this.txtPublicInputWojewodztwo.Location = new System.Drawing.Point(7, 71);
            this.txtPublicInputWojewodztwo.Name = "txtPublicInputWojewodztwo";
            this.txtPublicInputWojewodztwo.Size = new System.Drawing.Size(100, 20);
            this.txtPublicInputWojewodztwo.TabIndex = 5;
            // 
            // txtPublicInputZamowienie
            // 
            this.txtPublicInputZamowienie.Location = new System.Drawing.Point(7, 45);
            this.txtPublicInputZamowienie.Name = "txtPublicInputZamowienie";
            this.txtPublicInputZamowienie.Size = new System.Drawing.Size(100, 20);
            this.txtPublicInputZamowienie.TabIndex = 6;
            // 
            // txtQuotesWatch
            // 
            this.txtQuotesWatch.Location = new System.Drawing.Point(296, 19);
            this.txtQuotesWatch.Name = "txtQuotesWatch";
            this.txtQuotesWatch.Size = new System.Drawing.Size(100, 20);
            this.txtQuotesWatch.TabIndex = 22;
            // 
            // txtResolveWatch
            // 
            this.txtResolveWatch.Location = new System.Drawing.Point(296, 13);
            this.txtResolveWatch.Name = "txtResolveWatch";
            this.txtResolveWatch.Size = new System.Drawing.Size(100, 20);
            this.txtResolveWatch.TabIndex = 22;
            // 
            // txtEchoWatch
            // 
            this.txtEchoWatch.Location = new System.Drawing.Point(296, 17);
            this.txtEchoWatch.Name = "txtEchoWatch";
            this.txtEchoWatch.Size = new System.Drawing.Size(100, 20);
            this.txtEchoWatch.TabIndex = 22;
            // 
            // txtTimeWatch
            // 
            this.txtTimeWatch.Location = new System.Drawing.Point(296, 16);
            this.txtTimeWatch.Name = "txtTimeWatch";
            this.txtTimeWatch.Size = new System.Drawing.Size(100, 20);
            this.txtTimeWatch.TabIndex = 22;
            // 
            // txtPublicWatch
            // 
            this.txtPublicWatch.Location = new System.Drawing.Point(299, 74);
            this.txtPublicWatch.Name = "txtPublicWatch";
            this.txtPublicWatch.Size = new System.Drawing.Size(100, 20);
            this.txtPublicWatch.TabIndex = 22;
            // 
            // txtWeatherWatch
            // 
            this.txtWeatherWatch.Location = new System.Drawing.Point(114, 65);
            this.txtWeatherWatch.Name = "txtWeatherWatch";
            this.txtWeatherWatch.Size = new System.Drawing.Size(100, 20);
            this.txtWeatherWatch.TabIndex = 22;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(917, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Wszystko";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuotes);
            this.groupBox1.Controls.Add(this.txtQuotesInput);
            this.groupBox1.Controls.Add(this.txtQuotesOutput);
            this.groupBox1.Controls.Add(this.txtQuotesWatch);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 45);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quotes Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEchoOutput);
            this.groupBox2.Controls.Add(this.btnEcho);
            this.groupBox2.Controls.Add(this.txtEchoInput);
            this.groupBox2.Controls.Add(this.txtEchoWatch);
            this.groupBox2.Location = new System.Drawing.Point(10, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 45);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Echo Service";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTime);
            this.groupBox3.Controls.Add(this.txtTimeOutput);
            this.groupBox3.Controls.Add(this.txtTimeWatch);
            this.groupBox3.Location = new System.Drawing.Point(10, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 45);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Service";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnResolve);
            this.groupBox4.Controls.Add(this.txtResolveInput);
            this.groupBox4.Controls.Add(this.txtResolveOutput);
            this.groupBox4.Controls.Add(this.txtResolveWatch);
            this.groupBox4.Location = new System.Drawing.Point(10, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 45);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resolve Service";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPublicInputZamawiajacy);
            this.groupBox5.Controls.Add(this.txtPublicInputZamowienie);
            this.groupBox5.Controls.Add(this.txtPublicInputWojewodztwo);
            this.groupBox5.Controls.Add(this.btnPublic);
            this.groupBox5.Controls.Add(this.txtPublicOutput);
            this.groupBox5.Controls.Add(this.txtPublicWatch);
            this.groupBox5.Location = new System.Drawing.Point(10, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(405, 100);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Public Order Service";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnWeather);
            this.groupBox6.Controls.Add(this.txtWeatherInput);
            this.groupBox6.Controls.Add(this.txtWeatherOutput);
            this.groupBox6.Controls.Add(this.txtWeatherWatch);
            this.groupBox6.Location = new System.Drawing.Point(433, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(392, 91);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Weather Service";
            // 
            // btnAsynchronous
            // 
            this.btnAsynchronous.Location = new System.Drawing.Point(6, 19);
            this.btnAsynchronous.Name = "btnAsynchronous";
            this.btnAsynchronous.Size = new System.Drawing.Size(75, 23);
            this.btnAsynchronous.TabIndex = 29;
            this.btnAsynchronous.Text = "Activate!";
            this.btnAsynchronous.UseVisualStyleBackColor = true;
            this.btnAsynchronous.Click += new System.EventHandler(this.btnAsynchronous_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtAsynchronousWatch);
            this.groupBox7.Controls.Add(this.btnAsynchronous);
            this.groupBox7.Location = new System.Drawing.Point(688, 252);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Asynchronous Something";
            // 
            // txtAsynchronousWatch
            // 
            this.txtAsynchronousWatch.Location = new System.Drawing.Point(6, 48);
            this.txtAsynchronousWatch.Name = "txtAsynchronousWatch";
            this.txtAsynchronousWatch.Size = new System.Drawing.Size(100, 20);
            this.txtAsynchronousWatch.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.TextBox txtQuotesInput;
        private System.Windows.Forms.TextBox txtQuotesOutput;
        private System.Windows.Forms.TextBox txtResolveOutput;
        private System.Windows.Forms.TextBox txtResolveInput;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnEcho;
        private System.Windows.Forms.TextBox txtEchoInput;
        private System.Windows.Forms.TextBox txtEchoOutput;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox txtTimeOutput;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.TextBox txtPublicInputZamawiajacy;
        private System.Windows.Forms.TextBox txtWeatherInput;
        private System.Windows.Forms.TextBox txtPublicOutput;
        private System.Windows.Forms.TextBox txtWeatherOutput;
        private System.Windows.Forms.TextBox txtPublicInputWojewodztwo;
        private System.Windows.Forms.TextBox txtPublicInputZamowienie;
        private System.Windows.Forms.TextBox txtQuotesWatch;
        private System.Windows.Forms.TextBox txtResolveWatch;
        private System.Windows.Forms.TextBox txtEchoWatch;
        private System.Windows.Forms.TextBox txtTimeWatch;
        private System.Windows.Forms.TextBox txtPublicWatch;
        private System.Windows.Forms.TextBox txtWeatherWatch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAsynchronous;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtAsynchronousWatch;
    }
}

