using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Gamestrap
{
	public class SocialLink : MonoBehaviour {

		public void LineClick(){
				Application.OpenURL ("https://line.me/R/ti/p/%40roongsiri_printing");
		}

		public void YoutubeClick()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=0tXee8m0LGI");
		}

		public void facebookClick(){
			Application.OpenURL ("https://www.facebook.com/roongsiri.greenprint");
		}

		public void homeClick (){
			SceneManager.LoadScene ("MainMenu");
		}

	}
}
