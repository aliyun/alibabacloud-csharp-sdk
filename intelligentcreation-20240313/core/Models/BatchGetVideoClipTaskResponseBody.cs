// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetVideoClipTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>86A90C40-D1AB-50DA-A4B1-0D545F80F2FE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("taskList")]
        [Validation(Required=false)]
        public List<BatchGetVideoClipTaskResponseBodyTaskList> TaskList { get; set; }
        public class BatchGetVideoClipTaskResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>864413342857035776</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>43335</para>
            /// </summary>
            [NameInMap("totalDuration")]
            [Validation(Required=false)]
            public double? TotalDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("totalToken")]
            [Validation(Required=false)]
            public long? TotalToken { get; set; }

            [NameInMap("videoList")]
            [Validation(Required=false)]
            public List<BatchGetVideoClipTaskResponseBodyTaskListVideoList> VideoList { get; set; }
            public class BatchGetVideoClipTaskResponseBodyTaskListVideoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("beginTime")]
                [Validation(Required=false)]
                public int? BeginTime { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11110</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://e-ai.oss-cn-guangzhou.aliyuncs.com/video/jlkasdl.mp4">https://e-ai.oss-cn-guangzhou.aliyuncs.com/video/jlkasdl.mp4</a></para>
                /// </summary>
                [NameInMap("videoDownloadUrl")]
                [Validation(Required=false)]
                public string VideoDownloadUrl { get; set; }

                [NameInMap("videoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://e-ai.oss-cn-guangzhou.aliyuncs.com/video/jlkasdl.mp4">https://e-ai.oss-cn-guangzhou.aliyuncs.com/video/jlkasdl.mp4</a></para>
                /// </summary>
                [NameInMap("videoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

        }

    }

}
