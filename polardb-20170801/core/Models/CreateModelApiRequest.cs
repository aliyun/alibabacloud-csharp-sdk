// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The gateway retry configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;failover&quot;: {
        ///         &quot;enabled&quot;: true,
        ///         &quot;max_provider_retries&quot;: 2,
        ///         &quot;max_failover_providers&quot;: 1,
        ///         &quot;retryable_status_codes&quot;: [429, 500, 502, 503, 504],
        ///         &quot;retry_delay&quot;: 0.5
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The forced model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ForceModel")]
        [Validation(Required=false)]
        public string ForceModel { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance. You can obtain this ID from the GwClusterId value returned by the CreateGateway operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>text</b></description></item>
        /// <item><description><b>embedding</b></description></item>
        /// <item><description><b>rerank</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ModelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The model name mappings, specified as a JSON array string. Each element is in the format of {&quot;Source&quot;:&quot;client model name&quot;,&quot;Target&quot;:&quot;upstream model name&quot;}. The Source parameter is matched in a case-insensitive manner and must be unique. The Target parameter retains its original case when forwarded. Both parameters cannot be empty and cannot contain leading or trailing spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;client-model-a&quot;,&quot;Target&quot;:&quot;upstream-model-a&quot;},{&quot;Source&quot;:&quot;client-model-b&quot;,&quot;Target&quot;:&quot;upstream-model-b&quot;}]</para>
        /// </summary>
        [NameInMap("ModelMappings")]
        [Validation(Required=false)]
        public string ModelMappings { get; set; }

        /// <summary>
        /// <para>The intelligent routing candidate list, specified as a JSON object string. Currently, it only contains AllowedModels, which is a non-empty array of unique model names. The order of the array determines the candidate order. Do not pass the Enabled, cost, or quality tier parameters. Saving candidates does not enable the feature. You must first call the EnableModelRouting operation to obtain the gateway entitlements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AllowedModels&quot;:[&quot;deepseek-v4-pro&quot;,&quot;glm-5.3&quot;,&quot;glm-5.3-flash&quot;]}</para>
        /// </summary>
        [NameInMap("ModelRouting")]
        [Validation(Required=false)]
        public string ModelRouting { get; set; }

        /// <summary>
        /// <para>The name of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The API path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>openai</b></description></item>
        /// <item><description><b>anthropic</b></description></item>
        /// <item><description><b>bailian</b></description></item>
        /// <item><description><b>vllm</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The number of input points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordInput")]
        [Validation(Required=false)]
        public string RecordInput { get; set; }

        /// <summary>
        /// <para>The number of output points.</para>
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
        /// <para>The list of routing rules, specified as a JSON array string.</para>
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
