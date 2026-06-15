// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The API information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ImportHttpApiResponseBodyData Data { get; set; }
        public class ImportHttpApiResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The dry run result.</para>
            /// </summary>
            [NameInMap("dryRunInfo")]
            [Validation(Required=false)]
            public ImportHttpApiResponseBodyDataDryRunInfo DryRunInfo { get; set; }
            public class ImportHttpApiResponseBodyDataDryRunInfo : TeaModel {
                /// <summary>
                /// <para>The error messages. If error messages are not empty, the API cannot be imported.</para>
                /// </summary>
                [NameInMap("errorMessages")]
                [Validation(Required=false)]
                public List<string> ErrorMessages { get; set; }

                /// <summary>
                /// <para>The information about the existing API. If this field is not empty, the import updates this API.</para>
                /// </summary>
                [NameInMap("existHttpApiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ExistHttpApiInfo { get; set; }

                /// <summary>
                /// <para>The list of data structures that failed the dry run.</para>
                /// </summary>
                [NameInMap("failureComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureComponents> FailureComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureComponents : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>数据结构定义有误。</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The data structure name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>orderDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of operations that failed the dry run.</para>
                /// </summary>
                [NameInMap("failureOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureOperations> FailureOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureOperations : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>缺少响应定义。</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The operation method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GET</para>
                    /// </summary>
                    [NameInMap("method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The operation path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/orders</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("failureRoutes")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureRoutes> FailureRoutes { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureRoutes : TeaModel {
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("mcpToolsDefinition")]
                [Validation(Required=false)]
                public string McpToolsDefinition { get; set; }

                /// <summary>
                /// <para>The list of data structures that passed the dry run.</para>
                /// </summary>
                [NameInMap("successComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents> SuccessComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents : TeaModel {
                    /// <summary>
                    /// <para>The action to be performed after the dry run. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Create: create.</description></item>
                    /// <item><description>Update: update.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The data structure name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of operations that passed the dry run.</para>
                /// </summary>
                [NameInMap("successOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations> SuccessOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations : TeaModel {
                    /// <summary>
                    /// <para>The action to be performed after the dry run. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Create: create.</description></item>
                    /// <item><description>Update: update.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The operation method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>POST</para>
                    /// </summary>
                    [NameInMap("method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The operation name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CreateUser</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operation path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/users</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("successRoutes")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessRoutes> SuccessRoutes { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessRoutes : TeaModel {
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The warning messages. If warning messages are not empty, some operations or data structures may not be imported.</para>
                /// </summary>
                [NameInMap("warningMessages")]
                [Validation(Required=false)]
                public List<string> WarningMessages { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxx</para>
            /// </summary>
            [NameInMap("httpApiId")]
            [Validation(Required=false)]
            public string HttpApiId { get; set; }

            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>import-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE857A85-251D-5018-8103-A38957D71E20</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
