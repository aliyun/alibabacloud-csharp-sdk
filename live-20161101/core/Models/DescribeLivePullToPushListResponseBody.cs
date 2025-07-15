// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullToPushListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a05e6b15-15af-405b-a4a2-0152245*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeLivePullToPushListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeLivePullToPushListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The current file index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentFileIndex")]
            [Validation(Required=false)]
            public int? CurrentFileIndex { get; set; }

            /// <summary>
            /// <para>The current offset for video playback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentOffset")]
            [Validation(Required=false)]
            public int? CurrentOffset { get; set; }

            /// <summary>
            /// <para>The reason why the task was exited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TriggerByUser: You proactively ended the task.</description></item>
            /// <item><description>OverEndTime: The specified end time was exceeded.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only if the task status is exited.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TriggerByUser</para>
            /// </summary>
            [NameInMap("TaskExitReason")]
            [Validation(Required=false)]
            public string TaskExitReason { get; set; }

            /// <summary>
            /// <para>The time when the task was exited. The value is a Unix timestamp in seconds.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the task status is exited.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1726354625</para>
            /// </summary>
            [NameInMap("TaskExitTime")]
            [Validation(Required=false)]
            public int? TaskExitTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb0d4ac7-c7e3-4978-9743-0bf2f6e8****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The information about the task.</para>
            /// </summary>
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public DescribeLivePullToPushListResponseBodyTaskListTaskInfo TaskInfo { get; set; }
            public class DescribeLivePullToPushListResponseBodyTaskListTaskInfo : TeaModel {
                /// <summary>
                /// <para>The HTTP callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hahaha.com</para>
                /// </summary>
                [NameInMap("CallbackURL")]
                [Validation(Required=false)]
                public string CallbackURL { get; set; }

                /// <summary>
                /// <para>The destination URL to which the stream is relayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://qd.push.lgg.alivecdn.com/testhsc/streamhsc?live_rtmp_*******</para>
                /// </summary>
                [NameInMap("DstUrl")]
                [Validation(Required=false)]
                public string DstUrl { get; set; }

                /// <summary>
                /// <para>The end time of the task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-30T14:30:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The file index, which indicates the sequence of the file where the playback starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FileIndex")]
                [Validation(Required=false)]
                public int? FileIndex { get; set; }

                /// <summary>
                /// <para>The offset of the position where the system starts to read the video resource. Unit: seconds. Valid values: positive numbers.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter indicates an offset from the first frame.</para>
                /// </description></item>
                /// <item><description><para>This parameter is applicable to only video resources from ApsaraVideo VOD or a third party.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The number of playbacks after the first playback is complete. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): specifies that the video list is played only once.</description></item>
                /// <item><description>\-1: specifies that the video list is played in loop mode.</description></item>
                /// <item><description>Positive integer: specifies the number of times the video list repeats after the first playback is complete.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is applicable to only video resources from ApsaraVideo VOD or a third party.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RepeatNumber")]
                [Validation(Required=false)]
                public int? RepeatNumber { get; set; }

                /// <summary>
                /// <para>The number of retries allowed.</para>
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
                /// <para>The protocol of the source stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flv</para>
                /// </summary>
                [NameInMap("SourceProtocol")]
                [Validation(Required=false)]
                public string SourceProtocol { get; set; }

                /// <summary>
                /// <para>The type of the source stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>live: a live stream</description></item>
                /// <item><description>vod: a list of ApsaraVideo VOD resources</description></item>
                /// <item><description>url: a list of video resources from a third party</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vod</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The source URLs.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

                /// <summary>
                /// <para>The start time of the task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-04T09:16:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb0d4ac7-c7e3-4978-9743-0bf2f6e8****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>taskname</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The reason why the task was stopped.</para>
            /// <list type="bullet">
            /// <item><description>PullStreamFailed: An exception occurred while pulling the source stream. A retry is in progress.</description></item>
            /// <item><description>PushStreamFailed: An exception occurred while ingesting the stream. A retry is in progress.</description></item>
            /// <item><description>UnknownError: An unknown exception occurred.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only if the task status is stopped.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PullStreamFailed</para>
            /// </summary>
            [NameInMap("TaskInvalidReason")]
            [Validation(Required=false)]
            public string TaskInvalidReason { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not started.</description></item>
            /// <item><description>1: running. Stream pulling and stream relay are normal.</description></item>
            /// <item><description>2: abnormal.</description></item>
            /// <item><description>3: stopped. It may be because exceptions occur during stream pulling or stream relay or you proactively call the StopLivePullToPush operation.</description></item>
            /// <item><description>\-1: exited.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
