// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetC2paSignResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code for the API call. OK is returned when the call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error code for task failure. This parameter is returned only when Status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2PA_FORMAT_UNSUPPORTED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message for task failure. This parameter is returned only when Status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>only valid JPEG and PNG source files are supported</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The number of objects that failed to be signed, were skipped, or were terminated in the Bucket task. This parameter is returned only when the Bucket task is in the SUCCEEDED or CANCELED state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The HTTP status code. 200 is returned when the API call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. success is returned when the API call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The temporary download URL returned when a Bucket task enters the CANCELED state and the JSON report is successfully generated. The report covers only the objects discovered before termination.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/c2pa_report.json?Expires=1788000000&Signature=">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/c2pa_report.json?Expires=1788000000&amp;Signature=</a>***</para>
        /// </summary>
        [NameInMap("ReportFileUrl")]
        [Validation(Required=false)]
        public string ReportFileUrl { get; set; }

        /// <summary>
        /// <para>The object key of the final standard JSON report for the Bucket task. This parameter is returned only when the Bucket task succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign-signed/047b8305-9572-4eed-b7fb-8588b989b6e5/c2pa_report.json</para>
        /// </summary>
        [NameInMap("ReportObjectKey")]
        [Validation(Required=false)]
        public string ReportObjectKey { get; set; }

        /// <summary>
        /// <para>The request ID of the OpenAPI call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The temporary download URL of the signature file. This parameter is returned only when Status is SUCCEEDED.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.oss-cn-hangzhou.aliyuncs.com/">https://example.oss-cn-hangzhou.aliyuncs.com/</a>...</para>
        /// </summary>
        [NameInMap("SignedFileUrl")]
        [Validation(Required=false)]
        public string SignedFileUrl { get; set; }

        /// <summary>
        /// <para>The task status. Valid values: PROCESSING, SUCCEEDED, and FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of successfully signed objects in the Bucket task. This parameter is returned only when the Bucket task is in the SUCCEEDED or CANCELED state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SucceededCount")]
        [Validation(Required=false)]
        public long? SucceededCount { get; set; }

        /// <summary>
        /// <para>Indicates whether the query call is successful. This value may still be true even if the task itself fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The C2PA signing task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7093c29e-f472-4e1e-91c6-a43df7c7382e</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. Valid values: FILE and BUCKET.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUCKET</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The total number of objects scanned by the Bucket task. This parameter is returned only when the Bucket task is in the SUCCEEDED or CANCELED state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
