public interface IWeapon
{
    string Name { get; }
    string Manufacturer { get; }
}

public interface IShootable
{
    int Bullets { get; set; }
    void Shoot();
}


public interface IBreakable
{
    string Status { get; set; } // "שלמה" או "שבורה"
    int MaxHits { get; }        // כמות מכות עד שהיא נשברת
    int CurrentHits { get; set; } // כמה מכות עד עכשיו
    void Hit();
}



