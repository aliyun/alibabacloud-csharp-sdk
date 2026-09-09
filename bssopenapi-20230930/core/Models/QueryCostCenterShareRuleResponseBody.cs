// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterShareRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCostCenterShareRuleResponseBodyData> Data { get; set; }
        public class QueryCostCenterShareRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rule information of the source financial unit.</para>
            /// </summary>
            [NameInMap("FromCostCenterShareRuleDetails")]
            [Validation(Required=false)]
            public List<QueryCostCenterShareRuleResponseBodyDataFromCostCenterShareRuleDetails> FromCostCenterShareRuleDetails { get; set; }
            public class QueryCostCenterShareRuleResponseBodyDataFromCostCenterShareRuleDetails : TeaModel {
                /// <summary>
                /// <para>The code of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>970354711219#</para>
                /// </summary>
                [NameInMap("CostCenterCode")]
                [Validation(Required=false)]
                public string CostCenterCode { get; set; }

                /// <summary>
                /// <para>The ID of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>637127</para>
                /// </summary>
                [NameInMap("CostCenterId")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The name of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cost Plan</para>
                /// </summary>
                [NameInMap("CostCenterName")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16 13:49:59</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16 13:49:59</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the financial unit belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1529600453335198</para>
                /// </summary>
                [NameInMap("OwnerAccountId")]
                [Validation(Required=false)]
                public long? OwnerAccountId { get; set; }

                /// <summary>
                /// <para>The ID of the parent financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>637537</para>
                /// </summary>
                [NameInMap("ParentCostCenterId")]
                [Validation(Required=false)]
                public long? ParentCostCenterId { get; set; }

                /// <summary>
                /// <para>The ID of the preceding financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>583059</para>
                /// </summary>
                [NameInMap("PrevCostCenterId")]
                [Validation(Required=false)]
                public long? PrevCostCenterId { get; set; }

                /// <summary>
                /// <para>The ID of the root financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>583050</para>
                /// </summary>
                [NameInMap("RootCostCenterId")]
                [Validation(Required=false)]
                public long? RootCostCenterId { get; set; }

            }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the user to whom the financial unit belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1529600453335198</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>The ID of the cost allocation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1826</para>
            /// </summary>
            [NameInMap("ShareRuleId")]
            [Validation(Required=false)]
            public long? ShareRuleId { get; set; }

            /// <summary>
            /// <para>The name of the cost allocation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>The type of the cost allocation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVERAGE</para>
            /// </summary>
            [NameInMap("ShareRuleType")]
            [Validation(Required=false)]
            public string ShareRuleType { get; set; }

            /// <summary>
            /// <para>The rule information of the destination financial unit.</para>
            /// </summary>
            [NameInMap("ToCostCenterShareRuleDetails")]
            [Validation(Required=false)]
            public List<QueryCostCenterShareRuleResponseBodyDataToCostCenterShareRuleDetails> ToCostCenterShareRuleDetails { get; set; }
            public class QueryCostCenterShareRuleResponseBodyDataToCostCenterShareRuleDetails : TeaModel {
                /// <summary>
                /// <para>The code of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>970354711215#</para>
                /// </summary>
                [NameInMap("CostCenterCode")]
                [Validation(Required=false)]
                public string CostCenterCode { get; set; }

                /// <summary>
                /// <para>The ID of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>637127</para>
                /// </summary>
                [NameInMap("CostCenterId")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The name of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cost Allocation</para>
                /// </summary>
                [NameInMap("CostCenterName")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16 13:49:59</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16 13:49:59</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the financial unit belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1529600453335198</para>
                /// </summary>
                [NameInMap("OwnerAccountId")]
                [Validation(Required=false)]
                public long? OwnerAccountId { get; set; }

                /// <summary>
                /// <para>The ID of the parent financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>637537</para>
                /// </summary>
                [NameInMap("ParentCostCenterId")]
                [Validation(Required=false)]
                public long? ParentCostCenterId { get; set; }

                /// <summary>
                /// <para>The ID of the preceding financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>583055</para>
                /// </summary>
                [NameInMap("PrevCostCenterId")]
                [Validation(Required=false)]
                public long? PrevCostCenterId { get; set; }

                /// <summary>
                /// <para>The ID of the root financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>583050</para>
                /// </summary>
                [NameInMap("RootCostCenterId")]
                [Validation(Required=false)]
                public long? RootCostCenterId { get; set; }

                /// <summary>
                /// <para>The cost allocation ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ShareRatio")]
                [Validation(Required=false)]
                public double? ShareRatio { get; set; }

            }

        }

        /// <summary>
        /// <para>A reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response struct metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>A reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6NH0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
