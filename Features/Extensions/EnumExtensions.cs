using System;
using System.ComponentModel;

namespace FF4FE.Tracker.Features.Extensions;

public static class EnumExtensions
{
    public static string GetDescription<TEnum>(this TEnum enumMember) where TEnum : Enum
    {
        if (enumMember == null) { return ""; }

        return enumMember.GetType()
                         .GetField(enumMember.ToString())?
                         .GetCustomAttributes(typeof(DescriptionAttribute), false)
                         .SingleOrDefault() is not DescriptionAttribute attribute
                            ? enumMember.ToString()
                            : attribute.Description;
    }
}
