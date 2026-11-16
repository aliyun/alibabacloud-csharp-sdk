// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoRemakeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The unified remake task details.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetVideoRemakeJobResponseBodyJob Job { get; set; }
        public class GetVideoRemakeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The error code for the failed asynchronous task. This parameter has a value only when the task status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message for the failed asynchronous task. This parameter has a value only when the task status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lockCredit business failed: NOT_ENOUGH_ALLOCATE_CREDIT_QUOTA</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The unified remake task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The content understanding and script outputs returned when the status is Finished. This is not the rendered video.</para>
            /// </summary>
            [NameInMap("JobResult")]
            [Validation(Required=false)]
            public GetVideoRemakeJobResponseBodyJobJobResult JobResult { get; set; }
            public class GetVideoRemakeJobResponseBodyJobJobResult : TeaModel {
                /// <summary>
                /// <para>The download URL of the JSON file for the content understanding result.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/comprehension-result.json">https://example-bucket.oss-cn-shanghai.aliyuncs.com/comprehension-result.json</a></para>
                /// </summary>
                [NameInMap("AiResult")]
                [Validation(Required=false)]
                public string AiResult { get; set; }

                /// <summary>
                /// <para>The download URL of the JSON file for the creative script. Use the file content as the Script parameter for SubmitVideoRenderJob.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/creative-script.json">https://example.com/creative-script.json</a></para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

            }

            /// <summary>
            /// <para>The list of input media asset IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1234567890abcdef1234567890abcdef&quot;]</para>
            /// </summary>
            [NameInMap("MediaIds")]
            [Validation(Required=false)]
            public List<string> MediaIds { get; set; }

            /// <summary>
            /// <para>The task status. Valid values: Created, Executing, Finished, and Failed. Finished indicates that content understanding and script generation are completed. If the status is Failed, check ErrorCode and ErrorMessage. If the task has been deleted, the query returns RecordNotFound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UserData JSON string submitted with the task, returned as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://example.com/callback%22%7D">https://example.com/callback&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request tracking identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4321-ABCD-123456789012</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
