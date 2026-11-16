// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoCharacterReplaceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the video character replacement application. Use a configured application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application input parameters, which are serialized into a JSON string. The field names and material requirements are subject to the input definition of the corresponding AppId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LoadImage.1.TargetImage&quot;:&quot;1a7852b032c371f0b64fe6f6c74b****&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <para>The time when the task finished execution, in ISO 8601 format with time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:54:18.809+08:00</para>
        /// </summary>
        [NameInMap("ExecutionFinishTime")]
        [Validation(Required=false)]
        public string ExecutionFinishTime { get; set; }

        /// <summary>
        /// <para>The time when the task started execution, in ISO 8601 format with time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:34.001+08:00</para>
        /// </summary>
        [NameInMap("ExecutionStartTime")]
        [Validation(Required=false)]
        public string ExecutionStartTime { get; set; }

        /// <summary>
        /// <para>The folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>folder-u3ilwhoc36ux9a****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The task ID, which is returned by SubmitVideoCharacterReplaceJob.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag_83baeea38b534ee1937b8a4acd08****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_061716****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task output results, which are categorized by image, video, and audio.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetVideoCharacterReplaceJobResponseBodyResult Result { get; set; }
        public class GetVideoCharacterReplaceJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of output audio.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetVideoCharacterReplaceJobResponseBodyResultAudioResult> AudioResult { get; set; }
            public class GetVideoCharacterReplaceJobResponseBodyResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The output media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The download URL of the output media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The list of output images.</para>
            /// </summary>
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetVideoCharacterReplaceJobResponseBodyResultImageResult> ImageResult { get; set; }
            public class GetVideoCharacterReplaceJobResponseBodyResultImageResult : TeaModel {
                /// <summary>
                /// <para>The output media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The download URL of the output media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The list of output videos.</para>
            /// </summary>
            [NameInMap("VideoResult")]
            [Validation(Required=false)]
            public List<GetVideoCharacterReplaceJobResponseBodyResultVideoResult> VideoResult { get; set; }
            public class GetVideoCharacterReplaceJobResponseBodyResultVideoResult : TeaModel {
                /// <summary>
                /// <para>The output media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The download URL of the output media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Created: The task is created.</description></item>
        /// <item><description>Queuing: The task is queuing.</description></item>
        /// <item><description>Executing: The task is executing.</description></item>
        /// <item><description>Finished: The task is finished.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
