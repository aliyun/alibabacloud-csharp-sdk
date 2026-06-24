// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InitModelRequest : TeaModel {
        /// <summary>
        /// <para>API key for the AI Search Open Platform</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os-xfdddf*</para>
        /// </summary>
        [NameInMap("api_key")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>Service registration endpoint of the AI Search Open Platform</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****.platform-cn-hangzhou-vpc.opensearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>HTTP protocol type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("http_schema")]
        [Validation(Required=false)]
        public string HttpSchema { get; set; }

        /// <summary>
        /// <para>Specify the models to initialize. If empty, all built-in models will be initialized.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<InitModelRequestModels> Models { get; set; }
        public class InitModelRequestModels : TeaModel {
            /// <summary>
            /// <para>Model category  </para>
            /// <list type="bullet">
            /// <item><description>a. Text embedding: text_embedding  </description></item>
            /// <item><description>b. Reranking: rerank  </description></item>
            /// <item><description>c. Document segmentation: doc_split  </description></item>
            /// <item><description>d. Large Language Model (LLM) service: completion  </description></item>
            /// <item><description>e. Query analysis: query_analyze  </description></item>
            /// <item><description>f. Document content parsing: doc_analyze  </description></item>
            /// <item><description>g. Image content parsing: img_analyze</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Service ID of the Search Open Platform</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops-text-embedding-**</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

        /// <summary>
        /// <para>Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
