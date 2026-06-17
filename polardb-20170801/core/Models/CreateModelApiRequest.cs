// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The model to which requests are forcibly routed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ForceModel")]
        [Validation(Required=false)]
        public string ForceModel { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The model API category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>text</b></para>
        /// </description></item>
        /// <item><description><para><b>embedding</b></para>
        /// </description></item>
        /// <item><description><para><b>rerank</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ModelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The model API name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The path prefix.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>The model API protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OpenAI</b></para>
        /// </description></item>
        /// <item><description><para><b>Anthropic</b></para>
        /// </description></item>
        /// <item><description><para><b>Model Studio</b></para>
        /// </description></item>
        /// <item><description><para><b>vLLM</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>Specifies whether to record input for billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordInput")]
        [Validation(Required=false)]
        public string RecordInput { get; set; }

        /// <summary>
        /// <para>Specifies whether to record output for billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordOutput")]
        [Validation(Required=false)]
        public string RecordOutput { get; set; }

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
        /// <para>A list of routing rules, provided as a JSON array string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;RuleName&quot;: &quot;string&quot;,
        ///     &quot;FallbackMode&quot;: &quot;failover&quot;,
        ///     &quot;MatchModelListJson&quot;: &quot;[]&quot;,
        ///     &quot;providerBalancerAlgorithm&quot;: &quot;round-robin&quot;,
        ///     &quot;Providers&quot;: [
        ///       {
        ///         &quot;ModelServiceName&quot;: &quot;string&quot;,
        ///         &quot;Weight&quot;: &quot;0&quot;,
        ///         &quot;model_protocol&quot;: &quot;vllm&quot;
        ///         &quot;ModelList&quot;: &quot;[]&quot;
        ///       }
        ///     ],
        ///     &quot;FallbackProviders&quot;: [
        ///       {
        ///         &quot;ModelServiceName&quot;: &quot;string&quot;,
        ///         &quot;model_protocol&quot;: &quot;anthropic&quot;,
        ///         &quot;Weight&quot;: &quot;10&quot;,
        ///         &quot;ModelList&quot;: &quot;[]&quot;
        ///       }
        ///     ]
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("RouteRules")]
        [Validation(Required=false)]
        public string RouteRules { get; set; }

    }

}
