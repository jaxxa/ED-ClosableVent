using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using UnityEngine;

namespace EnhancedDevelopment.ClosableVent
{
    public class Building_Vent_ClosableVent : RimWorld.Building_Vent
    {
        public override void SpawnSetup(Map map)
        {
            base.SpawnSetup(map);
        }

        private CompFlickable FlickComp
        {
            get
            {
                if (this.m_FlickComp == null)
                {
                    this.m_FlickComp = this.GetComp<CompFlickable>();
                }
                return this.m_FlickComp;
            }
        }
        private CompFlickable m_FlickComp;
        
        public override void TickRare()
        {
            if (this.FlickComp.SwitchIsOn)
            {
                base.TickRare();
            }
        }

        public override string GetInspectString()
        {
            StringBuilder stringBuilder = new StringBuilder();


            if (this.FlickComp.SwitchIsOn)
            {
                stringBuilder.Append(base.GetInspectString());
            }
            else
            {
                stringBuilder.AppendLine("Vent Closed");
            }

            return stringBuilder.ToString();
        }

    }

}

