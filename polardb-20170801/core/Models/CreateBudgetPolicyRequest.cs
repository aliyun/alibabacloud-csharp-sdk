// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateBudgetPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The alert threshold percentage (0 to 100).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AlertThresholdPct")]
        [Validation(Required=false)]
        public string AlertThresholdPct { get; set; }

        /// <summary>
        /// <para>The ID of the dimension object. This parameter is required when BudgetType is set to ConsumerGroupTotal or Consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxxxx</para>
        /// </summary>
        [NameInMap("BudgetDimensionRefId")]
        [Validation(Required=false)]
        public string BudgetDimensionRefId { get; set; }

        /// <summary>
        /// <para>The budget points.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BudgetPoints")]
        [Validation(Required=false)]
        public string BudgetPoints { get; set; }

        /// <summary>
        /// <para>The budget type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>GlobalTotal</b>: Global total budget.</description></item>
        /// <item><description><b>ConsumerGroupTotal</b>: Total budget for a consumer group.</description></item>
        /// <item><description><b>ConsumerGroupMemberDefault</b>: Default budget for a consumer group member.</description></item>
        /// <item><description><b>Consumer</b>: Budget for a single consumer.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GlobalTotal</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The day of the month when the budget is reset (1 to 28).</para>
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
