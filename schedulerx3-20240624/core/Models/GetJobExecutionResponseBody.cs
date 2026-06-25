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
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobExecutionResponseBodyData Data { get; set; }
        public class GetJobExecutionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The number of execution attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            /// <summary>
            /// <para>The data timestamp for the job instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11 00:06:10</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The duration of the job execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The time when the job execution ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Details of the executor that ran the job. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;: \&quot;NORMAL\&quot;, \&quot;ActiveCount\&quot;: 4, \&quot;UnavailableCount\&quot;: 0, \&quot;ExpectedCount\&quot;: 4, \&quot;RiskCount\&quot;: 0}</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }

            /// <summary>
            /// <para>The ID of the job execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1310630367761285120</para>
            /// </summary>
            [NameInMap("JobExecutionId")]
            [Validation(Required=false)]
            public string JobExecutionId { get; set; }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>天猫-自动审单</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The type of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxljob</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The parameters of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/avatar/system/services/biz/payment/crontab/monitorpayment.php</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The result of the job execution. The value is a JSON string.</para>
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
            /// <item><description><para><c>1</c>: <c>Round Robin</c></para>
            /// </description></item>
            /// <item><description><para><c>2</c>: <c>Random</c></para>
            /// </description></item>
            /// <item><description><para><c>3</c>: <c>First</c></para>
            /// </description></item>
            /// <item><description><para><c>4</c>: <c>Last</c></para>
            /// </description></item>
            /// <item><description><para><c>5</c>: <c>Least Frequently Used</c></para>
            /// </description></item>
            /// <item><description><para><c>6</c>: <c>Least Recently Used</c></para>
            /// </description></item>
            /// <item><description><para><c>7</c>: <c>Consistent Hashing</c></para>
            /// </description></item>
            /// <item><description><para><c>8</c>: <c>Shard Broadcasting</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteStrategy")]
            [Validation(Required=false)]
            public int? RouteStrategy { get; set; }

            /// <summary>
            /// <para>The scheduled time for the job execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11 00:06:10</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The IP address of the scheduling server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.3.27.76</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The time when the job execution started.</para>
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
            /// <item><description><para><c>0</c>: <c>UNKNOWN</c></para>
            /// </description></item>
            /// <item><description><para><c>1</c>: <c>WAITING</c></para>
            /// </description></item>
            /// <item><description><para><c>2</c>: <c>READY</c></para>
            /// </description></item>
            /// <item><description><para><c>3</c>: <c>RUNNING</c></para>
            /// </description></item>
            /// <item><description><para><c>4</c>: <c>SUCCESS</c></para>
            /// </description></item>
            /// <item><description><para><c>5</c>: <c>FAILED</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The scheduling type of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>-1</c>: <c>none</c></para>
            /// </description></item>
            /// <item><description><para><c>1</c>: <c>cron</c></para>
            /// </description></item>
            /// <item><description><para><c>2</c>: <c>fixed_delay</c></para>
            /// </description></item>
            /// <item><description><para><c>3</c>: <c>fixed_rate</c></para>
            /// </description></item>
            /// <item><description><para><c>5</c>: <c>one_time</c></para>
            /// </description></item>
            /// <item><description><para><c>100</c>: <c>api</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeType")]
            [Validation(Required=false)]
            public int? TimeType { get; set; }

            /// <summary>
            /// <para>Indicates how the job was triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: <c>unknown</c></para>
            /// </description></item>
            /// <item><description><para><c>1</c>: <c>timer_schedule</c></para>
            /// </description></item>
            /// <item><description><para><c>2</c>: <c>rerun</c></para>
            /// </description></item>
            /// <item><description><para><c>3</c>: <c>api_run</c></para>
            /// </description></item>
            /// <item><description><para><c>4</c>: <c>user_retry</c></para>
            /// </description></item>
            /// <item><description><para><c>5</c>: <c>system_retry</c></para>
            /// </description></item>
            /// <item><description><para><c>6</c>: <c>manual</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>timer_schedule</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39938688-0BAB-5AD8-BF02-F4910FAC7589</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
