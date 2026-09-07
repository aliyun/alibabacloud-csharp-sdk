// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoTranslationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The video translation job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetVideoTranslationJobResponseBodyJob Job { get; set; }
        public class GetVideoTranslationJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The input video duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60.5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The editing project ID for a single-target-language job. For multi-target-language results, retrieve the ID from Output.AiResult.ResultMap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editing-project-001</para>
            /// </summary>
            [NameInMap("EditingProjectId")]
            [Validation(Required=false)]
            public string EditingProjectId { get; set; }

            /// <summary>
            /// <para>The business error code returned when the job fails. This field is typically not returned for non-failed states.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidInput</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The business error message returned when the job fails. This field is typically not returned for non-failed states.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Input video is invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The normalized input configuration JSON string saved at submission time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoMediaId&quot;:&quot;media-video-001&quot;}</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <para>The video translation job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtj_0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The normalized job parameters JSON string, including default values supplemented by the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;SubtitleFrom&quot;:&quot;default&quot;,&quot;NeedDetext&quot;:false,&quot;NeedVisualTranslate&quot;:false}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <para>The normalized job type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VoiceTranslate</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The job output JSON string. When the job succeeds, AiResult.ResultMap organizes the final video, subtitle, and audio outputs by target language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AiResult&quot;:{&quot;ResultMap&quot;:{&quot;en&quot;:{&quot;EditingProjectId&quot;:&quot;editing-project-001&quot;,&quot;MediaURL&quot;:&quot;<a href="https://example.com/video-translation/en/result.mp4%22,%22MediaId%22:%22media-output-001%22%7D%7D%7D%7D">https://example.com/video-translation/en/result.mp4&quot;,&quot;MediaId&quot;:&quot;media-output-001&quot;}}}}</a></para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The job status. Valid values: Created, Queuing, Executing, Finished, or Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID, used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-vt-get-20260820-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
