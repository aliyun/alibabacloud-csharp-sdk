// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikeAgentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the task started. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:34.001+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error code. This parameter is returned only when the task is in the Failed state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowTaskFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The time when the task ended. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:34.001+08:00</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82df****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The input parameters of the task. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TextType\&quot;:2,\&quot;TextContent\&quot;:\&quot;Today, Beijing held a press conference to announce plans to further optimize the city\&quot;s transportation network, including adding three new subway lines within the next three years....\&quot;,\&quot;AspectRatio\&quot;:\&quot;16:9\&quot;, \&quot;Resolution\&quot;:\&quot;720P\&quot;, \&quot;OutputLanguages\&quot;:[\&quot;CN\&quot;,\&quot;YUE\&quot;]&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The task results. This parameter is valid only when the task is in the Succeeded state.</para>
        /// </summary>
        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public List<GetYikeAgentJobResponseBodyJobResult> JobResult { get; set; }
        public class GetYikeAgentJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <para>The online editing project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a6adbbd181437eb5030d3d93e0182d</para>
            /// </summary>
            [NameInMap("EditingProjectId")]
            [Validation(Required=false)]
            public string EditingProjectId { get; set; }

            /// <summary>
            /// <para>The asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9d7e982012c671f1b803e7f6d75a6302</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The output language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("OutputLanguage")]
            [Validation(Required=false)]
            public string OutputLanguage { get; set; }

            /// <summary>
            /// <para>The download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/videos/task_abc123def456.mp4">https://test.oss-cn-shanghai.aliyuncs.com/videos/task_abc123def456.mp4</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

        }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>The agent task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VoiceNarrator: narration video without a digital human.</description></item>
        /// <item><description>AvatarNarrator: narration video with a digital human.</description></item>
        /// <item><description>VideoClone: video cloning.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VoiceNarrator</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom user data that was passed in when the task was created. The value is returned as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
