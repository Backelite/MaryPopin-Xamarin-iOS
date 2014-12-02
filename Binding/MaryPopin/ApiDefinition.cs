using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MaryPopin
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//

	[BaseType(typeof(UIViewController))]
	[Category]
	interface MaryPopinUIViewControllerExtension {
		#region Methods

		/// <summary>
		/// Present a popin controller as a child of the receiver, centered inside an arbitrary rect.
		/// </summary>
		/// <param name="popinController">The controller to present as a popin.</param>
		/// <param name="animated">Pass `YES` to animate the presentation. Otherwise, pass `NO`.</param>
		/// <param name="completion">A completion handler, or `NULL`</param>
		[Export("presentPopinController:animated:completion:")]
		void PresentPopinController(UIViewController popinController, bool animated, [NullAllowed] CompletionDelegate completion);

		/// <summary>
		/// Present a popin controller as a child of the receiver, centered inside an arbitrary rect.
		/// </summary>
		/// <param name="popinController">The controller to present as a popin.</param>
		/// <param name="fromRect">An arbitrary rect in which the popin should be centered.</param>
		/// <param name="animated">Pass `YES` to animate the presentation. Otherwise, pass `NO`.</param>
		/// <param name="completion">A completion handler, or `NULL`.</param>
		[Export("presentPopinController:fromRect:animated:completion:")]
		void PresentPopinController(UIViewController popinController, RectangleF fromRect, bool animated, [NullAllowed] CompletionDelegate completion);

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
		void DismissCurrentPopinController(bool animated, [NullAllowed] CompletionDelegate completion);

		#endregion


		#region Properties

		/// <summary>
		/// A reference to the popin presented as a child controller.
		/// </summary>
		/// <value>The controller presented as a popin or `nil`.</value>
		[Export("presentedPopinViewController")]
		UIViewController PresentedPopinViewController { get; }

		/// <summary>
		/// A reference to the parent presenting the popin.
		/// </summary>
		/// <value>The controller presenting the popin, or `nil`.</value>
		[Export("presentingPopinViewController")]
		UIViewController PresentingPopinViewController{ get; }

		/// <summary>
		/// Gets or sets the size of the prefered popin content.
		/// This value may not be respected if popin is bigger than the presenting controller view.
		/// If not set, the default size will be the controller view size.
		/// </summary>
		/// <value>The size of the prefered popin content.</value>
		[Export("preferedPopinContentSize")]
		SizeF PreferedPopinContentSize{ get; set; }

		/// <summary>
		/// The transition style to use when presenting a popin. Default value is `BKTPopinTransitionStyleSlide`.
		/// For a list of possible transition style, see `BKTPopinTransitionStyle`.
		/// </summary>
		/// <value>The popin transition style.</value>
		[Export("popinTransitionStyle")]
		BKTPopinTransitionStyle PopinTransitionStyle { get; set; }

		/// <summary>
		/// The transition direction to use when presenting a popin. Default value is `BKTPopinTransitionDirectionBottom`.
		/// </summary>
		/// <value>The popin transition direction.</value>
		[Export("popinTransitionDirection")]
		BKTPopinTransitionDirection PopinTransitionDirection { get; set; }

		/// <summary>
		/// The options to apply to the popin. For a list of possible options, see BKTPopinOption.
		/// </summary>
		/// <value>The popin options.</value>
		[Export("popinOption")]
		BKTPopinOption PopinOptions { get; set; }

		/// <summary>
		/// Get the custom in animation block. Default value is nil.
		/// </summary>
		/// <value>The popin custom in animation.</value>
		[Export("popinCustomInAnimation")]
		AnimationDelegate PopinCustomInAnimation { get; set; }

		/// <summary>
		/// Get the custom out animation block. Default value is nil.
		/// </summary>
		/// <value>The popin custom out animation.</value>
		[Export("popinCustomOutAnimation")]
		AnimationDelegate PopinCustomOutAnimation { get; set; }

		/// <summary>
		/// The options to apply to the popin. Default value is `BKTPopinAlignementOptionCentered`.
		/// </summary>
		/// <value>The popin alignment.</value>
		[Export("popinAlignment")]
		BKTPopinAlignementOption PopinAlignment { get; set; }

		/// <summary>
		/// An object used to configure the blurred background.
		/// </summary>
		/// <value>The blur parameters.</value>
		[Export("blurParameters"), NullAllowed]
		BKTBlurParameters BlurParameters { get; set; }

		#endregion
	}
}
