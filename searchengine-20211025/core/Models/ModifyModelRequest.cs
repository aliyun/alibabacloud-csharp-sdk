// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyModelRequest : TeaModel {
        /// <summary>
        /// <para>The model details.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public ModifyModelRequestContent Content { get; set; }
        public class ModifyModelRequestContent : TeaModel {
            /// <summary>
            /// <para>The dimension of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The HTTP method to access the model service. Valid values are PUT and POST.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// <list type="bullet">
            /// <item><description><para>Text embedding: text_embedding</para>
            /// </description></item>
            /// <item><description><para>Text sparse embedding: text_sparse_embedding</para>
            /// </description></item>
            /// <item><description><para>Image embedding: image_embedding</para>
            /// </description></item>
            /// <item><description><para>Image content parsing: image_analyze</para>
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
            /// <para>The model request body.</para>
            /// </summary>
            [NameInMap("request")]
            [Validation(Required=false)]
            public ModifyModelRequestContentRequest Request { get; set; }
            public class ModifyModelRequestContentRequest : TeaModel {
                /// <summary>
                /// <para>The HTTP header to access the model service.</para>
                /// </summary>
                [NameInMap("header")]
                [Validation(Required=false)]
                public ModifyModelRequestContentRequestHeader Header { get; set; }
                public class ModifyModelRequestContentRequestHeader : TeaModel {
                    /// <summary>
                    /// <para>The authentication information. Format: Bearer access_token</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bearer OS-v0********6vvs</para>
                    /// </summary>
                    [NameInMap("Authorization")]
                    [Validation(Required=false)]
                    public string Authorization { get; set; }

                    /// <summary>
                    /// <para>The content type of the HTTP request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("Content-Type")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                }

                /// <summary>
                /// <para>Specifies parameters that are different for the build and search phases.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public ModifyModelRequestContentRequestParameters Parameters { get; set; }
                public class ModifyModelRequestContentRequestParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameters for the index building phase.</para>
                    /// </summary>
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public ModifyModelRequestContentRequestParametersBuild Build { get; set; }
                    public class ModifyModelRequestContentRequestParametersBuild : TeaModel {
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
                    /// <para>The parameters for the query phase.</para>
                    /// </summary>
                    [NameInMap("search")]
                    [Validation(Required=false)]
                    public ModifyModelRequestContentRequestParametersSearch Search { get; set; }
                    public class ModifyModelRequestContentRequestParametersSearch : TeaModel {
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
                /// <para>The template string for the request body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;input\&quot;: [\&quot;%{input}\&quot;], \&quot;input_type\&quot;: \&quot;%{input_type}\&quot;}</para>
                /// </summary>
                [NameInMap("requestBody")]
                [Validation(Required=false)]
                public string RequestBody { get; set; }

                /// <summary>
                /// <para>The parameters in the URL. Some model services require parameters to be passed in the URL.</para>
                /// </summary>
                [NameInMap("urlParams")]
                [Validation(Required=false)]
                public ModifyModelRequestContentRequestUrlParams UrlParams { get; set; }
                public class ModifyModelRequestContentRequestUrlParams : TeaModel {
                    /// <summary>
                    /// <para>The parameters for the index building phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key: value</para>
                    /// </summary>
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Build { get; set; }

                    /// <summary>
                    /// <para>The parameters for the query phase.</para>
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
            /// <para>The JSONPath expression used to parse the result.</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public ModifyModelRequestContentResponse Response { get; set; }
            public class ModifyModelRequestContentResponse : TeaModel {
                /// <summary>
                /// <para>The JSONPath expression used to parse the embeddings from the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$.result.embeddings[*].embedding</para>
                /// </summary>
                [NameInMap("embeddings")]
                [Validation(Required=false)]
                public string Embeddings { get; set; }

            }

            /// <summary>
            /// <para>The endpoint of the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://***.platform-cn-shanghai.opensearch.aliyuncs.com/v3/openapi/workspaces/default/text-embedding/ops-text-embedding-001</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The model status.</para>
        /// <list type="bullet">
        /// <item><description><para>ok: The model is active.</para>
        /// </description></item>
        /// <item><description><para>forbidden: The model is unavailable.</para>
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
        /// <para>Specifies whether to perform only a check. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
