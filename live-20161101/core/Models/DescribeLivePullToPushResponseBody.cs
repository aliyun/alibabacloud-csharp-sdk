// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullToPushResponseBody : TeaModel {
        /// <summary>
        /// <para>The current effective playlist sequence offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CurrentFileIndex")]
        [Validation(Required=false)]
        public int? CurrentFileIndex { get; set; }

        /// <summary>
        /// <para>The current effective video playback offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CurrentOffset")]
        [Validation(Required=false)]
        public int? CurrentOffset { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a05e6b15-15af-405b-a4a2-0152245d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>&quot;0&quot; is returned in normal cases.</description></item>
        /// <item><description>For error cases, refer to the error code list below.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <para>The reason why the task exited. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TriggerByUser: The task was actively ended by the user.</description></item>
        /// <item><description>OverEndTime: The preset end time was exceeded.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the task is in the exited state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TriggerByUser</para>
        /// </summary>
        [NameInMap("TaskExitReason")]
        [Validation(Required=false)]
        public string TaskExitReason { get; set; }

        /// <summary>
        /// <para>The time when the task exited. The value is a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the task is in the exited state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1726354625</para>
        /// </summary>
        [NameInMap("TaskExitTime")]
        [Validation(Required=false)]
        public int? TaskExitTime { get; set; }

        /// <summary>
        /// <para>The ID of the node returned when you create task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb0d4ac7-c7e3-4978-9743-0bf2f6e8****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeLivePullToPushResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeLivePullToPushResponseBodyTaskInfo : TeaModel {
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>The HTTP callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://callback*****.com">https://callback*****.com</a></para>
            /// </summary>
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }

            /// <summary>
            /// <para>The destination ingest URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://pushtest.********.aliyunlive.com/pulltest493/pulltest-w434</para>
            /// </summary>
            [NameInMap("DstUrl")]
            [Validation(Required=false)]
            public string DstUrl { get; set; }

            /// <summary>
            /// <para>The end time of the task. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-27T14:30:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The file index. Playback starts from the nth file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FileIndex")]
            [Validation(Required=false)]
            public int? FileIndex { get; set; }

            [NameInMap("NotifyItemSwitch")]
            [Validation(Required=false)]
            public string NotifyItemSwitch { get; set; }

            /// <summary>
            /// <para>The start offset of the video file. Unit: seconds. The value must be greater than 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Indicates the position from which reading starts, relative to the first frame.</description></item>
            /// <item><description>This parameter is valid only for video-on-demand resources or video files.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public int? Offset { get; set; }

            /// <summary>
            /// <para>The number of times playback repeats after completion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (default): No repeat playback.</description></item>
            /// <item><description>-1: Infinite loop.</description></item>
            /// <item><description>Other positive integers: the number of times playback repeats after completion.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to video-on-demand or third-party video streams.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RepeatNumber")]
            [Validation(Required=false)]
            public int? RepeatNumber { get; set; }

            [NameInMap("ReqAuth")]
            [Validation(Required=false)]
            public string ReqAuth { get; set; }

            /// <summary>
            /// <para>The number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }

            /// <summary>
            /// <para>The retry interval. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RetryInterval")]
            [Validation(Required=false)]
            public int? RetryInterval { get; set; }

            /// <summary>
            /// <para>The source stream protocol name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RTMP</para>
            /// </summary>
            [NameInMap("SourceProtocol")]
            [Validation(Required=false)]
            public string SourceProtocol { get; set; }

            /// <summary>
            /// <para>The source stream type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>live: live stream.</description></item>
            /// <item><description>vod: ApsaraVideo VOD resource.</description></item>
            /// <item><description>url: third-party video file resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The source stream URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://pulltest.****.aliyunlive.com/pulltest493/pulltest-w434</para>
            /// </summary>
            [NameInMap("SourceUrls")]
            [Validation(Required=false)]
            public List<string> SourceUrls { get; set; }

            /// <summary>
            /// <para>The start time of the task. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-26T10:30:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd245384-4067-4f91-9d75-9666a6bc9****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The reason why the task stopped running. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PullStreamFailed: Source stream pulling is abnormal. Retrying.</description></item>
        /// <item><description>PushStreamFailed: Destination stream pushing is abnormal. Retrying.</description></item>
        /// <item><description>UnknownError: Unknown error.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the task is in the stopped state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PullStreamFailed</para>
        /// </summary>
        [NameInMap("TaskInvalidReason")]
        [Validation(Required=false)]
        public string TaskInvalidReason { get; set; }

        /// <summary>
        /// <para>The current status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not started (the start time has not been reached).</description></item>
        /// <item><description>1: Running normally (stream pulling and pushing are both normal).</description></item>
        /// <item><description>2: Running abnormally.</description></item>
        /// <item><description>3: Stopped (stream pulling or pushing is abnormal, or the task was actively stopped by calling an API operation).</description></item>
        /// <item><description>-1: Exited.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

    }

}
