// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a budget alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlertTriggered")]
        [Validation(Required=false)]
        public string AlertTriggered { get; set; }

        /// <summary>
        /// <para>The dimension reference ID of the current budget.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ref-001</para>
        /// </summary>
        [NameInMap("DimensionRefId")]
        [Validation(Required=false)]
        public string DimensionRefId { get; set; }

        /// <summary>
        /// <para>The dimension type of the current budget.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        /// <summary>
        /// <para>Indicates whether the budget is exceeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Exceeded")]
        [Validation(Required=false)]
        public string Exceeded { get; set; }

        /// <summary>
        /// <para>The creation time of the budget usage record, in RFC 3339 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the budget usage record was last modified, in RFC 3339 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-15T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-123</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The list of associated budget policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeBudgetUsageResponseBodyPolicies> Policies { get; set; }
        public class DescribeBudgetUsageResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The usage percentage that triggers a budget alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("AlertThresholdPct")]
            [Validation(Required=false)]
            public string AlertThresholdPct { get; set; }

            /// <summary>
            /// <para>The reference ID of the budget dimension to which the policy applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ref-001</para>
            /// </summary>
            [NameInMap("BudgetDimensionRefId")]
            [Validation(Required=false)]
            public string BudgetDimensionRefId { get; set; }

            /// <summary>
            /// <para>The budget dimension type to which the policy applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("BudgetDimensionType")]
            [Validation(Required=false)]
            public string BudgetDimensionType { get; set; }

            /// <summary>
            /// <para>The number of budget points configured in the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("BudgetPoints")]
            [Validation(Required=false)]
            public string BudgetPoints { get; set; }

            /// <summary>
            /// <para>The ID of the budget policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bp-001</para>
            /// </summary>
            [NameInMap("BudgetPolicyId")]
            [Validation(Required=false)]
            public string BudgetPolicyId { get; set; }

            /// <summary>
            /// <para>The budget type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            /// <summary>
            /// <para>The day of the month on which the budget is reset. For example, 1 indicates the first day of each month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResetDayOfMonth")]
            [Validation(Required=false)]
            public string ResetDayOfMonth { get; set; }

            /// <summary>
            /// <para>The status of the budget policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of budget points used in the current statistical window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("UsedPoints")]
        [Validation(Required=false)]
        public string UsedPoints { get; set; }

        /// <summary>
        /// <para>The end time of the budget statistical window, in RFC 3339 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("WindowEndTime")]
        [Validation(Required=false)]
        public string WindowEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the budget statistical window, in RFC 3339 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("WindowStartTime")]
        [Validation(Required=false)]
        public string WindowStartTime { get; set; }

    }

}
