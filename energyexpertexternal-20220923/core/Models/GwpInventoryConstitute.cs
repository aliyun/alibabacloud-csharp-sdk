// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GwpInventoryConstitute : TeaModel {
        /// <summary>
        /// <para>Grouped by inventory resource type, this data reveals emissions details for each category. It serves the &quot;By type&quot; analysis in the composition breakdown. A nested structure is employed: total carbon emissions are organized first by inventory type, forming a two-level hierarchy, with the innermost level \&quot;byResource\&quot; currently empty.</para>
        /// </summary>
        [NameInMap("byResourceType")]
        [Validation(Required=false)]
        public List<GwpResourceConstitute> ByResourceType { get; set; }

        /// <summary>
        /// <para>Emission quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1009.976265540000000000000000000000</para>
        /// </summary>
        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        /// <summary>
        /// <para>Organized hierarchically, it cascades from high to low: flow-&gt; process-&gt; inventory level. Employed for &quot;By inventory&quot; analysis in compositional breakdowns, the innermost layer of this nested structure is empty.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GwpInventoryConstitute> Items { get; set; }

        /// <summary>
        /// <para>Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>Acquisition of Raw Materials</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Percentage of emissions, for example 100.00 means 100.00%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("percent")]
        [Validation(Required=false)]
        public double? Percent { get; set; }

        /// <summary>
        /// <para>Resouce type of inventory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>Unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>kgCO₂e/kg</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
