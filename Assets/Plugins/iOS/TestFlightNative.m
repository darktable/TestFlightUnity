/*
Copyright (C) 2012, WEI Xiang

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#import "TestFlight.h"

void TestFlight_TakeOff(const char* token) {
#define TESTING 1
#ifdef TESTING
    [TestFlight setDeviceIdentifier:[[UIDevice currentDevice] uniqueIdentifier]];
#endif
    
    [TestFlight takeOff:[NSString stringWithUTF8String:token]];
}

void TestFlight_PassCheckpoint(const char* checkpoint) {
    [TestFlight passCheckpoint:[NSString stringWithUTF8String:checkpoint]];
}

void TestFlight_OpenFeedbackDialog() {
    [TestFlight openFeedbackView];
}

void TestFlight_SubmitFeedback(const char* feedback) {
    [TestFlight submitFeedback:feedback];
}

void TestFlight_Log(const char* message) {
    TFLog([NSString stringWithUTF8String:message]);
}

void TestFlight_EnableAppleSystemLogger(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:@"logToConsole"]];
}

void TestFlight_EnableSTDErrLogger(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:@"logToSTDERR"]];
}

