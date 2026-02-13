// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GwpResourceConstitute : TeaModel {
        /// <summary>
        /// <para>The carbon emissions. To ensure accuracy, retain 24 decimal places. We recommend that you intercept the carbon emissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1009.976265540000000000000000000000</para>
        /// </summary>
        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        /// <summary>
        /// <para>Name signifies a concept with distinct layers of meaning, where the outermost layer represents the overall carbon emissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Energy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Percentage of emissions. 98.76 indicates the proportion of 98.76%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98.76</para>
        /// </summary>
        [NameInMap("percent")]
        [Validation(Required=false)]
        public string Percent { get; set; }

        /// <summary>
        /// <para>The type of the inventory. It is meaningful at the inventory layer and can be empty at other layers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>unit of emissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kgCO₂e/Piece(s)</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
