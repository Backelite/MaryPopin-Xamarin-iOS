using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using System;

namespace MaryPopin
{
	[BaseType(typeof(NSObject))]
	interface BKTBlurParameters
	{
		[Export("alpha", ArgumentSemantic.UnsafeUnretained)]
		float Alpha { get; set; }

		[Export("radius", ArgumentSemantic.UnsafeUnretained)]
		float Radius { get; set; }

		[Export("saturationDeltaFactor", ArgumentSemantic.UnsafeUnretained)]
		float SaturationDeltaFactor { get; set; }

		[Export("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }
	}

	delegate void AnimationDelegate(UIViewController popinController, RectangleF initialFrame, RectangleF finalFrame);

	[Category]
	[BaseType(typeof(UIViewController))]
	interface MaryPopin {
		#region Methods

		/// <summary>
		/// Present a popin controller as a child of the receiver, centered inside an arbitrary rect.
		/// </summary>
		/// <param name="popinController">The controller to present as a popin.</param>
		/// <param name="animated">Pass `YES` to animate the presentation. Otherwise, pass `NO`.</param>
		/// <param name="completion">A completion handler, or `NULL`</param>
		[Export("presentPopinController:animated:completion:")]
		void PresentPopinController(UIViewController popinController, bool animated, [NullAllowed] Action completion);

		/// <summary>
		/// Present a popin controller as a child of the receiver, centered inside an arbitrary rect.
		/// </summary>
		/// <param name="popinController">The controller to present as a popin.</param>
		/// <param name="fromRect">An arbitrary rect in which the popin should be centered.</param>
		/// <param name="animated">Pass `YES` to animate the presentation. Otherwise, pass `NO`.</param>
		/// <param name="completion">A completion handler, or `NULL`.</param>
		[Export("presentPopinController:fromRect:animated:completion:")]
		void PresentPopinController(UIViewController popinController, RectangleF fromRect, bool animated, [NullAllowed] Action completion);

		/// <summary>
		/// Dismiss the visible popin if any.
		/// </summary>
		/// <param name="animated">Pass `YES` to animate the dismiss. Otherwise, pass `NO`.</param>
		[Export("dismissCurrentPopinControllerAnimated:")]
		void DismissCurrentPopinController(bool animated);

		/// <summary>
		/// Dismiss the visible popin if any.
		/// </summary>
		/// <param name="animated">Pass `YES` to animate the dismiss. Otherwise, pass `NO`.</param>
		/// <param name="completion">A completion handler, or `NULL`.</param>
		[Export("dismissCurrentPopinControllerAnimated:completion:")]
		void DismissCurrentPopinController(bool animated, [NullAllowed] Action completion);

		#endregion


		#region Properties like

		// -(UIViewController *)presentedPopinViewController;
		[Export("presentedPopinViewController")]
		UIViewController PresentedPopinViewController();

		// -(UIViewController *)presentingPopinViewController;
		[Export("presentingPopinViewController")]
		UIViewController PresentingPopinViewController();

		// -(CGSize)preferedPopinContentSize;
		[Export("preferedPopinContentSize")]
		SizeF PreferedPopinContentSize();

		// -(void)setPreferedPopinContentSize:(CGSize)preferredSize;
		[Export("setPreferedPopinContentSize:")]
		void SetPreferedPopinContentSize(RectangleF preferredSize);

		// -(BKTPopinTransitionStyle)popinTransitionStyle;
		[Export("popinTransitionStyle")]
		BKTPopinTransitionStyle PopinTransitionStyle();

		// -(void)setPopinTransitionStyle:(BKTPopinTransitionStyle)transitionStyle;
		[Export("setPopinTransitionStyle:")]
		void SetPopinTransitionStyle(BKTPopinTransitionStyle transitionStyle);

		// -(BKTPopinTransitionDirection)popinTransitionDirection;
		[Export("popinTransitionDirection")]
		BKTPopinTransitionDirection PopinTransitionDirection();

		// -(void)setPopinTransitionDirection:(BKTPopinTransitionDirection)transitionDirection;
		[Export("setPopinTransitionDirection:")]
		void SetPopinTransitionDirection(BKTPopinTransitionDirection transitionDirection);

		// -(BKTPopinOption)popinOptions;
		[Export("popinOptions")]
		BKTPopinOption PopinOptions();

		// -(void)setPopinOptions:(BKTPopinOption)popinOptions;
		[Export("setPopinOptions:")]
		void SetPopinOptions(BKTPopinOption popinOptions);

		// -(void (^)(UIViewController *, CGRect, CGRect))popinCustomInAnimation;
		[Export("popinCustomInAnimation")]
		AnimationDelegate PopinCustomInAnimation();

		// -(void)setPopinCustomInAnimation:(void (^)(UIViewController *, CGRect, CGRect))customInAnimation;
		[Export("setPopinCustomInAnimation:")]
		void SetPopinCustomInAnimation(AnimationDelegate customInAnimation);

		// -(void (^)(UIViewController *, CGRect, CGRect))popinCustomOutAnimation;
		[Export("popinCustomOutAnimation")]
		AnimationDelegate PopinCustomOutAnimation();

		// -(void)setPopinCustomOutAnimation:(void (^)(UIViewController *, CGRect, CGRect))customOutAnimation;
		[Export("setPopinCustomOutAnimation:")]
		void SetPopinCustomOutAnimation(AnimationDelegate customOutAnimation);

		// -(BKTPopinAlignementOption)popinAlignment;
		[Export("popinAlignment")]
		BKTPopinAlignementOption PopinAlignment();

		// -(void)setPopinAlignment:(BKTPopinAlignementOption)popinAlignment;
		[Export("setPopinAlignment:")]
		void SetPopinAlignment(BKTPopinAlignementOption popinAlignment);

		// -(BKTBlurParameters *)blurParameters;
		[Export("blurParameters")]
		BKTBlurParameters BlurParameters();

		// -(void)setBlurParameters:(BKTBlurParameters *)blurParameters;
		[Export("setBlurParameters:")]
		void SetBlurParameters(BKTBlurParameters blurParameters);

		#endregion
	}
}
