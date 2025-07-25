using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using System.Net;

namespace VanillaAnimalsExpandedEndangered
{

    [DefOf]
    public static class InternalDefOf
    {
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }
     
        public static JobDef AEXP_IngestAnts;
        public static JobDef AEXP_GotoTheWild;

        public static FactionDef OutlanderCivil;
        public static FactionDef OutlanderRough;
		public static FactionDef TribeCivil;
        public static FactionDef TribeRough;

    }
}