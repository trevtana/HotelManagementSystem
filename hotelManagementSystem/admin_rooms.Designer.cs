namespace hotelManagementSystem
{
    partial class admin_rooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rooms_clearBtn = new System.Windows.Forms.Button();
            this.rooms_deleteBtn = new System.Windows.Forms.Button();
            this.rooms_updateBtn = new System.Windows.Forms.Button();
            this.rooms_addBtn = new System.Windows.Forms.Button();
            this.rooms_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rooms_picture = new System.Windows.Forms.PictureBox();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_roomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rooms_roomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 310);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Room\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 48);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(907, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rooms_clearBtn);
            this.panel2.Controls.Add(this.rooms_deleteBtn);
            this.panel2.Controls.Add(this.rooms_updateBtn);
            this.panel2.Controls.Add(this.rooms_addBtn);
            this.panel2.Controls.Add(this.rooms_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rooms_roomName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rooms_type);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rooms_roomID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 310);
            this.panel2.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            this.rooms_clearBtn.BackColor = System.Drawing.Color.Lavender;
            this.rooms_clearBtn.FlatAppearance.BorderSize = 0;
            this.rooms_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_clearBtn.ForeColor = System.Drawing.Color.Black;
            this.rooms_clearBtn.Location = new System.Drawing.Point(546, 230);
            this.rooms_clearBtn.Name = "rooms_clearBtn";
            this.rooms_clearBtn.Size = new System.Drawing.Size(98, 36);
            this.rooms_clearBtn.TabIndex = 28;
            this.rooms_clearBtn.Text = "Clear";
            this.rooms_clearBtn.UseVisualStyleBackColor = false;
            this.rooms_clearBtn.Click += new System.EventHandler(this.rooms_clearBtn_Click);
            // 
            // rooms_deleteBtn
            // 
            this.rooms_deleteBtn.BackColor = System.Drawing.Color.Lavender;
            this.rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            this.rooms_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.rooms_deleteBtn.Location = new System.Drawing.Point(421, 230);
            this.rooms_deleteBtn.Name = "rooms_deleteBtn";
            this.rooms_deleteBtn.Size = new System.Drawing.Size(98, 36);
            this.rooms_deleteBtn.TabIndex = 27;
            this.rooms_deleteBtn.Text = "Delete";
            this.rooms_deleteBtn.UseVisualStyleBackColor = false;
            this.rooms_deleteBtn.Click += new System.EventHandler(this.rooms_deleteBtn_Click);
            // 
            // rooms_updateBtn
            // 
            this.rooms_updateBtn.BackColor = System.Drawing.Color.Lavender;
            this.rooms_updateBtn.FlatAppearance.BorderSize = 0;
            this.rooms_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_updateBtn.ForeColor = System.Drawing.Color.Black;
            this.rooms_updateBtn.Location = new System.Drawing.Point(225, 230);
            this.rooms_updateBtn.Name = "rooms_updateBtn";
            this.rooms_updateBtn.Size = new System.Drawing.Size(98, 36);
            this.rooms_updateBtn.TabIndex = 26;
            this.rooms_updateBtn.Text = "Update";
            this.rooms_updateBtn.UseVisualStyleBackColor = false;
            this.rooms_updateBtn.Click += new System.EventHandler(this.rooms_updateBtn_Click);
            // 
            // rooms_addBtn
            // 
            this.rooms_addBtn.BackColor = System.Drawing.Color.Lavender;
            this.rooms_addBtn.FlatAppearance.BorderSize = 0;
            this.rooms_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_addBtn.ForeColor = System.Drawing.Color.Black;
            this.rooms_addBtn.Location = new System.Drawing.Point(100, 230);
            this.rooms_addBtn.Name = "rooms_addBtn";
            this.rooms_addBtn.Size = new System.Drawing.Size(98, 36);
            this.rooms_addBtn.TabIndex = 25;
            this.rooms_addBtn.Text = "Add";
            this.rooms_addBtn.UseVisualStyleBackColor = false;
            this.rooms_addBtn.Click += new System.EventHandler(this.rooms_addBtn_Click);
            // 
            // rooms_importBtn
            // 
            this.rooms_importBtn.BackColor = System.Drawing.Color.Lavender;
            this.rooms_importBtn.FlatAppearance.BorderSize = 0;
            this.rooms_importBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_importBtn.ForeColor = System.Drawing.Color.Black;
            this.rooms_importBtn.Location = new System.Drawing.Point(836, 159);
            this.rooms_importBtn.Name = "rooms_importBtn";
            this.rooms_importBtn.Size = new System.Drawing.Size(98, 36);
            this.rooms_importBtn.TabIndex = 24;
            this.rooms_importBtn.Text = "Import";
            this.rooms_importBtn.UseVisualStyleBackColor = false;
            this.rooms_importBtn.Click += new System.EventHandler(this.rooms_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.rooms_picture);
            this.panel3.Location = new System.Drawing.Point(836, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 124);
            this.panel3.TabIndex = 23;
            // 
            // rooms_picture
            // 
            this.rooms_picture.Location = new System.Drawing.Point(0, 0);
            this.rooms_picture.Name = "rooms_picture";
            this.rooms_picture.Size = new System.Drawing.Size(98, 124);
            this.rooms_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rooms_picture.TabIndex = 0;
            this.rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            this.rooms_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.rooms_status.Location = new System.Drawing.Point(469, 52);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(175, 28);
            this.rooms_status.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(387, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Status : ";
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_price.Location = new System.Drawing.Point(469, 15);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(175, 26);
            this.rooms_price.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(364, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price ($) :";
            // 
            // rooms_roomName
            // 
            this.rooms_roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_roomName.Location = new System.Drawing.Point(148, 103);
            this.rooms_roomName.Name = "rooms_roomName";
            this.rooms_roomName.Size = new System.Drawing.Size(175, 26);
            this.rooms_roomName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Room Name :";
            // 
            // rooms_type
            // 
            this.rooms_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_type.FormattingEnabled = true;
            this.rooms_type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_type.Location = new System.Drawing.Point(148, 58);
            this.rooms_type.Name = "rooms_type";
            this.rooms_type.Size = new System.Drawing.Size(175, 28);
            this.rooms_type.TabIndex = 16;
            this.rooms_type.SelectedIndexChanged += new System.EventHandler(this.rooms_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type : ";
            // 
            // rooms_roomID
            // 
            this.rooms_roomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_roomID.Location = new System.Drawing.Point(148, 15);
            this.rooms_roomID.Name = "rooms_roomID";
            this.rooms_roomID.Size = new System.Drawing.Size(175, 26);
            this.rooms_roomID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Room ID :";
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(990, 691);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Button rooms_importBtn;
        private Panel panel3;
        private PictureBox rooms_picture;
        private ComboBox rooms_status;
        private Label label6;
        private TextBox rooms_price;
        private Label label4;
        private TextBox rooms_roomName;
        private Label label3;
        private ComboBox rooms_type;
        private Label label2;
        private TextBox rooms_roomID;
        private Label label1;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
    }
}
