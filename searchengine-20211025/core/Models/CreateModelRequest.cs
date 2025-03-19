// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateModelRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public CreateModelRequestContent Content { get; set; }
        public class CreateModelRequestContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text_embedding</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("request")]
            [Validation(Required=false)]
            public CreateModelRequestContentRequest Request { get; set; }
            public class CreateModelRequestContentRequest : TeaModel {
                [NameInMap("header")]
                [Validation(Required=false)]
                public CreateModelRequestContentRequestHeader Header { get; set; }
                public class CreateModelRequestContentRequestHeader : TeaModel {
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
                public CreateModelRequestContentRequestParameters Parameters { get; set; }
                public class CreateModelRequestContentRequestParameters : TeaModel {
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public CreateModelRequestContentRequestParametersBuild Build { get; set; }
                    public class CreateModelRequestContentRequestParametersBuild : TeaModel {
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
                    public CreateModelRequestContentRequestParametersSearch Search { get; set; }
                    public class CreateModelRequestContentRequestParametersSearch : TeaModel {
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
                public CreateModelRequestContentRequestUrlParams UrlParams { get; set; }
                public class CreateModelRequestContentRequestUrlParams : TeaModel {
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
            public CreateModelRequestContentResponse Response { get; set; }
            public class CreateModelRequestContentResponse : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
