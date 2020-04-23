using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PuppeteerSharp;

namespace ClassLibrary1
{

    public class DeliveryPerformanceAutomation
    {
        BaseLauncher Launcher = new BaseLauncher(false);
        public DeliveryPerformanceAutomation()
        {

        }

        public async void LoginDelivereyPerformance()
        {
            //  string url = "https://www.bing.com/maps";
            string url = "https://test.centiro.com/app/id4/Account/Login?ReturnUrl=%2Fapp%2Fid4%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3DUniverse_Test-DeliveryPerformanceWeb%26redirect_uri%3Dhttps%253A%252F%252Ftest.centiro.com%252Fc3web-ext%252FDeliveryPerformanceWeb%252F%26response_mode%3Dform_post%26response_type%3Did_token%2520token%26scope%3Dopenid%2520openid%2520universe%26state%3DOpenIdConnect.AuthenticationProperties%253DhnA2wY07p3j5vG17ggWr3i5RtPNo7igyxzo1PLV2_zvHS-WC9LQoWeyF1kzUPR_CoxGgiIyNgXzJdvAndjfbiJe0VUOOWzeHa0GaP2gkHoytHJ0rK4_hzvoVuAJoSUl0qg62gOZwdphqONhf_aH9AsfVnAETkaRYnetA_yckgKPPkZL9C2v71u9QzSIwwPGBdRKfB37PA1Yis0u8BClxv7Cxgwk5O6ivISkPTWG4tYA_Xt4AaNhiDfbKxh4zgqbUa8zYZ0GGbRLXyuWKiKAz060S706wVF5V1rR9e6RzTnQ%26nonce%3D637231428755378062.OGU3OTYxMmYtZGJjYy00ZTZlLTlmYTItMjM1OWJkY2M3NTY3Yjg5OTkyZTEtOGE5Ni00YjEwLWJmNjYtOGJmYjJjZTE5NTUw";

            var task = Launcher.LoadPage(url);
       
            await task.Result.WaitForSelectorAsync("#username");
            //await task.Result.WaitForSelectorAsync(".searchbox input");
            //await task.Result.FocusAsync(".searchbox input");
            //await task.Result.Keyboard.TypeAsync("CN Tower, Toronto, Ontario, Canada");

            //await task.Result.TypeAsync("#username", "dp@nike.com");
            //await task.TypeAsync("input[id='username']", "Puppeteer");
            //await task.Result.FocusAsync("#username");
            //await task.Result.Keyboard.TypeAsync("asdf");
            //await task.Result.WaitForSelectorAsync("#password");
            //task.Result.FocusAsync("#password");
            //task.Result.Keyboard.TypeAsync("DPNike2018!");

            //await task.Result.ClickAsync("#btnLogin");
        }
    }
}
