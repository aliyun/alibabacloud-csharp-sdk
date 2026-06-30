// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The AI application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The input parameters for the AI application run. The value is a string obtained after JSON serialize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <para>The time when the task ended. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:18.809+08:00</para>
        /// </summary>
        [NameInMap("ExecutionFinishTime")]
        [Validation(Required=false)]
        public string ExecutionFinishTime { get; set; }

        /// <summary>
        /// <para>The time when the task started. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
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
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>cdb3e74639973036bc84</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>cdb3e74639973036bc84</b></b></para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task execution result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetYikeAIAppJobResponseBodyResult Result { get; set; }
        public class GetYikeAIAppJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The audio task result.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetYikeAIAppJobResponseBodyResultAudioResult> AudioResult { get; set; }
            public class GetYikeAIAppJobResponseBodyResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The output file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3">http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The image task result.</para>
            /// </summary>
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetYikeAIAppJobResponseBodyResultImageResult> ImageResult { get; set; }
            public class GetYikeAIAppJobResponseBodyResultImageResult : TeaModel {
                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The output file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png">http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The video task result.</para>
            /// </summary>
            [NameInMap("VideoResult")]
            [Validation(Required=false)]
            public List<GetYikeAIAppJobResponseBodyResultVideoResult> VideoResult { get; set; }
            public class GetYikeAIAppJobResponseBodyResultVideoResult : TeaModel {
                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The output file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4">http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4</a></para>
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
        /// <item><description>Executing: The task is being executed.</description></item>
        /// <item><description>Finished: The task is finished.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
