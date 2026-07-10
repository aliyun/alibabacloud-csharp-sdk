// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The dimension object ID. This parameter is required when BudgetDimensionType is set to ConsumerGroup or Consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-p3gk2oh55c**</para>
        /// </summary>
        [NameInMap("BudgetDimensionRefId")]
        [Validation(Required=false)]
        public string BudgetDimensionRefId { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ConsumerGroup</b>: total budget for a user group</description></item>
        /// <item><description><b>Consumer</b>: total budget for a user</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ConsumerGroup</para>
        /// </summary>
        [NameInMap("BudgetDimensionType")]
        [Validation(Required=false)]
        public string BudgetDimensionType { get; set; }

        /// <summary>
        /// <para>The budget policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>023aacc1effc4b56bb154bfbec6baxxx</para>
        /// </summary>
        [NameInMap("BudgetPolicyId")]
        [Validation(Required=false)]
        public string BudgetPolicyId { get; set; }

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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScopeRefName")]
        [Validation(Required=false)]
        public string ScopeRefName { get; set; }

        /// <summary>
        /// <para>The policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled</description></item>
        /// <item><description><b>Disenabled</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
