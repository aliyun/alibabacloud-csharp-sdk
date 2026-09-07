// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoDetextJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The video text erasure task.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetVideoDetextJobResponseBodyJob Job { get; set; }
        public class GetVideoDetextJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The business error code returned when the task fails. This field is typically not returned for non-failure states.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidInput</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The business error message returned when the task fails. This field is typically not returned for non-failure states.</para>
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
            /// <para>The video text erasure task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vdt_0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The normalized text erasure parameter JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;EraseAllText&quot;:false,&quot;TextTargets&quot;:[{&quot;Box&quot;:[0.1,0.8,0.8,0.15],&quot;TimeRanges&quot;:[[0,30]]}]}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <para>The task type. The value is fixed to VIDEO_DETEXT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIDEO_DETEXT</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The task output JSON string. When the task succeeds, AiResult.DetextVideoURL contains the URL of the video with text erased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AiResult&quot;:{&quot;DetextVideoURL&quot;:&quot;<a href="https://example.com/detext/detext.mp4%22%7D%7D">https://example.com/detext/detext.mp4&quot;}}</a></para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The task status. Valid values: Created, Queuing, Executing, Finished, and Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-detext-get-20260820-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
