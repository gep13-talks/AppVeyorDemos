var target = Argument("target", "AppVeyor");

Task("Default")
    .Does(() =>
{
    Information("Hello World!");
});

Task("AppVeyor")
  .Does(() =>
{
  Information("Hello AppVeyor!");
});

RunTarget(target);