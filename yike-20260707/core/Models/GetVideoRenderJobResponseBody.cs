// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoRenderJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The video rendering and compositing task object.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetVideoRenderJobResponseBodyJob Job { get; set; }
        public class GetVideoRenderJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The ID of the online editing project, which can be used for secondary editing of the produced video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8239345231244512***</para>
            /// </summary>
            [NameInMap("EditingProjectId")]
            [Validation(Required=false)]
            public string EditingProjectId { get; set; }

            /// <summary>
            /// <para>The error code. This parameter is returned when the job is in the Failed state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is returned when the job is in the Failed state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified product does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68ca759e798b40b4903b255*******</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The voiceover language of the produced video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The download URL of the rendered and composited video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.mp4">https://xxxx.mp4</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The job is created.</description></item>
            /// <item><description>Executing: The job is being executed.</description></item>
            /// <item><description>Finished: The job is completed.</description></item>
            /// <item><description>Failed: The job failed.</description></item>
            /// <item><description>Deleted: The job is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined parameter, which is a JSON-formatted string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

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
