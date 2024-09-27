// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetCarbonEmissionTrendRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C-20240119-1</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Module code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>carbonInventory.check.scope_1_direct_ghg_emissions</para>
        /// </summary>
        [NameInMap("moduleCode")]
        [Validation(Required=false)]
        public string ModuleCode { get; set; }

        /// <summary>
        /// <para>Module type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("moduleType")]
        [Validation(Required=false)]
        public int? ModuleType { get; set; }

        /// <summary>
        /// <para>Trend Type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("trendType")]
        [Validation(Required=false)]
        public int? TrendType { get; set; }

        /// <summary>
        /// <para>The list of inventory year.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("yearList")]
        [Validation(Required=false)]
        public List<int?> YearList { get; set; }

    }

}
