using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMaryPopin.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
