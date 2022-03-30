WebView2 Drag and Drop DataObject

This example was taken from [Webview2Feedback issue #2313]([File drag and drop from WebView2 · Issue #2313 · MicrosoftEdge/WebView2Feedback · GitHub](https://github.com/MicrosoftEdge/WebView2Feedback/issues/2313)).

Drag and drop to and from Webview2 control dataobject example.  
This project consist of two examples.

- Form 1. The normal drap and drop to webview2 with the typical browser handling. Drag and drop from webview returns the dataobject file path.
  
- Form 2. When drag and drop to a Webview the new window request is handled blocking the normal browser behavior of opening a new window and instead returns the file path of the dropped path.
  

## Explanation

Drag the file to webview2 will "open window".  
Intercept "open window" in C# `wv2.CoreWebView2.NewWindowRequested`, get the file path,  
And use `wv2.CoreWebView2.ExecuteScriptAsync` to send this file path to the web page.  
"open window" is an asynchronous processing behavior, so in js I use `await Lib.Sleep()` to wait until the global variable `var temp_dropPath` is changed.
