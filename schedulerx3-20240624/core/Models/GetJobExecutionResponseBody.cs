// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionResponseBody : TeaModel {
        /// <summary>
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
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;: \&quot;NORMAL\&quot;, \&quot;ActiveCount\&quot;: 4, \&quot;UnavailableCount\&quot;: 0, \&quot;ExpectedCount\&quot;: 4, \&quot;RiskCount\&quot;: 0}</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1310630367761285120</para>
            /// </summary>
            [NameInMap("JobExecutionId")]
            [Validation(Required=false)]
            public string JobExecutionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxljob</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/avatar/system/services/biz/payment/crontab/monitorpayment.php</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteStrategy")]
            [Validation(Required=false)]
            public int? RouteStrategy { get; set; }

            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.3.27.76</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-11T00:06:10Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeType")]
            [Validation(Required=false)]
            public int? TimeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>timer_schedule</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public int? TriggerType { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
