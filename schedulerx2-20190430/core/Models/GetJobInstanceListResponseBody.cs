// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInstanceListResponseBody : TeaModel {
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
        /// <para>The information about the job instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInstanceListResponseBodyData Data { get; set; }
        public class GetJobInstanceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the job instance.</para>
            /// </summary>
            [NameInMap("JobInstanceDetails")]
            [Validation(Required=false)]
            public List<GetJobInstanceListResponseBodyDataJobInstanceDetails> JobInstanceDetails { get; set; }
            public class GetJobInstanceListResponseBodyDataJobInstanceDetails : TeaModel {
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
                /// <para>A</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The job instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11111111</para>
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
                /// <para>The progress of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>complete</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The execution results of the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
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
                /// <item><description><b>1</b>: The job instance is waiting for execution.</description></item>
                /// <item><description><b>3</b>: The job instance is running.</description></item>
                /// <item><description><b>4</b>: The job instance is successful.</description></item>
                /// <item><description><b>5</b>: The job instance failed.</description></item>
                /// <item><description><b>9</b>: The job instance is rejected.</description></item>
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
                /// <item><description><b>1</b>: cron</description></item>
                /// <item><description><b>3</b>: fix_rate</description></item>
                /// <item><description><b>4</b>: second_delay</description></item>
                /// <item><description><b>100</b>: api</description></item>
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
                /// <para>The trigger type of the job instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The job instance was triggered at the scheduled time.</description></item>
                /// <item><description><b>2</b>: The job instance was triggered due to data updates.</description></item>
                /// <item><description><b>3</b>: The job instance was triggered by an API call.</description></item>
                /// <item><description><b>4</b>: The job instance was triggered because it is manually rerun.</description></item>
                /// <item><description><b>5</b>: The job instance was triggered because the system automatically reruns the job instance upon a system exception, such as a database exception.</description></item>
                /// </list>
                /// <para>Enumeration class: com.alibaba.schedulerx.common.domain.TriggerType</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
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
        /// <para>jobid: 92583 not match groupId: testSchedulerx.defaultGroup</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
