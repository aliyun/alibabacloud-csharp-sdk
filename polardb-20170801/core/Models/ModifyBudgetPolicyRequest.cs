// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBudgetPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The budget usage percentage that triggers an alert. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AlertThresholdPct")]
        [Validation(Required=false)]
        public string AlertThresholdPct { get; set; }

        /// <summary>
        /// <para>The budget amount in points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("BudgetPoints")]
        [Validation(Required=false)]
        public string BudgetPoints { get; set; }

        /// <summary>
        /// <para>The ID of the budget policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>023aacc1effc4b56bb154bfbec6ba9**</para>
        /// </summary>
        [NameInMap("BudgetPolicyId")]
        [Validation(Required=false)]
        public string BudgetPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The day of the month when the budget is reset. Valid values: 1 to 28.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResetDayOfMonth")]
        [Validation(Required=false)]
        public string ResetDayOfMonth { get; set; }

    }

}
