// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetBatchExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBatchExportTaskResponseBodyData Data { get; set; }
        public class GetBatchExportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>some apis export failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("processedCount")]
            [Validation(Required=false)]
            public int? ProcessedCount { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public GetBatchExportTaskResponseBodyDataResult Result { get; set; }
            public class GetBatchExportTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Http</para>
                /// </summary>
                [NameInMap("apiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                [NameInMap("failureItems")]
                [Validation(Required=false)]
                public List<GetBatchExportTaskResponseBodyDataResultFailureItems> FailureItems { get; set; }
                public class GetBatchExportTaskResponseBodyDataResultFailureItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api definition is invalid</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UEsDBBQAAAA...</para>
                /// </summary>
                [NameInMap("specContentBase64")]
                [Validation(Required=false)]
                public string SpecContentBase64 { get; set; }

                [NameInMap("successItems")]
                [Validation(Required=false)]
                public List<GetBatchExportTaskResponseBodyDataResultSuccessItems> SuccessItems { get; set; }
                public class GetBatchExportTaskResponseBodyDataResultSuccessItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api definition is invalid</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>async-task-xxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BatchExport</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CE534E1D-FCE4-5930-B784-E055EC1AEE6F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
