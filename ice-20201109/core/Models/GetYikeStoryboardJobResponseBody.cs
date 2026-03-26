// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetYikeStoryboardJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public GetYikeStoryboardJobResponseBodyJobParams JobParams { get; set; }
        public class GetYikeStoryboardJobResponseBodyJobParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;AudioEnable&quot;: false
            /// }</para>
            /// </summary>
            [NameInMap("ModelParams")]
            [Validation(Required=false)]
            public string ModelParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sys_YoungGracefulWoman</para>
            /// </summary>
            [NameInMap("NarrationVoiceId")]
            [Validation(Required=false)]
            public string NarrationVoiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1K</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>multi</para>
            /// </summary>
            [NameInMap("ShotPromptMode")]
            [Validation(Required=false)]
            public string ShotPromptMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>firstPersonNarration</para>
            /// </summary>
            [NameInMap("ShotSplitMode")]
            [Validation(Required=false)]
            public string ShotSplitMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Novel</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RealisticPhotography</para>
            /// </summary>
            [NameInMap("StyleId")]
            [Validation(Required=false)]
            public string StyleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wan2.6-r2v-flash</para>
            /// </summary>
            [NameInMap("VideoModel")]
            [Validation(Required=false)]
            public string VideoModel { get; set; }

        }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public GetYikeStoryboardJobResponseBodyJobResult JobResult { get; set; }
        public class GetYikeStoryboardJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[\&quot;st_2053348871\&quot;]</para>
            /// </summary>
            [NameInMap("ExceptionStoryboardIds")]
            [Validation(Required=false)]
            public string ExceptionStoryboardIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;errorCode\&quot;:\&quot;NoMediaData\&quot;,\&quot;storyboardId\&quot;:\&quot;st_2118280473\&quot;,\&quot;shotId\&quot;:\&quot;54\&quot;}]</para>
            /// </summary>
            [NameInMap("FailureShotList")]
            [Validation(Required=false)]
            public string FailureShotList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            [NameInMap("StoryboardInfoList")]
            [Validation(Required=false)]
            public string StoryboardInfoList { get; set; }

            [NameInMap("SuccessStoryboardIds")]
            [Validation(Required=false)]
            public string SuccessStoryboardIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[\&quot;st_2118280473\&quot;]</para>
            /// </summary>
            [NameInMap("SuccessStoryboardList")]
            [Validation(Required=false)]
            public string SuccessStoryboardList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
