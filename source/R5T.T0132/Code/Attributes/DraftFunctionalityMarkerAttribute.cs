using System;

using R5T.T0143;


namespace R5T.T0132
{
    /// <summary>
    /// Attribute indicating an interface contains draft functionality (functionality is encapsulated in default methods on an interface, draft functionality is quickly created functionality that should be reviewed and relocated, and thus become functionality).
    /// The marker attribute is useful for surveying for draft functionality interfaces and building a catalogue of draft functionality as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftFunctionalityMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsDraftFunctionality;
        /// <summary>
        /// Allows specifying that an interface is *not* a functionality interface.
        /// This is useful for marking interfaces that end up canonical functionality code file locations, but are not functionality interfaces.
        /// </summary>
        public bool IsDraftFunctionality
        {
            get
            {
                return this.zIsDraftFunctionality;
            }
        }


        public DraftFunctionalityMarkerAttribute(
            bool isDraftFunctionality = true)
        {
            this.zIsDraftFunctionality = isDraftFunctionality;
        }
    }
}
