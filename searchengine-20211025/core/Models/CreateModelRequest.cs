// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateModelRequest : TeaModel {
        /// <summary>
        /// <para>The model details.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public CreateModelRequestContent Content { get; set; }
        public class CreateModelRequestContent : TeaModel {
            /// <summary>
            /// <para>The dimension of the model. This parameter is required if \<c>modelType\\</c> is \<c>text_embedding\\</c> or \<c>image_embedding\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The HTTP method to access the model service. Supported methods: PUT and POST.</para>
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
            /// <para>The model request body.</para>
            /// </summary>
            [NameInMap("request")]
            [Validation(Required=false)]
            public CreateModelRequestContentRequest Request { get; set; }
            public class CreateModelRequestContentRequest : TeaModel {
                /// <summary>
                /// <para>The HTTP header for accessing the model service.</para>
                /// </summary>
                [NameInMap("header")]
                [Validation(Required=false)]
                public CreateModelRequestContentRequestHeader Header { get; set; }
                public class CreateModelRequestContentRequestHeader : TeaModel {
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
                /// <para>If the parameters in the request body are different for the build and search phases, define them in this parameter.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public CreateModelRequestContentRequestParameters Parameters { get; set; }
                public class CreateModelRequestContentRequestParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameters for the index building phase.</para>
                    /// </summary>
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public CreateModelRequestContentRequestParametersBuild Build { get; set; }
                    public class CreateModelRequestContentRequestParametersBuild : TeaModel {
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
                    public CreateModelRequestContentRequestParametersSearch Search { get; set; }
                    public class CreateModelRequestContentRequestParametersSearch : TeaModel {
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
                /// <para>The parameters in the URL. Some model services require that parameters are passed in the URL.</para>
                /// </summary>
                [NameInMap("urlParams")]
                [Validation(Required=false)]
                public CreateModelRequestContentRequestUrlParams UrlParams { get; set; }
                public class CreateModelRequestContentRequestUrlParams : TeaModel {
                    /// <summary>
                    /// <para>The parameters passed during index building.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key: value</para>
                    /// </summary>
                    [NameInMap("build")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Build { get; set; }

                    /// <summary>
                    /// <para>The parameters passed during a query.</para>
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
            /// <para>The configuration for parsing the response. Use JSONPath format.</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public CreateModelRequestContentResponse Response { get; set; }
            public class CreateModelRequestContentResponse : TeaModel {
                /// <summary>
                /// <para>The JSONPath expression to extract embeddings from the response.</para>
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
        /// <para>The model name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
