// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostByCostCenterResponseBody : TeaModel {
        /// <summary>
        /// <para>Cost center consumption amount details list</para>
        /// </summary>
        [NameInMap("ConsumeAmountList")]
        [Validation(Required=false)]
        public List<QueryCostByCostCenterResponseBodyConsumeAmountList> ConsumeAmountList { get; set; }
        public class QueryCostByCostCenterResponseBodyConsumeAmountList : TeaModel {
            /// <summary>
            /// <para>Shared allocation amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AllocatedAmount")]
            [Validation(Required=false)]
            public string AllocatedAmount { get; set; }

            /// <summary>
            /// <para>Cost center code</para>
            /// 
            /// <b>Example:</b>
            /// <para>15945703968#</para>
            /// </summary>
            [NameInMap("CostCenterCode")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            /// <summary>
            /// <para>Cost center ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>530658</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>Cost center name</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目组A</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>Cost type amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DirectAmount")]
            [Validation(Required=false)]
            public string DirectAmount { get; set; }

            /// <summary>
            /// <para>Level</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// <para>Account ID that owns the resource</para>
            /// 
            /// <b>Example:</b>
            /// <para>1857464601594004</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>Account name that owns the resource</para>
            /// 
            /// <b>Example:</b>
            /// <para>研发团队测试账号</para>
            /// </summary>
            [NameInMap("OwnerAccountName")]
            [Validation(Required=false)]
            public string OwnerAccountName { get; set; }

            /// <summary>
            /// <para>Parent cost center ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>637537</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

            /// <summary>
            /// <para>Previous cost center ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>6375371</para>
            /// </summary>
            [NameInMap("PreCostCenterId")]
            [Validation(Required=false)]
            public long? PreCostCenterId { get; set; }

            /// <summary>
            /// <para>Total (sum of cost type amount and shared allocation amount)</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalAllocatedAmount")]
            [Validation(Required=false)]
            public string TotalAllocatedAmount { get; set; }

            /// <summary>
            /// <para>Cost type amount percentage</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("TotalAllocatedAmountPercent")]
            [Validation(Required=false)]
            public string TotalAllocatedAmountPercent { get; set; }

        }

        /// <summary>
        /// <para>Response structure metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Sum of totalAllocatedAmount across all cost centers</para>
        /// 
        /// <b>Example:</b>
        /// <para>130296.64</para>
        /// </summary>
        [NameInMap("TotalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

    }

}
