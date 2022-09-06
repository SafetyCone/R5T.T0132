using System;

using R5T.T0143;


namespace R5T.T0132
{
    /// <summary>
    /// Attribute indicating an interface contains functionality (default implementation methods on an interface).
    /// The marker attribute is useful for surveying functionality interfaces and building a catalogue of functionality.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class FunctionalityMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsFunctionality;
        /// <summary>
        /// Allows specifying that an interface is *not* a functionality interface.
        /// This is useful for marking interfaces that end up canonical functionality code file locations, but are not functionality interfaces.
        /// </summary>
        public bool IsFunctionality
        {
            get
            {
                return this.zIsFunctionality;
            }
        }


        public FunctionalityMarkerAttribute(
            bool isFunctionality = true)
        {
            this.zIsFunctionality = isFunctionality;
        }
    }
}
