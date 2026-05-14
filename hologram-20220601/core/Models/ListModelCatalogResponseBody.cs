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

        [NameInMap("modelList")]
        [Validation(Required=false)]
        public List<ListModelCatalogResponseBodyModelList> ModelList { get; set; }
        public class ListModelCatalogResponseBodyModelList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;timeout&quot;: 600, &quot;max_retries&quot;: 10, &quot;max_retry_delay&quot;: 8, &quot;initial_retry_delay&quot;: 0.5}</para>
            /// </summary>
            [NameInMap("defaultParams")]
            [Validation(Required=false)]
            public string DefaultParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;deepThink\&quot;:false,\&quot;onlineSearch\&quot;:true}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("paramsExample")]
            [Validation(Required=false)]
            public string ParamsExample { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("serviceDeployRegion")]
            [Validation(Required=false)]
            public string ServiceDeployRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chat/completions</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
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
