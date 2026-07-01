// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The Yike AI App ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The input parameters for the Yike AI App, provided as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <para>The UTC time when the job finished, in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:18.809+08:00</para>
        /// </summary>
        [NameInMap("ExecutionFinishTime")]
        [Validation(Required=false)]
        public string ExecutionFinishTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the job started, in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
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
        /// <para>The job ID.</para>
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
        /// <para>The job results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetYikeAIAppJobResponseBodyResult Result { get; set; }
        public class GetYikeAIAppJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The audio results.</para>
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
                /// <para>The OSS URL of the output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3">http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The image results.</para>
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
                /// <para>The OSS URL of the output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png">http://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png</a></para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

            }

            /// <summary>
            /// <para>The video results.</para>
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
                /// <para>The OSS URL of the output file.</para>
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
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Created</c>: The job is created.</para>
        /// </description></item>
        /// <item><description><para><c>Queuing</c>: The job is queued for processing.</para>
        /// </description></item>
        /// <item><description><para><c>Executing</c>: The job is running.</para>
        /// </description></item>
        /// <item><description><para><c>Finished</c>: The job completed successfully.</para>
        /// </description></item>
        /// <item><description><para><c>Failed</c>: The job failed.</para>
        /// </description></item>
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
