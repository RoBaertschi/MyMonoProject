using Godot;

public static class Logging
{
    public static void log(string text, string name) {
        GD.Print("[LOG] [", name,"]: ",text);
    }
    public static void log(string text) {
        log(text, "MyMonoProject");
    }

    public static void info(string text, string name) {
        GD.Print("[INFO] [", name,"]: ",text);
    }
    public static void info(string text) {
        info(text, "MyMonoProject");
    }
}
    
