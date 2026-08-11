// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38b079f1-7846-4226-8c90-3e2644b5c52b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The model configuration.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetModelResponseBodyResult Result { get; set; }
        public class GetModelResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The model configuration.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public GetModelResponseBodyResultContent Content { get; set; }
            public class GetModelResponseBodyResultContent : TeaModel {
                /// <summary>
                /// <para>The HTTP method to access the model service. PUT and POST are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model type.</para>
                /// <list type="bullet">
                /// <item><description><para>a. Text embedding: text_embedding</para>
                /// </description></item>
                /// <item><description><para>b. Text sparse embedding: text_sparse_embedding</para>
                /// </description></item>
                /// <item><description><para>c. Image embedding: image_embedding</para>
                /// </description></item>
                /// <item><description><para>d. Image content analysis: image_analyze</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text_embedding</para>
                /// </summary>
                [NameInMap("modelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                /// <summary>
                /// <para>The request configuration.</para>
                /// </summary>
                [NameInMap("request")]
                [Validation(Required=false)]
                public GetModelResponseBodyResultContentRequest Request { get; set; }
                public class GetModelResponseBodyResultContentRequest : TeaModel {
                    /// <summary>
                    /// <para>The HTTP request header.</para>
                    /// </summary>
                    [NameInMap("header")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestHeader Header { get; set; }
                    public class GetModelResponseBodyResultContentRequestHeader : TeaModel {
                        /// <summary>
                        /// <para>Authentication information. The format is Bearer access_token.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Bearer OS-v0********6vvs</para>
                        /// </summary>
                        [NameInMap("Authorization")]
                        [Validation(Required=false)]
                        public string Authorization { get; set; }

                        /// <summary>
                        /// <para>The HTTP request\&quot;s content type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/json</para>
                        /// </summary>
                        [NameInMap("Content-Type")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    /// <summary>
                    /// <para>Define parameters here if they differ between the build and search phases.</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestParameters Parameters { get; set; }
                    public class GetModelResponseBodyResultContentRequestParameters : TeaModel {
                        /// <summary>
                        /// <para>Parameters for the index building phase.</para>
                        /// </summary>
                        [NameInMap("build")]
                        [Validation(Required=false)]
                        public GetModelResponseBodyResultContentRequestParametersBuild Build { get; set; }
                        public class GetModelResponseBodyResultContentRequestParametersBuild : TeaModel {
                            /// <summary>
                            /// <para>The input type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>query</para>
                            /// </summary>
                            [NameInMap("input_type")]
                            [Validation(Required=false)]
                            public string InputType { get; set; }

                        }

                        /// <summary>
                        /// <para>Parameters for the query phase.</para>
                        /// </summary>
                        [NameInMap("search")]
                        [Validation(Required=false)]
                        public GetModelResponseBodyResultContentRequestParametersSearch Search { get; set; }
                        public class GetModelResponseBodyResultContentRequestParametersSearch : TeaModel {
                            /// <summary>
                            /// <para>The input type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>document</para>
                            /// </summary>
                            [NameInMap("input_type")]
                            [Validation(Required=false)]
                            public string InputType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The request body\&quot;s template string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;input\&quot;: [\&quot;%{input}\&quot;], \&quot;input_type\&quot;: \&quot;%{input_type}\&quot;}</para>
                    /// </summary>
                    [NameInMap("requestBody")]
                    [Validation(Required=false)]
                    public string RequestBody { get; set; }

                    /// <summary>
                    /// <para>URL parameters. Some model services require you to pass parameters in the URL.</para>
                    /// </summary>
                    [NameInMap("urlParams")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestUrlParams UrlParams { get; set; }
                    public class GetModelResponseBodyResultContentRequestUrlParams : TeaModel {
                        /// <summary>
                        /// <para>Parameters passed during index building.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key: value</para>
                        /// </summary>
                        [NameInMap("build")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Build { get; set; }

                        /// <summary>
                        /// <para>Parameters passed during a query.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key: value</para>
                        /// </summary>
                        [NameInMap("search")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Search { get; set; }

                    }

                }

                /// <summary>
                /// <para>The method to parse the result. This is described in JSONPath format.</para>
                /// </summary>
                [NameInMap("response")]
                [Validation(Required=false)]
                public GetModelResponseBodyResultContentResponse Response { get; set; }
                public class GetModelResponseBodyResultContentResponse : TeaModel {
                    /// <summary>
                    /// <para>The method to parse the result. This is described in JSONPath format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.result.embeddings[*].embedding</para>
                    /// </summary>
                    [NameInMap("embeddings")]
                    [Validation(Required=false)]
                    public string Embeddings { get; set; }

                }

                /// <summary>
                /// <para>The model service endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://***.platform-cn-shanghai.opensearch.aliyuncs.com/v3/openapi/workspaces/default/text-embedding/ops-text-embedding-001</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The model dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The model status.</para>
            /// <list type="bullet">
            /// <item><description><para>ok: Normal</para>
            /// </description></item>
            /// <item><description><para>error: Abnormal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// <list type="bullet">
            /// <item><description><para>a. Text embedding: text_embedding</para>
            /// </description></item>
            /// <item><description><para>b. Text sparse embedding: text_sparse_embedding</para>
            /// </description></item>
            /// <item><description><para>c. Image embedding: image_embedding</para>
            /// </description></item>
            /// <item><description><para>d. Image content analysis: image_analyze</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The model\&quot;s access URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://***.platform-cn-shanghai.opensearch.aliyuncs.com/v3/openapi/workspaces/default/text-embedding/ops-text-embedding-001</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
