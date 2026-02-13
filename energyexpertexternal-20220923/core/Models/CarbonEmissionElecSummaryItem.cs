// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class CarbonEmissionElecSummaryItem : TeaModel {
        /// <summary>
        /// <para>Carbon Equivalent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.22</para>
        /// </summary>
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        /// <summary>
        /// <para>The price unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kg</para>
        /// </summary>
        [NameInMap("dataUnit")]
        [Validation(Required=false)]
        public string DataUnit { get; set; }

        /// <summary>
        /// <para>The enterprise name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The percentage of electricity consumption. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.22</para>
        /// </summary>
        [NameInMap("ratio")]
        [Validation(Required=false)]
        public double? Ratio { get; set; }

        /// <summary>
        /// <para>Electricity consumption in Kwh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("rawData")]
        [Validation(Required=false)]
        public double? RawData { get; set; }

    }

}
