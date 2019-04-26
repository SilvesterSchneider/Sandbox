import 'package:flutter/material.dart';

class MyDemoApp extends StatelessWidget{
  @override
  Widget build(BuildContext context) {
    return new HelloFlutterText();
  }
}

class HelloFlutterText extends StatelessWidget{
  @override
  Widget build(BuildContext context) {    
    return new Center(
      child: new Text('Hello from Flutter',
        textDirection: TextDirection.ltr,
        style: new TextStyle( fontSize: 48.0 ,fontWeight: FontWeight.bold))
    );
  }
}