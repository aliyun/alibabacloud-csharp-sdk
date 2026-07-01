// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetYikeStoryboardJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The storyboard job ID. You can obtain this ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/461964.html">SubmitStoryboardJob</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>A JSON object that contains the parameters for the job. The structure of this object varies based on the AI algorithm.</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public GetYikeStoryboardJobResponseBodyJobParams JobParams { get; set; }
        public class GetYikeStoryboardJobResponseBodyJobParams : TeaModel {
            /// <summary>
            /// <para>The aspect ratio of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            /// <summary>
            /// <para>The OSS URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The model parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;AudioEnable&quot;: false
            /// }</para>
            /// </summary>
            [NameInMap("ModelParams")]
            [Validation(Required=false)]
            public string ModelParams { get; set; }

            /// <summary>
            /// <para>The narration voice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sys_YoungGracefulWoman</para>
            /// </summary>
            [NameInMap("NarrationVoiceId")]
            [Validation(Required=false)]
            public string NarrationVoiceId { get; set; }

            /// <summary>
            /// <para>The resolution of the generated video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1K</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The shot generation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>multi</para>
            /// </summary>
            [NameInMap("ShotPromptMode")]
            [Validation(Required=false)]
            public string ShotPromptMode { get; set; }

            /// <summary>
            /// <para>The shot splitting mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>firstPersonNarration</para>
            /// </summary>
            [NameInMap("ShotSplitMode")]
            [Validation(Required=false)]
            public string ShotSplitMode { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Novel</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The style ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RealisticPhotography</para>
            /// </summary>
            [NameInMap("StyleId")]
            [Validation(Required=false)]
            public string StyleId { get; set; }

            /// <summary>
            /// <para>The job title.</para>
            /// <para>\- Maximum length: 128 bytes.</para>
            /// <para>\- UTF-8 encoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The video model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wan2.6-r2v-flash</para>
            /// </summary>
            [NameInMap("VideoModel")]
            [Validation(Required=false)]
            public string VideoModel { get; set; }

        }

        /// <summary>
        /// <para>The job result.</para>
        /// </summary>
        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public GetYikeStoryboardJobResponseBodyJobResult JobResult { get; set; }
        public class GetYikeStoryboardJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <para>A list of IDs for storyboards that encountered an exception.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;st_2053348871\&quot;]</para>
            /// </summary>
            [NameInMap("ExceptionStoryboardIds")]
            [Validation(Required=false)]
            public string ExceptionStoryboardIds { get; set; }

            /// <summary>
            /// <para>A list of shots that failed to generate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;errorCode\&quot;:\&quot;NoMediaData\&quot;,\&quot;storyboardId\&quot;:\&quot;st_2118280473\&quot;,\&quot;shotId\&quot;:\&quot;54\&quot;}]</para>
            /// </summary>
            [NameInMap("FailureShotList")]
            [Validation(Required=false)]
            public string FailureShotList { get; set; }

            /// <summary>
            /// <para>The downloadable OSS URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>Detailed information about each storyboard in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;storyboardId\&quot;:\&quot;st_1541525214\&quot;,\&quot;title\&quot;:\&quot;test_1\&quot;,\&quot;status\&quot;:\&quot;Produced\&quot;,\&quot;subStatus\&quot;:\&quot;ProduceSucc\&quot;},{\&quot;storyboardId\&quot;:\&quot;st_1633435355\&quot;,\&quot;title\&quot;:\&quot;test_2\&quot;,\&quot;status\&quot;:\&quot;Produced\&quot;,\&quot;subStatus\&quot;:\&quot;ProduceSucc\&quot;}]</para>
            /// </summary>
            [NameInMap("StoryboardInfoList")]
            [Validation(Required=false)]
            public string StoryboardInfoList { get; set; }

            /// <summary>
            /// <para>A comma-separated list of successful storyboard IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>st_2118280473, st_2118280471</para>
            /// </summary>
            [NameInMap("SuccessStoryboardIds")]
            [Validation(Required=false)]
            public string SuccessStoryboardIds { get; set; }

            /// <summary>
            /// <para>A list of IDs for successful storyboards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;st_2118280473\&quot;]</para>
            /// </summary>
            [NameInMap("SuccessStoryboardList")]
            [Validation(Required=false)]
            public string SuccessStoryboardList { get; set; }

        }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Succeeded</b>: The job completed successfully.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: The job failed to complete.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The job is in progress.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
