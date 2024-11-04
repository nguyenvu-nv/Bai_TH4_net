using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsForms_bài_thực_hành_4.Form1;

namespace WindowsForms_bài_thực_hành_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Customer
        {
            public string CustomerId { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }
        private List<Customer> customers = new List<Customer>();
        private int nextCustomerId = 1; // Mã khách hàng sẽ tự động tăng
        public class Service
        {
            public string ServiceId { get; set; }
            public string ServiceName { get; set; }
            public int Serviceprice { get; set; }
        }
        private List<Service> service = new List<Service>();

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng khách hàng mới với mã tự động tăng
            Customer newCustomer = new Customer
            {
                CustomerId = "kH" + nextCustomerId++,
                Name = txt_tenkh.Text,
                Phone = txt_sodt.Text,
                Address = txt_diachi.Text
            };

            // Thêm khách hàng vào danh sách
            customers.Add(newCustomer);

            // Cập nhật lại DataGridView
            data_KH.DataSource = null;
            data_KH.DataSource = customers;

            // Xóa dữ liệu trong các TextBox
            txt_tenkh.Clear();
            txt_sodt.Clear();
            txt_diachi.Clear();
            LoadComboBox();
        }
        //thêm data cho bảng dịch vụ
        public void loaddataService()
        {
            service.Add(new Service
            {
                ServiceId = "Dịch vụ 1",
                ServiceName = "Cắt tóc + gội đầu ",
                Serviceprice = 100000
            });
            service.Add(new Service
            {
                ServiceId = "Dịch vụ 2",
                ServiceName = "cạo râu + mặt",
                Serviceprice = 30000
            });
            service.Add(new Service
            {
                ServiceId = "Dịch vụ 3",
                ServiceName = "nhuộm tóc",
                Serviceprice = 200000
            });
            service.Add(new Service
            {
                ServiceId = "Dịch vụ 4",
                ServiceName = "lấy ráy tai",
                Serviceprice = 20000
            });
            service.Add(new Service
            {
                ServiceId = "Dịch vụ 5",
                ServiceName = "uốn tóc",
                Serviceprice = 90000
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            data_DV.AutoGenerateColumns = true;
            loaddataService();
            data_DV.DataSource = service;
            data_DV.Refresh();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var kh in customers)
            {
                comboBox1.Items.Add(kh.Name);
            }

            checkedListBox1.Items.Clear(); // Thay đổi từ comboBox sang checkedListBox
            foreach (var dv in service)
            {
                checkedListBox1.Items.Add(dv.ServiceName);
            }
        }
        private int currentHoaDonID = 1;
        private string currentKhachHang = "";
        private string currentDichVu = "";
        private int currentTongTien = 0;
        private void UpdateHoaDon()
        {
            label9.Text = currentHoaDonID.ToString(); // Hiển thị ID hóa đơn
            label13.Text = currentKhachHang;           // Hiển thị tên khách hàng
            label14.Text = currentDichVu;              // Hiển thị tên dịch vụ
            label15.Text = currentTongTien.ToString(); // Hiển thị tổng tiền
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                currentKhachHang = comboBox1.SelectedItem.ToString();

                // Tính tổng tiền cho các dịch vụ đã chọn
                currentTongTien = 0;
                currentDichVu = ""; // Reset tên dịch vụ

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    var sv = service.Find(d => d.ServiceName == item.ToString());
                    if (sv != null)
                    {
                        currentTongTien += sv.Serviceprice;
                        currentDichVu += sv.ServiceName + " "; // Gộp tên dịch vụ
                    }
                }

                // Cập nhật thông tin hóa đơn tạm thời
                UpdateHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
            }
        }
    }

}
