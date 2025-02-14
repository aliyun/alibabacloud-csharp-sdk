// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiResponseBody : TeaModel {
        /// <summary>
        /// <para>Response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>API information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ImportHttpApiResponseBodyData Data { get; set; }
        public class ImportHttpApiResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Pre-import check result.</para>
            /// </summary>
            [NameInMap("dryRunInfo")]
            [Validation(Required=false)]
            public ImportHttpApiResponseBodyDataDryRunInfo DryRunInfo { get; set; }
            public class ImportHttpApiResponseBodyDataDryRunInfo : TeaModel {
                /// <summary>
                /// <para>Error messages. If there are any error messages, the API cannot be imported successfully.</para>
                /// </summary>
                [NameInMap("errorMessages")]
                [Validation(Required=false)]
                public List<string> ErrorMessages { get; set; }

                /// <summary>
                /// <para>已存在的API信息。若该字段非空，则导入动作将更新该API。</para>
                /// </summary>
                [NameInMap("existHttpApiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ExistHttpApiInfo { get; set; }

                /// <summary>
                /// <para>List of data structures that failed the precheck.</para>
                /// </summary>
                [NameInMap("failureComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureComponents> FailureComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureComponents : TeaModel {
                    /// <summary>
                    /// <para>Error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>数据结构定义有误。</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>数据结构名称。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>orderDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>List of APIs that failed the precheck.</para>
                /// </summary>
                [NameInMap("failureOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureOperations> FailureOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureOperations : TeaModel {
                    /// <summary>
                    /// <para>Error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>缺少响应定义。</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>API method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GET</para>
                    /// </summary>
                    [NameInMap("method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>API path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/orders</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>List of data structures that passed the precheck.</para>
                /// </summary>
                [NameInMap("successComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents> SuccessComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents : TeaModel {
                    /// <summary>
                    /// <para>Action to be executed after the precheck.</para>
                    /// <list type="bullet">
                    /// <item><description>Create: Create</description></item>
                    /// <item><description>Update: Update</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>Data structure name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>List of successfully pre-checked interfaces.</para>
                /// </summary>
                [NameInMap("successOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations> SuccessOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations : TeaModel {
                    /// <summary>
                    /// <para>Action to be executed after the precheck.</para>
                    /// <list type="bullet">
                    /// <item><description>Create: Create</description></item>
                    /// <item><description>Update: Update</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>API method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>POST</para>
                    /// </summary>
                    [NameInMap("method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>API name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CreateUser</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>API path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/users</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>Warning messages. If there are any warning messages, some interfaces or data interfaces may not be imported successfully.</para>
                /// </summary>
                [NameInMap("warningMessages")]
                [Validation(Required=false)]
                public List<string> WarningMessages { get; set; }

            }

            /// <summary>
            /// <para>HTTP API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxx</para>
            /// </summary>
            [NameInMap("httpApiId")]
            [Validation(Required=false)]
            public string HttpApiId { get; set; }

            /// <summary>
            /// <para>API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>import-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE857A85-251D-5018-8103-A38957D71E20</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
