// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InitModelRequest : TeaModel {
        /// <summary>
        /// <para>The API key for the AISearch open platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os-xfdddf*</para>
        /// </summary>
        [NameInMap("api_key")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The service registration address of the AISearch open platform.</para>
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
        /// <para>The models to initialize. If this parameter is left empty, all built-in models are initialized.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<InitModelRequestModels> Models { get; set; }
        public class InitModelRequestModels : TeaModel {
            /// <summary>
            /// <para>The model type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>text_embedding: text embedding</description></item>
            /// <item><description>rerank: reranking</description></item>
            /// <item><description>doc_split: document splitting</description></item>
            /// <item><description>completion: large language model service</description></item>
            /// <item><description>query_analyze: query analysis</description></item>
            /// <item><description>doc_analyze: document content parsing</description></item>
            /// <item><description>img_analyze: image content parsing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The service ID of the AISearch open platform.</para>
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
