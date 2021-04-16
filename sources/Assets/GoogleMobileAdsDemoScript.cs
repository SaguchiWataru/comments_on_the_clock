
	using GoogleMobileAds.Api;

	public class GoogleMobileAdsDemoScript
{
	private BannerView bannerView;

	public void Start()
	{
		#if UNITY_ANDROID
		string appId = "ca-app-pub-2706162434109497~8929319211";
		#elif UNITY_IPHONE
		string appId = "";
		#else
		string appId = "unexpected_platform";
		#endif

		// Initialize the Google Mobile Ads SDK.
		MobileAds.Initialize(appId);

		this.RequestBanner();
		}

		private void RequestBanner()
		{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-2706162434109497/8225901196";
		#elif UNITY_IPHONE
		string adUnitId = "";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
		}
		}