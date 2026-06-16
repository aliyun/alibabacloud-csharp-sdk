// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListModelProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListModelProvidersResponseBodyData Data { get; set; }
        public class ListModelProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of model provider objects.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListModelProvidersResponseBodyDataItems> Items { get; set; }
            public class ListModelProvidersResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The base URL of the model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baseUrl</para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>modelInfoConfig</para>
                /// </summary>
                [NameInMap("modelInfoConfig")]
                [Validation(Required=false)]
                public ModelInfoConfig ModelInfoConfig { get; set; }

                /// <summary>
                /// <para>The model type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>text_embedding</c>: text embedding</para>
                /// </description></item>
                /// <item><description><para><c>text_sparse_embedding</c>: text sparse embedding</para>
                /// </description></item>
                /// <item><description><para><c>image_embedding</c>: image embedding</para>
                /// </description></item>
                /// <item><description><para><c>image_analyze</c>: image analysis</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>native</para>
                /// </summary>
                [NameInMap("modelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                /// <summary>
                /// <para>An array of model names.</para>
                /// </summary>
                [NameInMap("models")]
                [Validation(Required=false)]
                public List<string> Models { get; set; }

                /// <summary>
                /// <para>The name of the model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>providerName</para>
                /// </summary>
                [NameInMap("providerName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <para>页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>页面大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>211</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The unique request identifier. Include this ID when reporting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
