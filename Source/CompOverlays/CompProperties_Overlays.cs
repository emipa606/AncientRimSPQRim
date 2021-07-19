using System.Collections.Generic;
using Verse;

namespace AncientRimCompOverlays
{
    public class CompProperties_Overlays : CompProperties
    {
        public bool fuelRequired = false;
        public List<GraphicOverlay> overlays = new List<GraphicOverlay>();

        public CompProperties_Overlays()
        {
            compClass = typeof(CompOverlays);
        }
    }
}