using MonoTouch.ObjCRuntime;

namespace MaryPopin
{
	[Native]
	public enum BKTPopinTransitionStyle : int
	{
		/// <summary>
		/// When the view controller is presented, its view slide in the parent view controller and slide out on dismiss.
		/// </summary>
		Slide,
		/// <summary>
		/// When the view controller is presented, its view fade in and fade out on dismiss. Transition direction is ignored for this kind of transition.
		/// </summary>
		CrossDissolve,
		/// <summary>
		/// When the view controller is presented, its view fade in with a zoom out effect and fade out with a zoom in effect on dismiss. Transition direction is ignored for this kind of transition.
		/// </summary>
		Zoom,
		/// <summary>
		/// When the view controller is presented, its view slide in with a bounce effect and slide out on dismiss.
		/// </summary>
		SpringySlide,
		/// <summary>
		/// When the view controller is presented, its view zoom and fade in with a bounce effect. Transition direction is ignored for this kind of transition.
		/// </summary>
		SpringyZoom,
		/// <summary>
		/// When the view controller is presented, its view has a undefined behavior.
		/// </summary>
		Snap,
		/// <summary>
		/// When the view controller is presented, its view has a custom animation.
		/// </summary>
		Custom
	}

	[Native]
	public enum BKTPopinTransitionDirection : int
	{
		/// <summary>
		/// Presentation transition will start from the bottom of the parent view. Respectively, dismiss transition will end to the bottom of the parent view.
		/// </summary>
		Bottom,
		/// <summary>
		/// Presentation transition will start from the top of the parent view. Respectively, dismiss transition will end to the top of the parent view.
		/// </summary>
		Top,
		/// <summary>
		/// Presentation transition will start from the left of the parent view. Respectively, dismiss transition will end to the left of the parent view.
		/// </summary>
		Left,
		/// <summary>
		/// Presentation transition will start from the right of the parent view. Respectively, dismiss transition will end to the right of the parent view.
		/// </summary>
		Right
	}

	[Native]
	public enum BKTPopinOption : uint
	{
		/// <summary>
		/// Default behaviour.
		/// </summary>
		Default = 0,
		/// <summary>
		/// Disable popin reaction to keyboard notifications.
		/// </summary>
		IgnoreKeyboardNotification = 1 << 0,
		/// <summary>
		/// Disable auto dismiss when touching outside of the popin view.
		/// </summary>
		DisableAutoDismiss = 1 << 1,
		/// <summary>
		/// Takes a screenshot of presenting view, blurs it and uses it as dimming view. Available only on ios 7.x.
		/// </summary>
		BlurryDimmingView = 1 << 2,
		/// <summary>
		/// Disable parallax effect on iOS7.
		/// </summary>
		DisableParallaxEffect = 1 << 3,
		/// <summary>
		/// Set a background dimming view with a clear color. Default is a semi-transparent black background.
		/// </summary>
		DimmingViewStyleNone = 1 << 16
	}

	[Native]
	public enum BKTPopinAlignementOption : int
	{
		/// <summary>
		/// Popin will be centered in container. Default.
		/// </summary>
		Centered,
		/// <summary>
		/// Popin will be stuck to top in container.
		/// </summary>
		Up,
		/// <summary>
		/// Popin will be left-aligned in container.
		/// </summary>
		Left,
		/// <summary>
		/// Default will be stuck to bottom in container.
		/// </summary>
		Down,
		/// <summary>
		/// Popin will be right-aligned in container.
		/// </summary>
		Right
	}
}
