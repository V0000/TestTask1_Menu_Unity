using UnityEngine;

public static class DataHolder
{
    private static Color _bgColor = Color.yellow;
    public static Color BgColor
    {
        get => _bgColor;
        set
        {
            _bgColor = value;
        }
    }

}
