using Plugin.LocalNotification;

namespace LocalNotification_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSendNotification(object sender, EventArgs e)
        {
            var request = new NotificationRequest
            {
                NotificationId = 1000,
                Title = "App Name",
                Subtitle = "Hello",
                Description = "Description",
                BadgeNumber = 42,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(5),
                    NotifyRepeatInterval = TimeSpan.FromDays(1),
                }
            };

            LocalNotificationCenter.Current.Show(request);
        }
    }

}
