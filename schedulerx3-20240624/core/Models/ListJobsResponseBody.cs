// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataRecords> Records { get; set; }
            public class ListJobsResponseBodyDataRecords : TeaModel {
                [NameInMap("AppGroupId")]
                [Validation(Required=false)]
                public long? AppGroupId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The retry interval upon a fault. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <para>The calendar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>work-day</para>
                /// </summary>
                [NameInMap("Calendar")]
                [Validation(Required=false)]
                public string Calendar { get; set; }

                /// <summary>
                /// <para>The child job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1246</para>
                /// </summary>
                [NameInMap("ChildJobId")]
                [Validation(Required=false)]
                public string ChildJobId { get; set; }

                /// <summary>
                /// <para>The cleanup mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cleanMode&quot;:&quot;NUM_ONLY&quot;,&quot;totalRemain&quot;:300}</para>
                /// </summary>
                [NameInMap("CleanMode")]
                [Validation(Required=false)]
                public string CleanMode { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The current execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: not started</description></item>
                /// <item><description>1: running</description></item>
                /// <item><description>2: queued</description></item>
                /// <item><description>3: waiting</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentExecuteStatus")]
                [Validation(Required=false)]
                public int? CurrentExecuteStatus { get; set; }

                /// <summary>
                /// <para>The data offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DataOffset")]
                [Validation(Required=false)]
                public int? DataOffset { get; set; }

                /// <summary>
                /// <para>The dependency check strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DependentStrategy")]
                [Validation(Required=false)]
                public int? DependentStrategy { get; set; }

                /// <summary>
                /// <para>The job description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job01单机任务</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The client-side blocking strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: serial execution on a single machine</description></item>
                /// <item><description>2: ignore subsequent triggers</description></item>
                /// <item><description>3: override previous triggers</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecutorBlockStrategy")]
                [Validation(Required=false)]
                public string ExecutorBlockStrategy { get; set; }

                /// <summary>
                /// <para>The jobhandler name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jobDemoHandler</para>
                /// </summary>
                [NameInMap("JobHandler")]
                [Validation(Required=false)]
                public string JobHandler { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>74</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxljob</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The end time of the last execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-29 15:56:36</para>
                /// </summary>
                [NameInMap("LastExecuteEndTime")]
                [Validation(Required=false)]
                public string LastExecuteEndTime { get; set; }

                /// <summary>
                /// <para>The result of the last execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>4: succeeded</description></item>
                /// <item><description>5: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LastExecuteStatus")]
                [Validation(Required=false)]
                public int? LastExecuteStatus { get; set; }

                /// <summary>
                /// <para>The maximum number of retry attempts upon failure. Set this value based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrent instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public int? MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// <para>The notice configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;failLimitTimes&quot;:1,&quot;failEnable&quot;:true,&quot;timeoutKillEnable&quot;:false,&quot;missWorkerEnable&quot;:true,&quot;timeoutEnable&quot;:true,&quot;sendChannel&quot;:&quot;&quot;,&quot;timeout&quot;:300,&quot;successNotice&quot;:false}</para>
                /// </summary>
                [NameInMap("NoticeConfig")]
                [Validation(Required=false)]
                public string NoticeConfig { get; set; }

                /// <summary>
                /// <para>The notification contacts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;contactType&quot;:1,&quot;name&quot;:&quot;恰橙&quot;}]</para>
                /// </summary>
                [NameInMap("NoticeContacts")]
                [Validation(Required=false)]
                public string NoticeContacts { get; set; }

                /// <summary>
                /// <para>The job parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name=10</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The job execution priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The routing strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: round-robin</description></item>
                /// <item><description>2: random</description></item>
                /// <item><description>3: first</description></item>
                /// <item><description>4: last</description></item>
                /// <item><description>5: least frequently used</description></item>
                /// <item><description>6: least recently used</description></item>
                /// <item><description>7: consistent hashing</description></item>
                /// <item><description>8: shard broadcast</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteStrategy")]
                [Validation(Required=false)]
                public int? RouteStrategy { get; set; }

                /// <summary>
                /// <para>The script content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash
                /// echo &quot;xxl-job: hello shell&quot;
                /// echo &quot;Good bye!&quot;
                /// exit 0</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// <para>The start time type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartTimeType")]
                [Validation(Required=false)]
                public int? StartTimeType { get; set; }

                /// <summary>
                /// <para>The job status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: disabled</description></item>
                /// <item><description>1: enabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 12 * * ?</para>
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// <para>The time type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>-1: none</description></item>
                /// <item><description>1: cron</description></item>
                /// <item><description>3: fix_rate</description></item>
                /// <item><description>5: one_time</description></item>
                /// <item><description>100: api</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hongkong</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HangKong</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para>The job weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

                /// <summary>
                /// <para>The extended attributes.</para>
                /// <remarks>
                /// <para>Not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("Xattrs")]
                [Validation(Required=false)]
                public string Xattrs { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DF6732E-15D8-5E1F-95E3-C10077F556B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
