// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetVideoCreationTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVideoCreationTaskResultResponseBodyData Data { get; set; }
        public class GetVideoCreationTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("estimatedWaitTimeInSeconds")]
            [Validation(Required=false)]
            public long? EstimatedWaitTimeInSeconds { get; set; }

            [NameInMap("fileInfo")]
            [Validation(Required=false)]
            public GetVideoCreationTaskResultResponseBodyDataFileInfo FileInfo { get; set; }
            public class GetVideoCreationTaskResultResponseBodyDataFileInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("fileTraceId")]
                [Validation(Required=false)]
                public string FileTraceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ossKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("mediaDetectionTaskResult")]
            [Validation(Required=false)]
            public GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResult MediaDetectionTaskResult { get; set; }
            public class GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("detectionConclusion")]
                [Validation(Required=false)]
                public string DetectionConclusion { get; set; }

                [NameInMap("detectionResult")]
                [Validation(Required=false)]
                public GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultDetectionResult DetectionResult { get; set; }
                public class GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultDetectionResult : TeaModel {
                    [NameInMap("detectionDetails")]
                    [Validation(Required=false)]
                    public List<GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultDetectionResultDetectionDetails> DetectionDetails { get; set; }
                    public class GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultDetectionResultDetectionDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.8</para>
                        /// </summary>
                        [NameInMap("confidence")]
                        [Validation(Required=false)]
                        public double? Confidence { get; set; }

                        [NameInMap("pass")]
                        [Validation(Required=false)]
                        public bool? Pass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                    }

                    [NameInMap("suggestions")]
                    [Validation(Required=false)]
                    public List<string> Suggestions { get; set; }

                }

                [NameInMap("fileInfo")]
                [Validation(Required=false)]
                public GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultFileInfo FileInfo { get; set; }
                public class GetVideoCreationTaskResultResponseBodyDataMediaDetectionTaskResultFileInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("fileTraceId")]
                    [Validation(Required=false)]
                    public string FileTraceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ossKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("taskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("retryAble")]
        [Validation(Required=false)]
        public bool? RetryAble { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
