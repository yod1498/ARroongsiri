using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Gamestrap
{
    public class MainMenuControl : MonoBehaviour
    {
        private static int visibleVariable = Animator.StringToHash("Visible");
        private static int notifyVariable = Animator.StringToHash("Notify");

		public GameObject howtoPanel,brochurePanel, settingsPanel, aboutPanel;

        public Toggle soundToggle, musicToggle;

        public Text notificationText;
        private Animator notificationAnimator;
        public void Start()
        {
            //Adds events to the Toggle buttons through code since
            //doing it through the inspector wouldn't will give the value of the button dynamically
            soundToggle.onValueChanged.AddListener(ToggleSound);
            musicToggle.onValueChanged.AddListener(ToggleMusic);

            notificationAnimator = notificationText.GetComponent<Animator>();
        }

        #region Event Methods Called from the UI
        public void PlayClick()
        {
            GSAppExampleControl.Instance.LoadScene(ESceneNames.Levels);
        }

        public void AchievementsClick()
        {
            notificationText.text = "Achievements Clicked...";
            notificationAnimator.SetTrigger(notifyVariable);
        }

        public void LeaderboardClick()
        {
            notificationText.text = "Leaderboard Clicked...";
            notificationAnimator.SetTrigger(notifyVariable);
        }

        public void RateClick()
        {
            notificationText.text = "Rate Clicked...";
            notificationAnimator.SetTrigger(notifyVariable);
        }

        #region Settings Events
		public void ToggleBrochurePanel()
		{
			TogglePanel(brochurePanel.GetComponent<Animator>());
		}

		public void ToggleHowtoPanel()
		{
			TogglePanel(howtoPanel.GetComponent<Animator>());
		}

        public void ToggleSettingsPanel()
        {
            TogglePanel(settingsPanel.GetComponent<Animator>());
        }

        public void ToggleSound(bool on)
        {
            // Change the sound
        }

        public void ToggleMusic(bool on)
        {
            // Change the music
        }

        #endregion

        #region About Events

        public void FacebookClick()
        {
			Application.OpenURL("https://www.facebook.com/roongsiri.greenprint");
        }

        public void TwitterClick()
        {
            Application.OpenURL("https://twitter.com/EmeralDigEnt");

        }
		public void LineClick()
		{
			Application.OpenURL("https://line.me/R/ti/p/%40roongsiri_printing");

		}
        public void YoutubeClick()
        {
			Application.OpenURL("https://www.youtube.com/watch?v=0tXee8m0LGI");
        }

        public void WebsiteClick()
        {
			Application.OpenURL("http://www.roongsiri.co.th");
        }

		public void BrochureClick()
		{
			Application.OpenURL("https://drive.google.com/file/d/0BxbmyNrjdRIOVEN4RTBnd3loWWM/view?usp=sharing");
		}

        #endregion

        public void ToggleAboutPanel()
        {
            TogglePanel(aboutPanel.GetComponent<Animator>());
        }

        private void TogglePanel(Animator panelAnimator)
        {
            panelAnimator.SetBool(visibleVariable, !panelAnimator.GetBool(visibleVariable));
        }
        #endregion
    }
}