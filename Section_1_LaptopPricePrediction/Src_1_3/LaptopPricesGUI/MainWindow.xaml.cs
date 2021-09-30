using System.Windows;
using static LaptopPricesGUI.MLModel1;

namespace LaptopPricesGUI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sldSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblGhz.Content = $"{sldSpeed.Value:F1} GHz";
        }

        private void sldRAM_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblRAMGb.Content = $"{sldRAM.Value:####} Gb";
        }

        private void sldScreenSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblScreenSize.Content = $"{sldScreenSize.Value:F1}\"";
        }

        private void sldStorage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblStorageGb.Content = $"{sldStorage.Value:####} Gb";
        }

        private void sldWeight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblWeightPounds.Content = $"{sldWeight.Value:F1}";
        }

        private void btnPredictPrice_Click(object sender, RoutedEventArgs e)
        {
            var predictedPrice = PredictPrice(cboCPU1.Text,(float) sldSpeed.Value, cboGPU.Text, cboRAMType.Text, (float) sldRAM.Value,
                (float) sldScreenSize.Value, (float) sldStorage.Value, chkIsSSD.IsChecked.Value, (float) sldWeight.Value);
            
            lblPrice.Content = $"{predictedPrice}";
        }

        private float PredictPrice(string CPU, 
            float GHz, 
            string GPU, 
            string RAMType, 
            float RAMAmount,
            float screenSize, 
            float storage, 
            bool isSSD, 
            float weight)
        {
            ModelInput input = new ModelInput()
            {
                CPU = CPU,
                GHz = GHz,
                GPU = GPU,
                RAM = RAMAmount,
                RAMType = RAMType,
                Screen = screenSize,
                Storage = storage,
                SSD = isSSD,
                Weight = weight,
            };

            ModelOutput result = Predict(input);
            return result.Score;
        }
    }
}