// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of budget policies.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeBudgetPoliciesResponseBodyItems> Items { get; set; }
        public class DescribeBudgetPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The alert threshold, as a percentage (0 to 100).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AlertThresholdPct")]
            [Validation(Required=false)]
            public string AlertThresholdPct { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert threshold was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AlertTriggered")]
            [Validation(Required=false)]
            public bool? AlertTriggered { get; set; }

            /// <summary>
            /// <para>The ID of the dimension object. This parameter is required when <c>BudgetDimensionType</c> is set to <c>ConsumerGroup</c> or <c>Consumer</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-p3gk2oh55c**</para>
            /// </summary>
            [NameInMap("BudgetDimensionRefId")]
            [Validation(Required=false)]
            public string BudgetDimensionRefId { get; set; }

            /// <summary>
            /// <para>The dimension of the budget policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ConsumerGroup</b>: consumer group</para>
            /// </description></item>
            /// <item><description><para><b>Consumer</b>: consumer</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ConsumerGroup</para>
            /// </summary>
            [NameInMap("BudgetDimensionType")]
            [Validation(Required=false)]
            public string BudgetDimensionType { get; set; }

            /// <summary>
            /// <para>The number of budget points.</para>
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
            /// <item><description><para><b>GlobalTotal</b>: Global budget</para>
            /// </description></item>
            /// <item><description><para><b>ConsumerTotal</b>: Consumer budget</para>
            /// </description></item>
            /// <item><description><para><b>ConsumerGroupTotal</b>: Consumer group budget</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GlobalTotal</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            /// <summary>
            /// <para>Indicates whether the budget was exceeded.</para>
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
            /// <para>The gateway cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The day of the month (1 to 28) on which the budget is reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResetDayOfMonth")]
            [Validation(Required=false)]
            public string ResetDayOfMonth { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: disabled</para>
            /// </description></item>
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
        /// <para>The number of records to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
