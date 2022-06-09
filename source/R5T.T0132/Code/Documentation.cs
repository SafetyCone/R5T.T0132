using System;


namespace R5T.T0132
{
    /// <summary>
    /// <see cref="FunctionalityMarkerAttribute"/> marker attribute for functionality classes.
    /// </summary>
    public static class Documentation
    {
        /// <summary>
        /// Instantiable classes (as opposed to static classes) are good for functionality since they can be instantiated as static instances in the static Instances classes of dependent projects.
        /// </summary>
        public static readonly object InstantiableClassesAreGood;
    }
}