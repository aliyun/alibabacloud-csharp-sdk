// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionResponseBody : TeaModel {
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
        /// <para>The details of the job execution.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobExecutionResponseBodyData Data { get; set; }
        public class GetJobExecutionResponseBodyData : TeaModel {
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
            /// <para>The number of failed attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            /// <summary>
            /// <para>The node data timestamp. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11 00:06:10</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The total running duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The expiration time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The executor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;: \&quot;NORMAL\&quot;, \&quot;ActiveCount\&quot;: 4, \&quot;UnavailableCount\&quot;: 0, \&quot;ExpectedCount\&quot;: 4, \&quot;RiskCount\&quot;: 0}</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }

            /// <summary>
            /// <para>The job execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1310630367761285120</para>
            /// </summary>
            [NameInMap("JobExecutionId")]
            [Validation(Required=false)]
            public string JobExecutionId { get; set; }

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
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tmall-AutoOrderReview</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

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
            /// <para>The job parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/avatar/system/services/biz/payment/crontab/monitorpayment.php</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

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
            /// <item><description>8: sharding broadcast</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteStrategy")]
            [Validation(Required=false)]
            public int? RouteStrategy { get; set; }

            /// <summary>
            /// <para>The job scheduling time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11 00:06:10</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.3.27.76</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The start time of the job execution. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11 00:06:10</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The job execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: UNKNOWN.</description></item>
            /// <item><description>1: WAITING.</description></item>
            /// <item><description>2: READY.</description></item>
            /// <item><description>3: RUNNING.</description></item>
            /// <item><description>4: SUCCESS.</description></item>
            /// <item><description>5: FAILED.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: none</description></item>
            /// <item><description>1: cron</description></item>
            /// <item><description>2: fixed_delay</description></item>
            /// <item><description>3: fixed_rate</description></item>
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
            /// <para>The job trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unknown</description></item>
            /// <item><description>1: timer_schedule</description></item>
            /// <item><description>2: rerun</description></item>
            /// <item><description>3: api_run</description></item>
            /// <item><description>4: user_retry</description></item>
            /// <item><description>5: system_retry</description></item>
            /// <item><description>6: manual</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public int? TriggerType { get; set; }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>39938688-0BAB-5AD8-BF02-F4910FAC7589</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
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
