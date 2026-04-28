// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateBudgetPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AlertThresholdPct")]
        [Validation(Required=false)]
        public string AlertThresholdPct { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mi-xxxxx</para>
        /// </summary>
        [NameInMap("BudgetDimensionRefId")]
        [Validation(Required=false)]
        public string BudgetDimensionRefId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BudgetPoints")]
        [Validation(Required=false)]
        public string BudgetPoints { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConsumerTotal</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResetDayOfMonth")]
        [Validation(Required=false)]
        public string ResetDayOfMonth { get; set; }

    }

}
