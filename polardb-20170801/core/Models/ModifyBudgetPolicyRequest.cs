// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBudgetPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AlertThresholdPct")]
        [Validation(Required=false)]
        public string AlertThresholdPct { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("BudgetPoints")]
        [Validation(Required=false)]
        public string BudgetPoints { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>023aacc1effc4b56bb154bfbec6ba9**</para>
        /// </summary>
        [NameInMap("BudgetPolicyId")]
        [Validation(Required=false)]
        public string BudgetPolicyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResetDayOfMonth")]
        [Validation(Required=false)]
        public string ResetDayOfMonth { get; set; }

    }

}
