// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C890995A-CF06-4F4D-8DB8-DD26C2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task object.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public DescribePolarClawTaskResponseBodyTask Task { get; set; }
        public class DescribePolarClawTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The timestamp when the task was created, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1778564698304</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <para>The error object. This parameter is returned only if the task fails.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public DescribePolarClawTaskResponseBodyTaskError Error { get; set; }
            public class DescribePolarClawTaskResponseBodyTaskError : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INVALID_REQUEST</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>channelId format invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The operation name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LoginPolarClawChannel</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The task result object. This parameter is returned only if the task succeeds. The content of this object varies by operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public Dictionary<string, object> Result { get; set; }

            /// <summary>
            /// <para>The task state. Valid values: pending, running, succeeded, and failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The task ID, which is a universally unique identifier (UUID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5956e600-ce6e-4d11-9648-939ef3286e94</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The timestamp when the task was last updated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1778564750541</para>
            /// </summary>
            [NameInMap("UpdatedAtMs")]
            [Validation(Required=false)]
            public long? UpdatedAtMs { get; set; }

        }

    }

}
