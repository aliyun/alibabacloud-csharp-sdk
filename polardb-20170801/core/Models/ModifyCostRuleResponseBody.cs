// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyCostRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of model API IDs affected by the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ma-2ze3x6i1d7g5rto28&quot;]</para>
        /// </summary>
        [NameInMap("AffectedModelApiIds")]
        [Validation(Required=false)]
        public List<string> AffectedModelApiIds { get; set; }

        /// <summary>
        /// <para>The cache read cost points per million tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
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
        /// <para>The cost rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>924d450014e64e88ac6e8486f8e990**</para>
        /// </summary>
        [NameInMap("CostRuleId")]
        [Validation(Required=false)]
        public string CostRuleId { get; set; }

        /// <summary>
        /// <para>The effective end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The effective start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The effective target type. Valid values: global, consumerGroup, and consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("EffectiveTargetType")]
        [Validation(Required=false)]
        public string EffectiveTargetType { get; set; }

        /// <summary>
        /// <para>The effective target value. This parameter has a value when the effective target type is not global.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxx</para>
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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the gateway cluster to which the cost rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-2ze3x6i1d7g5rto28</para>
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
        /// <para>The input cost points per million tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("InputCostPointsPerMillion")]
        [Validation(Required=false)]
        public string InputCostPointsPerMillion { get; set; }

        /// <summary>
        /// <para>The input token tier. An empty value indicates the default tier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0-32K</para>
        /// </summary>
        [NameInMap("InputTokenTier")]
        [Validation(Required=false)]
        public string InputTokenTier { get; set; }

        /// <summary>
        /// <para>The tiered pricing for input tokens (priced by tier, non-cumulative). Each element contains Tier and InputCostPointsPerMillion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Tier&quot;:&quot;0-32K&quot;,&quot;InputCostPointsPerMillion&quot;:&quot;1000&quot;}]</para>
        /// </summary>
        [NameInMap("InputTokenTiers")]
        [Validation(Required=false)]
        public List<ModifyCostRuleResponseBodyInputTokenTiers> InputTokenTiers { get; set; }
        public class ModifyCostRuleResponseBodyInputTokenTiers : TeaModel {
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
        /// <para>The name of the pricing model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-2ze3x6i1d7g5rto28</para>
        /// </summary>
        [NameInMap("ModelServiceId")]
        [Validation(Required=false)]
        public string ModelServiceId { get; set; }

        /// <summary>
        /// <para>The model service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-service-a</para>
        /// </summary>
        [NameInMap("ModelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

        /// <summary>
        /// <para>The output cost points per million tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("OutputCostPointsPerMillion")]
        [Validation(Required=false)]
        public string OutputCostPointsPerMillion { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
