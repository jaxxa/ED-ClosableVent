using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using UnityEngine;

namespace Enhanced_Development.Temperature
{
    public class Building_ClosableVent : RimWorld.Building_Vent
    {
        public override void SpawnSetup()
        {
            base.SpawnSetup();
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

