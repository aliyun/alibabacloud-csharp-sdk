// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEmissionSummaryRequest : TeaModel {
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
        /// <para>Year of inventory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024</para>
        /// </summary>
        [NameInMap("year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
