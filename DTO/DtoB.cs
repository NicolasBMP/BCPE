using System;
using System.ComponentModel;

namespace DTO
{
    [Serializable]
    public class DtoB : ClassResultV, ICloneable
    {
        [Browsable(false)]
        public string MsjError { get; set; }

        [Browsable(false)]
        public DtoB Error(string msj)
        {
            MsjError = msj;
            return this;
        }

        public string Criterio { get; set; }
        public string Msj { get; set; }

        #region Miembros de ICloneable

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}

public static class Extensions
{
    /// <summary>
    ///     Perform a deep Copy of the object.
    /// </summary>
    /// <typeparam name="T">The type of object being copied.</typeparam>
    /// <param name="item"></param>
    /// <returns>The copied object.</returns>
    public static T Clone<T>(this T item) where T : ICloneable
    {
        return (T)item.Clone();
    }
}
