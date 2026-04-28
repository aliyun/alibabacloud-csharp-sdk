// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetPoliciesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeBudgetPoliciesResponseBodyItems> Items { get; set; }
        public class DescribeBudgetPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AlertThresholdPct")]
            [Validation(Required=false)]
            public string AlertThresholdPct { get; set; }

            [NameInMap("AlertTriggered")]
            [Validation(Required=false)]
            public bool? AlertTriggered { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cg-p3gk2oh55c**</para>
            /// </summary>
            [NameInMap("BudgetDimensionRefId")]
            [Validation(Required=false)]
            public string BudgetDimensionRefId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ConsumerGroup</para>
            /// </summary>
            [NameInMap("BudgetDimensionType")]
            [Validation(Required=false)]
            public string BudgetDimensionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("BudgetPoints")]
            [Validation(Required=false)]
            public string BudgetPoints { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>023aacc1effc4b56bb154bfbec6ba9**</para>
            /// </summary>
            [NameInMap("BudgetPolicyId")]
            [Validation(Required=false)]
            public string BudgetPolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GlobalTotal</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            [NameInMap("Exceeded")]
            [Validation(Required=false)]
            public string Exceeded { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-19T14:13:53+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-08T10:43:28+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResetDayOfMonth")]
            [Validation(Required=false)]
            public string ResetDayOfMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UsedPoints")]
            [Validation(Required=false)]
            public int? UsedPoints { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
