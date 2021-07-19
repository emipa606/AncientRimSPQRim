using RimWorld;
using Verse;

namespace AncientRimCompOverlays
{
    public class CompOverlays : ThingComp
    {
        public CompProperties_Overlays Props => props as CompProperties_Overlays;

        public override void PostDraw()
        {
            base.PostDraw();
            if (Props.fuelRequired &&
                (parent.GetComp<CompRefuelable>() is not { } rf || !rf.HasFuel))
            {
                return;
            }

            var drawPos = parent.DrawPos;
            drawPos.y += 0.046875f;
            foreach (var o in Props.overlays)
            {
                var vec3 = drawPos + o.offset;
                if (o.usesStuff)
                {
                    o.graphicData.GraphicColoredFor(parent).Draw(vec3, parent.Rotation, parent);
                    continue;
                }

                o.graphicData.Graphic.Draw(vec3, parent.Rotation, parent);
            }
        }
    }
}