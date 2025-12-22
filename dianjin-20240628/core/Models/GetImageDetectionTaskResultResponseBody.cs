// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetImageDetectionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetImageDetectionTaskResultResponseBodyData Data { get; set; }
        public class GetImageDetectionTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("detectionConclusion")]
            [Validation(Required=false)]
            public string DetectionConclusion { get; set; }

            [NameInMap("detectionResult")]
            [Validation(Required=false)]
            public GetImageDetectionTaskResultResponseBodyDataDetectionResult DetectionResult { get; set; }
            public class GetImageDetectionTaskResultResponseBodyDataDetectionResult : TeaModel {
                [NameInMap("detectionDetails")]
                [Validation(Required=false)]
                public List<GetImageDetectionTaskResultResponseBodyDataDetectionResultDetectionDetails> DetectionDetails { get; set; }
                public class GetImageDetectionTaskResultResponseBodyDataDetectionResultDetectionDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
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
            public GetImageDetectionTaskResultResponseBodyDataFileInfo FileInfo { get; set; }
            public class GetImageDetectionTaskResultResponseBodyDataFileInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
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
