// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
                /// <para>The error messages. If an error message is returned, the API fails to be imported.</para>
                /// </summary>
                [NameInMap("errorMessages")]
                [Validation(Required=false)]
                public List<string> ErrorMessages { get; set; }

                /// <summary>
                /// <para>The existing APIs. If an existing API is returned, the import updates the existing API.</para>
                /// </summary>
                [NameInMap("existHttpApiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ExistHttpApiInfo { get; set; }

                /// <summary>
                /// <para>The data structs that fail the dry run.</para>
                /// </summary>
                [NameInMap("failureComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureComponents> FailureComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureComponents : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The data struct is incorrectly defined.</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The data struct name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>orderDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The operations that fail the dry run.</para>
                /// </summary>
                [NameInMap("failureOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoFailureOperations> FailureOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoFailureOperations : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Missing response definition.</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The HTTP method of the operation.</para>
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

                /// <summary>
                /// <para>The data structs that pass the dry run.</para>
                /// </summary>
                [NameInMap("successComponents")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents> SuccessComponents { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessComponents : TeaModel {
                    /// <summary>
                    /// <para>The action that will be performed for the data struct after the dry run.</para>
                    /// <list type="bullet">
                    /// <item><description>Create: The data struct is created.</description></item>
                    /// <item><description>Update: The data struct is updated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The data struct name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userDTO</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The operations that pass the dry run.</para>
                /// </summary>
                [NameInMap("successOperations")]
                [Validation(Required=false)]
                public List<ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations> SuccessOperations { get; set; }
                public class ImportHttpApiResponseBodyDataDryRunInfoSuccessOperations : TeaModel {
                    /// <summary>
                    /// <para>The action that will be performed for the operation after the dry run.</para>
                    /// <list type="bullet">
                    /// <item><description>Create: The operation is created.</description></item>
                    /// <item><description>Update: The operation is updated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create</para>
                    /// </summary>
                    [NameInMap("action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The HTTP method of the operation.</para>
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

                /// <summary>
                /// <para>The alerts. If an alert is returned, specific operations or structs may fail to be imported.</para>
                /// </summary>
                [NameInMap("warningMessages")]
                [Validation(Required=false)]
                public List<string> WarningMessages { get; set; }

            }

            /// <summary>
            /// <para>The API ID.</para>
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
        /// <para>The returned message.</para>
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
