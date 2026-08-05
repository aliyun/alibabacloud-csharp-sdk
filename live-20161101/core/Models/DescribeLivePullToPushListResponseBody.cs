// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullToPushListResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of query records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a05e6b15-15af-405b-a4a2-0152245*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Task information list.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeLivePullToPushListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeLivePullToPushListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>Currently effective playlist sequence offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentFileIndex")]
            [Validation(Required=false)]
            public int? CurrentFileIndex { get; set; }

            /// <summary>
            /// <para>Currently effective video playback offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentOffset")]
            [Validation(Required=false)]
            public int? CurrentOffset { get; set; }

            /// <summary>
            /// <para>Task exit reason:</para>
            /// <list type="bullet">
            /// <item><description>TriggerByUser: Actively ended by user.</description></item>
            /// <item><description>OverEndTime: Exceeded the preset end time.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only returned when the task is in exited state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TriggerByUser</para>
            /// </summary>
            [NameInMap("TaskExitReason")]
            [Validation(Required=false)]
            public string TaskExitReason { get; set; }

            /// <summary>
            /// <para>Task exit time, Unix timestamp in seconds.</para>
            /// <remarks>
            /// <para>Only returned when the task is in exited state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1726354625</para>
            /// </summary>
            [NameInMap("TaskExitTime")]
            [Validation(Required=false)]
            public int? TaskExitTime { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb0d4ac7-c7e3-4978-9743-0bf2f6e8****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task information.</para>
            /// </summary>
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public DescribeLivePullToPushListResponseBodyTaskListTaskInfo TaskInfo { get; set; }
            public class DescribeLivePullToPushListResponseBodyTaskListTaskInfo : TeaModel {
                /// <summary>
                /// <para>HTTP callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hahaha.com</para>
                /// </summary>
                [NameInMap("CallbackURL")]
                [Validation(Required=false)]
                public string CallbackURL { get; set; }

                /// <summary>
                /// <para>Destination push stream URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://qd.push.lgg.alivecdn.com/testhsc/streamhsc?live_rtmp_*******</para>
                /// </summary>
                [NameInMap("DstUrl")]
                [Validation(Required=false)]
                public string DstUrl { get; set; }

                /// <summary>
                /// <para>Task end time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-30T14:30:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>File index, starts playback from the nth file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FileIndex")]
                [Validation(Required=false)]
                public int? FileIndex { get; set; }

                /// <summary>
                /// <para>Start offset, the starting offset value of the video file. Unit: seconds. Value: greater than 0.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Indicates the position to start reading from, relative to the first frame.</description></item>
                /// <item><description>Only valid for VOD resources or video files.</description></item>
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
                /// <para>Number of times to repeat playback after completion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): No repeat playback.</description></item>
                /// <item><description>-1: Loop indefinitely.</description></item>
                /// <item><description>Other positive integers: Number of times to repeat playback after completion.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter only applies to VOD or third-party video streams.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RepeatNumber")]
                [Validation(Required=false)]
                public int? RepeatNumber { get; set; }

                /// <summary>
                /// <para>Number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public int? RetryCount { get; set; }

                /// <summary>
                /// <para>Retry interval, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RetryInterval")]
                [Validation(Required=false)]
                public int? RetryInterval { get; set; }

                /// <summary>
                /// <para>Source stream protocol name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flv</para>
                /// </summary>
                [NameInMap("SourceProtocol")]
                [Validation(Required=false)]
                public string SourceProtocol { get; set; }

                /// <summary>
                /// <para>Source stream type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>live: Live stream.</description></item>
                /// <item><description>vod: Alibaba Cloud Video on Demand resource.</description></item>
                /// <item><description>url: Third-party video file resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vod</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Source stream URL addresses.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

                /// <summary>
                /// <para>Task start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-04T09:16:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb0d4ac7-c7e3-4978-9743-0bf2f6e8****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>Task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>taskname</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>Reason for task stopping:</para>
            /// <list type="bullet">
            /// <item><description>PullStreamFailed: Source stream pulling exception, retrying.</description></item>
            /// <item><description>PushStreamFailed: Destination stream pushing exception, retrying.</description></item>
            /// <item><description>UnknownError: Unknown exception.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only returned when the task is in stopped state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PullStreamFailed</para>
            /// </summary>
            [NameInMap("TaskInvalidReason")]
            [Validation(Required=false)]
            public string TaskInvalidReason { get; set; }

            /// <summary>
            /// <para>Current task status:</para>
            /// <list type="bullet">
            /// <item><description>0: Not started (start time has not been reached).</description></item>
            /// <item><description>1: Running normally (stream pulling and pushing are normal).</description></item>
            /// <item><description>2: Running abnormally.</description></item>
            /// <item><description>3: Stopped (stream pulling or pushing is abnormal, or the task was actively stopped by calling the API).</description></item>
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

        /// <summary>
        /// <para>Total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
