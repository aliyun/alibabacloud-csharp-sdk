// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyModelApiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxxxx</para>
        /// </summary>
        [NameInMap("ModelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ModelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordInput")]
        [Validation(Required=false)]
        public string RecordInput { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordOutput")]
        [Validation(Required=false)]
        public string RecordOutput { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
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
