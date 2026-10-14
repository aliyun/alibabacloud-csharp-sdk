// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateCostRuleRequest : TeaModel {
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
        /// <para>The effective start time in the yyyy-MM-dd HH:mm:ss format. If this parameter is not specified, the rule takes effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-14 00:00:00</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The effective target type. Valid values: global, consumerGroup, and consumer. Default value: global.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("EffectiveTargetType")]
        [Validation(Required=false)]
        public string EffectiveTargetType { get; set; }

        /// <summary>
        /// <para>The effective target value. This parameter is required when the effective target type is not global.</para>
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
        /// <para>The tiered price for input tokens (non-cumulative). The value is a JSON array character string. Each element contains Tier and InputCostPointsPerMillion. Valid values for Tier: &quot;&quot; (default tier), 0-32K, 32K-64K, 64K-128K, 128K-256K, 256K-512K, 512K-1M, and 1M+. Example: [{&quot;Tier&quot;:&quot;0-32K&quot;,&quot;InputCostPointsPerMillion&quot;:&quot;1000&quot;},{&quot;Tier&quot;:&quot;32K-64K&quot;,&quot;InputCostPointsPerMillion&quot;:&quot;1800&quot;}]. If this parameter is specified, it takes precedence over InputCostPointsPerMillion. An empty array [] is not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Tier&quot;:&quot;0-32K&quot;,&quot;InputCostPointsPerMillion&quot;:&quot;1000&quot;},{&quot;Tier&quot;:&quot;32K-64K&quot;,&quot;InputCostPointsPerMillion&quot;:&quot;1800&quot;}]</para>
        /// </summary>
        [NameInMap("InputTokenTiers")]
        [Validation(Required=false)]
        public string InputTokenTiers { get; set; }

        /// <summary>
        /// <para>The name of the model, such as gpt-4 or qwen-turbo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpt-4</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The ID of the model service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelServiceId")]
        [Validation(Required=false)]
        public string ModelServiceId { get; set; }

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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
