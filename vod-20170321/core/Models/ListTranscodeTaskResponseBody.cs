// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of transcoding task information.</para>
        /// </summary>
        [NameInMap("TranscodeTaskList")]
        [Validation(Required=false)]
        public List<ListTranscodeTaskResponseBodyTranscodeTaskList> TranscodeTaskList { get; set; }
        public class ListTranscodeTaskResponseBodyTranscodeTaskList : TeaModel {
            /// <summary>
            /// <para>The time when the transcoding task was complete. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:40:12Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the transcoding task was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:35:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The status of the transcoding task.</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b>: in progress.</description></item>
            /// <item><description><b>Partial</b>: partially completed.</description></item>
            /// <item><description><b>CompleteAllSucc</b>: all transcoding jobs are complete and successful.</description></item>
            /// <item><description><b>CompleteAllFail</b>: all transcoding jobs are complete but all failed. If the source file has issues, no transcoding jobs are initiated and the entire transcoding task fails.</description></item>
            /// <item><description><b>CompletePartialSucc</b>: all transcoding jobs are complete but only some are successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The transcoding task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1b65ab107*****ba3dbb900f6c1fe0</para>
            /// </summary>
            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group used for transcoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b500c7094bd24*****f3e9900752d7c3</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Auto</b>: automatically triggered after a video is uploaded.</description></item>
            /// <item><description><b>Manual</b>: triggered by calling the SubmitTranscodeJobs operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d4860fcc6a5*****bce9fed52e893824</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
