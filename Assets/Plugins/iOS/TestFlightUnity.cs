/*
Copyright (C) 2012, WEI Xiang

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if UNITY_IOS && !UNITY_EDITOR
#define IOS_DEVICE
#endif

using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public static class TestFlightUnity {
	
#if IOS_DEVICE
	[DllImport ("__Internal")]
	private static extern void TestFlight_TakeOff (string token);

	[DllImport ("__Internal")]
	private static extern void TestFlight_PassCheckpoint (string checkpoint);

	[DllImport ("__Internal")]
	private static extern void TestFlight_OpenFeedbackDialog ();

	[DllImport ("__Internal")]
	private static extern void TestFlight_SubmitFeedback (string feedback);

	[DllImport ("__Internal")]
	private static extern void TestFlight_Log (string message);

	[DllImport ("__Internal")]
	private static extern void TestFlight_EnableAppleSystemLogger (bool enabled);

	[DllImport ("__Internal")]
	private static extern void TestFlight_EnableSTDErrLogger (bool enabled);
#endif

	public static void TakeOff(string token)
	{
#if IOS_DEVICE
		TestFlight_TakeOff(token);
#endif
	}

	public static void PassCheckpoint(string checkpoint) {
#if IOS_DEVICE
		TestFlight_PassCheckpoint(checkpoint);
#endif
	}

	public static void OpenFeedbackDialog() {
#if IOS_DEVICE
		TestFlight_OpenFeedbackDialog();
#endif
	}

	public static void SubmitFeedback(string feedback) {
#if IOS_DEVICE
		TestFlight_SubmitFeedback(feedback);
#endif
	}

	public static void Log(string message) {
#if IOS_DEVICE
		TestFlight_Log(message);
#endif
	}

	public static void EnableAppleSystemLogger(bool enabled) {
#if IOS_DEVICE
		TestFlight_EnableAppleSystemLogger(enabled);
#endif
	}

	public static void EnableSTDErrLogger(bool enabled) {
#if IOS_DEVICE
		TestFlight_EnableSTDErrLogger(enabled);
#endif
	}
}

