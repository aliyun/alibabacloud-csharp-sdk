// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>38b079f1-7846-4226-8c90-3e2644b5c52b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetModelResponseBodyResult Result { get; set; }
        public class GetModelResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public GetModelResponseBodyResultContent Content { get; set; }
            public class GetModelResponseBodyResultContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text_embedding</para>
                /// </summary>
                [NameInMap("modelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                [NameInMap("request")]
                [Validation(Required=false)]
                public GetModelResponseBodyResultContentRequest Request { get; set; }
                public class GetModelResponseBodyResultContentRequest : TeaModel {
                    [NameInMap("header")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestHeader Header { get; set; }
                    public class GetModelResponseBodyResultContentRequestHeader : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Bearer OS-v0********6vvs</para>
                        /// </summary>
                        [NameInMap("Authorization")]
                        [Validation(Required=false)]
                        public string Authorization { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>application/json</para>
                        /// </summary>
                        [NameInMap("Content-Type")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestParameters Parameters { get; set; }
                    public class GetModelResponseBodyResultContentRequestParameters : TeaModel {
                        [NameInMap("build")]
                        [Validation(Required=false)]
                        public GetModelResponseBodyResultContentRequestParametersBuild Build { get; set; }
                        public class GetModelResponseBodyResultContentRequestParametersBuild : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>query</para>
                            /// </summary>
                            [NameInMap("input_type")]
                            [Validation(Required=false)]
                            public string InputType { get; set; }

                        }

                        [NameInMap("search")]
                        [Validation(Required=false)]
                        public GetModelResponseBodyResultContentRequestParametersSearch Search { get; set; }
                        public class GetModelResponseBodyResultContentRequestParametersSearch : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>document</para>
                            /// </summary>
                            [NameInMap("input_type")]
                            [Validation(Required=false)]
                            public string InputType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;input\&quot;: [\&quot;%{input}\&quot;], \&quot;input_type\&quot;: \&quot;%{input_type}\&quot;}</para>
                    /// </summary>
                    [NameInMap("requestBody")]
                    [Validation(Required=false)]
                    public string RequestBody { get; set; }

                    [NameInMap("urlParams")]
                    [Validation(Required=false)]
                    public GetModelResponseBodyResultContentRequestUrlParams UrlParams { get; set; }
                    public class GetModelResponseBodyResultContentRequestUrlParams : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key: value</para>
                        /// </summary>
                        [NameInMap("build")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Build { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key: value</para>
                        /// </summary>
                        [NameInMap("search")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Search { get; set; }

                    }

                }

                [NameInMap("response")]
                [Validation(Required=false)]
                public GetModelResponseBodyResultContentResponse Response { get; set; }
                public class GetModelResponseBodyResultContentResponse : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>$.result.embeddings[*].embedding</para>
                    /// </summary>
                    [NameInMap("embeddings")]
                    [Validation(Required=false)]
                    public string Embeddings { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http://***.platform-cn-shanghai.opensearch.aliyuncs.com/v3/openapi/workspaces/default/text-embedding/ops-text-embedding-001</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http://***.platform-cn-shanghai.opensearch.aliyuncs.com/v3/openapi/workspaces/default/text-embedding/ops-text-embedding-001</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
