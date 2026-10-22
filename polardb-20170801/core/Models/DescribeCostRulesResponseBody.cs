// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCostRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cost rules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCostRulesResponseBodyItems> Items { get; set; }
        public class DescribeCostRulesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The cache read cost points per million tokens. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CacheCostPointsPerMillion")]
            [Validation(Required=false)]
            public string CacheCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The cache creation cost points per million tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("CacheCreationCostPointsPerMillion")]
            [Validation(Required=false)]
            public string CacheCreationCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The ID of the cost rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>924d450014e64e88ac6e8486f8e990**</para>
            /// </summary>
            [NameInMap("CostRuleId")]
            [Validation(Required=false)]
            public string CostRuleId { get; set; }

            /// <summary>
            /// <para>The end time of the effective period. The time is displayed in UTC in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public string EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the effective period. The time is displayed in UTC in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public string EffectiveStartTime { get; set; }

            /// <summary>
            /// <para>The type of the effective target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("EffectiveTargetType")]
            [Validation(Required=false)]
            public string EffectiveTargetType { get; set; }

            /// <summary>
            /// <para>The value of the effective target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("EffectiveTargetValue")]
            [Validation(Required=false)]
            public string EffectiveTargetValue { get; set; }

            /// <summary>
            /// <para>The explicit cache read cost points per million tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ExplicitCacheCostPointsPerMillion")]
            [Validation(Required=false)]
            public string ExplicitCacheCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The time when the cost rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-04T16:09:29+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the cost rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The gateway instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The image input cost points per image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ImageCostPointsPerCount")]
            [Validation(Required=false)]
            public string ImageCostPointsPerCount { get; set; }

            /// <summary>
            /// <para>The input cost points per million tokens. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InputCostPointsPerMillion")]
            [Validation(Required=false)]
            public string InputCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The input token tier. An empty value indicates a legacy or default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-32K</para>
            /// </summary>
            [NameInMap("InputTokenTier")]
            [Validation(Required=false)]
            public string InputTokenTier { get; set; }

            /// <summary>
            /// <para>The non-cumulative tiered pricing for input tokens. Each element contains Tier and InputCostPointsPerMillion.</para>
            /// </summary>
            [NameInMap("InputTokenTiers")]
            [Validation(Required=false)]
            public List<DescribeCostRulesResponseBodyItemsInputTokenTiers> InputTokenTiers { get; set; }
            public class DescribeCostRulesResponseBodyItemsInputTokenTiers : TeaModel {
                /// <summary>
                /// <para>The input cost points per million tokens for the tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("InputCostPointsPerMillion")]
                [Validation(Required=false)]
                public string InputCostPointsPerMillion { get; set; }

                /// <summary>
                /// <para>The token tier. Valid values: &quot;&quot; (default tier), 0-32K, 32K-64K, 64K-128K, 128K-256K, 256K-512K, 512K-1M, and 1M+.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0-32K</para>
                /// </summary>
                [NameInMap("Tier")]
                [Validation(Required=false)]
                public string Tier { get; set; }

            }

            /// <summary>
            /// <para>The name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gpt-4</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The ID of the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ms-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ModelServiceId")]
            [Validation(Required=false)]
            public string ModelServiceId { get; set; }

            /// <summary>
            /// <para>The model service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-service</para>
            /// </summary>
            [NameInMap("ModelServiceName")]
            [Validation(Required=false)]
            public string ModelServiceName { get; set; }

            /// <summary>
            /// <para>The output cost points per million tokens. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutputCostPointsPerMillion")]
            [Validation(Required=false)]
            public string OutputCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The video input cost points per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoCostPointsPerSecond")]
            [Validation(Required=false)]
            public string VideoCostPointsPerSecond { get; set; }

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
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 30, 50, and 100. Default value: 30.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
