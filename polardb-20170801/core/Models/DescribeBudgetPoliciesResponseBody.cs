// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of budget policies.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeBudgetPoliciesResponseBodyItems> Items { get; set; }
        public class DescribeBudgetPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The alert threshold percentage. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AlertThresholdPct")]
            [Validation(Required=false)]
            public string AlertThresholdPct { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert threshold has been triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AlertTriggered")]
            [Validation(Required=false)]
            public bool? AlertTriggered { get; set; }

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
            /// <para>The budget points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("BudgetPoints")]
            [Validation(Required=false)]
            public string BudgetPoints { get; set; }

            /// <summary>
            /// <para>The budget policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>023aacc1effc4b56bb154bfbec6ba9**</para>
            /// </summary>
            [NameInMap("BudgetPolicyId")]
            [Validation(Required=false)]
            public string BudgetPolicyId { get; set; }

            /// <summary>
            /// <para>The budget type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GlobalTotal</b>: global total budget</description></item>
            /// <item><description><b>ConsumerTotal</b>: total budget for a user</description></item>
            /// <item><description><b>ConsumerGroupTotal</b>: total budget for a user group</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GlobalTotal</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            /// <summary>
            /// <para>Indicates whether the quota has been exceeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exceeded")]
            [Validation(Required=false)]
            public string Exceeded { get; set; }

            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-19T14:13:53+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the policy was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-08T10:43:28+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The gateway instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The day of the month on which the budget resets. Valid values: 1 to 28.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResetDayOfMonth")]
            [Validation(Required=false)]
            public string ResetDayOfMonth { get; set; }

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

            /// <summary>
            /// <para>The number of used points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedPoints")]
            [Validation(Required=false)]
            public int? UsedPoints { get; set; }

        }

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
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
