// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoTranslationJobResponseBody : TeaModel {
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetVideoTranslationJobResponseBodyJob Job { get; set; }
        public class GetVideoTranslationJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ba50304145fd411c827239c398820267</para>
            /// </summary>
            [NameInMap("EditingProjectId")]
            [Validation(Required=false)]
            public string EditingProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidInput</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Input is invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Video&quot;:&quot;<a href="https://example.com/input.mp4%22%7D">https://example.com/input.mp4&quot;}</a></para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vtj_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;NeedDetext&quot;:true,&quot;SubtitleFrom&quot;:&quot;default&quot;,&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;NeedVisualTranslate&quot;:true}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VoiceTranslate</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;AiResult&quot;:{&quot;ResultMap&quot;:{&quot;ja&quot;:{&quot;EditingProjectId&quot;:&quot;editing-project-xxx&quot;,&quot;MediaURL&quot;:&quot;<a href="https://example.com/bucket/prefix/ja/result.mp4%22%7D%7D%7D%7D">https://example.com/bucket/prefix/ja/result.mp4&quot;}}}}</a></para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
