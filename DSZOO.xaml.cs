using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ZOOBD.zoomagDataSetTableAdapters;

namespace ZOOBD
{
    public partial class DSZOO : Window
    {
        AllDataWithoutIDsTableAdapter animals = new AllDataWithoutIDsTableAdapter();
        public DSZOO()
        {
            InitializeComponent();
            AnimalDgr.ItemsSource = animals.GetData();

        }
    }
}
