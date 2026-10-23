// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InitModelRequest : TeaModel {
        /// <summary>
        /// <para>The API key for the AI Search Open Platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os-xfdddf*</para>
        /// </summary>
        [NameInMap("api_key")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The service registration address for the AI Search Open Platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****.platform-cn-hangzhou-vpc.opensearch.aliyuncs.com</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The HTTP protocol type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("http_schema")]
        [Validation(Required=false)]
        public string HttpSchema { get; set; }

        /// <summary>
        /// <para>Specifies the models to initialize. If this parameter is left empty, all built-in models are initialized.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<InitModelRequestModels> Models { get; set; }
        public class InitModelRequestModels : TeaModel {
            /// <summary>
            /// <para>The model type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>text_embedding: Text embedding.</description></item>
            /// <item><description>rerank: Reranking.</description></item>
            /// <item><description>doc_split: Document splitting.</description></item>
            /// <item><description>completion: Large language model service.</description></item>
            /// <item><description>query_analyze: Query analysis. </description></item>
            /// <item><description>doc_analyze: Document content parsing.</description></item>
            /// <item><description>img_analyze: Image content parsing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The service ID for the Search Open Platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops-text-embedding-**</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

        /// <summary>
        /// <para>The workspace.</para>
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
