// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeModelApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of model APIs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeModelApisResponseBodyItems> Items { get; set; }
        public class DescribeModelApisResponseBodyItems : TeaModel {
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
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The gateway retry configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;failover&quot;:{&quot;enabled&quot;:true,&quot;max_provider_retries&quot;:2,&quot;max_failover_providers&quot;:1,&quot;retryable_status_codes&quot;:[429,500,502,503,504],&quot;retry_delay&quot;:0.5}}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The ID of the gateway instance to which the model API belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-2ze3x6i1d7g5rto28</para>
            /// </summary>
            [NameInMap("CustinsName")]
            [Validation(Required=false)]
            public string CustinsName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time of the model API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-09T06:43:33Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The model API IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mi-xxxx</para>
            /// </summary>
            [NameInMap("ModelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

            /// <summary>
            /// <para>The model name mappings, which is a JSON array string. Each element is in the format of {&quot;Source&quot;:&quot;client model name&quot;,&quot;Target&quot;:&quot;upstream model name&quot;}. If not configured, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Source&quot;:&quot;client-model-a&quot;,&quot;Target&quot;:&quot;upstream-model-a&quot;}]</para>
            /// </summary>
            [NameInMap("ModelMappings")]
            [Validation(Required=false)]
            public string ModelMappings { get; set; }

            /// <summary>
            /// <para>The intelligent routing candidate list, which is a JSON object string in the format of {&quot;AllowedModels&quot;:[&quot;candidate model name&quot;]}. If not configured, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AllowedModels&quot;:[&quot;deepseek-v4-pro&quot;,&quot;glm-5.3&quot;,&quot;glm-5.3-flash&quot;]}</para>
            /// </summary>
            [NameInMap("ModelRouting")]
            [Validation(Required=false)]
            public string ModelRouting { get; set; }

            /// <summary>
            /// <para>The model API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The API path prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tests/models/</para>
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
            /// <para>The list of routing rules, which is a JSON array string.</para>
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

            /// <summary>
            /// <para>The model API status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
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
        /// <para>C61892A4-0850-4516-9E26-44D96C1782DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
