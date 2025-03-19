// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyModelRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public ModifyModelRequestContent Content { get; set; }
        public class ModifyModelRequestContent : TeaModel {
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
            public ModifyModelRequestContentRequest Request { get; set; }
            public class ModifyModelRequestContentRequest : TeaModel {
                [NameInMap("header")]
                [Validation(Required=false)]
                public ModifyModelRequestContentRequestHeader Header { get; set; }
                public class ModifyModelRequestContentRequestHeader : TeaModel {
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
                public ModifyModelRequestContentRequestParameters Parameters { get; set; }
                public class ModifyModelRequestContentRequestParameters : TeaModel {
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public ModifyModelRequestContentRequestParametersBuild Build { get; set; }
                    public class ModifyModelRequestContentRequestParametersBuild : TeaModel {
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
                    public ModifyModelRequestContentRequestParametersSearch Search { get; set; }
                    public class ModifyModelRequestContentRequestParametersSearch : TeaModel {
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
                public ModifyModelRequestContentRequestUrlParams UrlParams { get; set; }
                public class ModifyModelRequestContentRequestUrlParams : TeaModel {
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
            public ModifyModelRequestContentResponse Response { get; set; }
            public class ModifyModelRequestContentResponse : TeaModel {
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
        /// <para>ok</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
