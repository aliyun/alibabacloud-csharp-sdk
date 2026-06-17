// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeModelApisResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of Model API objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeModelApisResponseBodyItems> Items { get; set; }
        public class DescribeModelApisResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The model category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>text</b></para>
            /// </description></item>
            /// <item><description><para><b>embedding</b></para>
            /// </description></item>
            /// <item><description><para><b>rerank</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

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
            /// <para>The Model API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mi-xxxx</para>
            /// </summary>
            [NameInMap("ModelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

            /// <summary>
            /// <para>The Model API name.</para>
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
            /// <item><description><para><b>openai</b></para>
            /// </description></item>
            /// <item><description><para><b>anthropic</b></para>
            /// </description></item>
            /// <item><description><para><b>bailian</b></para>
            /// </description></item>
            /// <item><description><para><b>vllm</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>openai</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The number of input records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordInput")]
            [Validation(Required=false)]
            public string RecordInput { get; set; }

            /// <summary>
            /// <para>The number of output records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public string RecordOutput { get; set; }

            /// <summary>
            /// <para>A JSON array of routing rules, formatted as a string.</para>
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
            /// <para>The Model API status.</para>
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
        /// <para>The number of records returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61892A4-0850-4516-9E26-44D96C1782DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
