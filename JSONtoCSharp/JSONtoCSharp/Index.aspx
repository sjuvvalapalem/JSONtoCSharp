<%--
// (c) @sjuvvalapalem -- Funny but no Copyright.. Do anything you want no responsibility from my side for any thing...
--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="JSONtoCSharp.Index" %>

<!DOCTYPE html>
<html lang="en">
<head>

  <title>JSON Sample</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <link href="http://fonts.googleapis.com/css?family=Lato" rel="stylesheet" type="text/css">
  <link href="http://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" type="text/css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <link href="CSS/bootStrap_additional.css" rel="stylesheet" type="text/css" />

    <style>
       
    </style>
</head>
<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="50">





<!-- Container (The Band Section) -->
<div  class="container text-center">
  <h3>JSON Sample</h3>
  <p>A sample that shows how to take a json and convert it to a C# object (or array) and read values from the object. What this does is gives us more control as this will be a regular C# object and we could access the values easily with a "."
      Check my  <a href="https://dotnetfiddle.net/Lf3tj7">fiddle</a> for the same code.
  </p>
  <p>The comments in the code should be fairly self explanatory </p>
    <br>
  <div class="row">
    <div class="col-lg-12">
      <p class="text-center"><strong>Output in Console Style ;) </strong></p><br>

           <textarea id="TextArea1" rows="30" style="width:100%" wrap="soft" runat="server" disabled="disabled"></textarea>


    </div>

  </div>
</div>


<!-- Footer -->
<footer class="text-center">
  <p>@sjuvvalapalem </p>
</footer>



</body>
</html>

