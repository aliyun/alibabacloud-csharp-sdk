// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListModelCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>maxResults</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of models.</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public List<ListModelCatalogResponseBodyModelList> ModelList { get; set; }
        public class ListModelCatalogResponseBodyModelList : TeaModel {
            /// <summary>
            /// <para>The default parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;timeout&quot;: 600, &quot;max_retries&quot;: 10, &quot;max_retry_delay&quot;: 8, &quot;initial_retry_delay&quot;: 0.5}</para>
            /// </summary>
            [NameInMap("defaultParams")]
            [Validation(Required=false)]
            public string DefaultParams { get; set; }

            /// <summary>
            /// <para>The additional parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;deepThink\&quot;:false,\&quot;onlineSearch\&quot;:true}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The parameter example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;extra_body&quot;: {
            ///         &quot;translation_options&quot;: {
            ///             &quot;source_lang&quot;: &quot;zh&quot;,
            ///             &quot;domains&quot;: &quot;The sentence is from Ali Cloud IT domain. &quot;, 
            ///             &quot;terms&quot;: [
            ///                 {
            ///                     &quot;source&quot;: &quot;生物传感器&quot;,
            ///                     &quot;target&quot;: &quot;biological sensor&quot;
            ///                 },
            ///                 {
            ///                     &quot;source&quot;: &quot;身体健康状况&quot;,
            ///                     &quot;target&quot;: &quot;health status of the body&quot;
            ///                 }
            ///             ],
            ///             &quot;tm_list&quot;: [
            ///                 {
            ///                     &quot;source&quot;: &quot;您可以通过如下方式查看集群的内核版本信息:&quot;,
            ///                     &quot;target&quot;: &quot;You can use one of the following methods to query the engine version of a cluster:&quot;
            ///                 }
            ///             ]
            ///         }
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("paramsExample")]
            [Validation(Required=false)]
            public string ParamsExample { get; set; }

            /// <summary>
            /// <para>The underlying model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The deployment region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("serviceDeployRegion")]
            [Validation(Required=false)]
            public string ServiceDeployRegion { get; set; }

            [NameInMap("supportApiKeyAccess")]
            [Validation(Required=false)]
            public bool? SupportApiKeyAccess { get; set; }

            /// <summary>
            /// <para>The model purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat/completions</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of NextToken that is returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
