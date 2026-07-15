// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the job instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInstanceResponseBodyData Data { get; set; }
        public class GetJobInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the job instance.</para>
            /// </summary>
            [NameInMap("JobInstanceDetail")]
            [Validation(Required=false)]
            public GetJobInstanceResponseBodyDataJobInstanceDetail JobInstanceDetail { get; set; }
            public class GetJobInstanceResponseBodyDataJobInstanceDetail : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-07-27 11:52:10</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The end time of the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-07-27 11:52:10</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The user who executes the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Smith</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The job instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1189853849</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92583</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ManualJob</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The parameters of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;alertId\&quot;:11111}</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The progress of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;taskProgress&quot;:[{&quot;name&quot;:&quot;MAP_TASK_ROOT&quot;,&quot;total&quot;:1,&quot;pulled&quot;:1,&quot;running&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0}],&quot;workerProgress&quot;:[{&quot;workerAddr&quot;:&quot;11.122.241.245:34865&quot;,&quot;total&quot;:1,&quot;pulled&quot;:1,&quot;running&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0}]}</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The execution results of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;TotalSize\&quot;: 31, \&quot;CurrentPage\&quot;: 5, \&quot;PageSize\&quot;: 10}</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The time when the job was scheduled to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-07-27 11:52:10</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The start time of the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-07-27 11:52:10</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The state of the job instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: The job instance is waiting for execution.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: The job instance is running.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: The job instance is successful.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: The job instance failed.</para>
                /// </description></item>
                /// <item><description><para><b>9</b>: The job instance is rejected.</para>
                /// </description></item>
                /// </list>
                /// <para>Enumeration class: com.alibaba.schedulerx.common.domain.InstanceStatus</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The method that is used to specify the time when to schedule the job instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: cron</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: fix_rate</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: second_delay</para>
                /// </description></item>
                /// <item><description><para><b>100</b>: api</para>
                /// </description></item>
                /// </list>
                /// <para>Enumeration class: com.alibaba.schedulerx.common.domain.TimeType</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <para>The trace ID, which can be used to query trace details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>210e845016596663430048015d0a2c</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// <para>The trigger type of the job instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: The job instance was triggered at the scheduled time.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: The job instance was triggered due to data update.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: The job instance was triggered by an API call.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: The job instance was triggered because it is manually rerun.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: The job instance was triggered because the system automatically reruns the job instance upon a system exception, such as a database exception.</para>
                /// </description></item>
                /// </list>
                /// <para>Enumeration class: com.alibaba.schedulerx.common.domain.TriggerType</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

                /// <summary>
                /// <para>The endpoint of the triggered client. The value is in the IP address:Port number format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0:16</para>
                /// </summary>
                [NameInMap("WorkAddr")]
                [Validation(Required=false)]
                public string WorkAddr { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message that is returned only if the corresponding error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobId=xxx is not existed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
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
