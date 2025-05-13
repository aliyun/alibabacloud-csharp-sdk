// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInfoResponseBody : TeaModel {
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
        /// <para>The details of the job.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configurations of the job.</para>
            /// </summary>
            [NameInMap("JobConfigInfo")]
            [Validation(Required=false)]
            public GetJobInfoResponseBodyDataJobConfigInfo JobConfigInfo { get; set; }
            public class GetJobInfoResponseBodyDataJobConfigInfo : TeaModel {
                /// <summary>
                /// <para>The interval at which the system retried to run the job after a job failure. Default value: 30. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <para>The full path of the job interface class. This parameter is returned only for jobs whose job type is Java.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.test.helloword</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The script of a script job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo &quot;clear&quot; &gt; /home/admin/edas-container/logs/catalina.out</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The description of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The execution mode of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Stand-alone operation</b>: standalone</description></item>
                /// <item><description><b>Broadcast run</b>: broadcast</description></item>
                /// <item><description><b>Visual MapReduce</b>: parallel</description></item>
                /// <item><description><b>MapReduce</b>: batch</description></item>
                /// <item><description><b>Shard run</b>: sharding</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standalone</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// <para>The full path used to upload files to Object Storage Service (OSS).</para>
                /// <para>If you use a JAR package, you can upload the JAR package to this OSS path.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/schedulerX/test.jar">https://test.oss-cn-hangzhou.aliyuncs.com/schedulerX/test.jar</a></para>
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>538039</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The monitoring information of the job.</para>
                /// </summary>
                [NameInMap("JobMonitorInfo")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo JobMonitorInfo { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo : TeaModel {
                    /// <summary>
                    /// <para>The alert contact Information.</para>
                    /// </summary>
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo : TeaModel {
                        /// <summary>
                        /// <para>The webhook URL of the DingTalk chatbot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=XXXXXX">https://oapi.dingtalk.com/robot/send?access_token=XXXXXX</a></para>
                        /// </summary>
                        [NameInMap("Ding")]
                        [Validation(Required=false)]
                        public string Ding { get; set; }

                        /// <summary>
                        /// <para>The email address of the alert contact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="mailto:user@demo.com">user@demo.com</a></para>
                        /// </summary>
                        [NameInMap("UserMail")]
                        [Validation(Required=false)]
                        public string UserMail { get; set; }

                        /// <summary>
                        /// <para>The name of the alert contact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userA</para>
                        /// </summary>
                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public string UserName { get; set; }

                        /// <summary>
                        /// <para>The mobile phone number of the alert contact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1381111****</para>
                        /// </summary>
                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of the alerting features and the alert thresholds.</para>
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the Failure alarm switch was turned on. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the No machine alarm available switch was turned on.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// <para>The method used to send alerts. Only Short Message Service (SMS) is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sms</para>
                        /// </summary>
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }

                        /// <summary>
                        /// <para>The timeout threshold. Default value: 7200. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12300</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the Timeout alarm switch was turned on. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the Timeout termination switch was turned on. The switch is turned off by default.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("TimeoutKillEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutKillEnable { get; set; }

                    }

                }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The advanced configurations of the job.</para>
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// <para>The number of threads that were triggered by a single worker at a time. Default value: 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ConsumerSize")]
                    [Validation(Required=false)]
                    public int? ConsumerSize { get; set; }

                    /// <summary>
                    /// <para>The number of task distribution threads. Default value: 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("DispatcherSize")]
                    [Validation(Required=false)]
                    public int? DispatcherSize { get; set; }

                    /// <summary>
                    /// <para>The number of tasks that were pulled by a parallel job at a time. Default value: 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <para>The maximum number of tasks that can be queued. Default value: 10000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    /// <summary>
                    /// <para>The interval at which the system retried to run the task after a task failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TaskAttemptInterval")]
                    [Validation(Required=false)]
                    public int? TaskAttemptInterval { get; set; }

                    /// <summary>
                    /// <para>The number of retries after a task failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TaskMaxAttempt")]
                    [Validation(Required=false)]
                    public int? TaskMaxAttempt { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of retries after a job failure. This parameter was specified based on your business requirements. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrent instances. Default value: 1. The default value indicates that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the next instance is reached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>helloworld</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user-defined parameters that you can obtain when the job is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>Indicates whether the job was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The job was enabled and could be triggered.</description></item>
                /// <item><description><b>0</b>: The job was disabled and could not be triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time configurations.</para>
                /// </summary>
                [NameInMap("TimeConfig")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoTimeConfig TimeConfig { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>Custom calendar days specified if TimeType is set to <b>1</b> (cron).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Business days</para>
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// <para>The time offset specified if TimeType is set to <b>1</b> (cron). Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// <para>The time expression specified based on the value of TimeType:</para>
                    /// <list type="bullet">
                    /// <item><description>If TimeType is set to <b>100</b> (api), no time expression is required.</description></item>
                    /// <item><description>If TimeType is set to <b>3</b> (fix_rate), this parameter value indicates the specific and fixed frequency. For example, if the value is 30, the system triggers a job every 30 seconds.</description></item>
                    /// <item><description>If TimeType is set to <b>1</b> (cron), this parameter value indicates the standard CRON expression used to specify the time when to schedule the job.</description></item>
                    /// <item><description>If TimeType is set to <b>4</b> (second_delay), this parameter value indicates the fixed delay after which the job is triggered. Valid values: 1 to 60. Unit: seconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0/10 * * * ?</para>
                    /// </summary>
                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    /// <summary>
                    /// <para>The time type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: cron</description></item>
                    /// <item><description><b>3</b>: fix_rate</description></item>
                    /// <item><description><b>4</b>: second_delay</description></item>
                    /// <item><description><b>5</b>: one_time</description></item>
                    /// <item><description><b>100</b>: api</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimeType")]
                    [Validation(Required=false)]
                    public int? TimeType { get; set; }

                }

                /// <summary>
                /// <para>The extended fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;pageSize&quot;:5,&quot;queueSize&quot;:10,&quot;consumerSize&quot;:5,&quot;dispatcherSize&quot;:5,&quot;taskMaxAttempt&quot;:0,&quot;taskAttemptInterval&quot;:0,&quot;globalConsumerSize&quot;:1000,&quot;taskDispatchMode&quot;:&quot;push&quot;}</para>
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned only if an error occurs.</para>
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
        /// <para>Indicates whether the job details were obtained. Valid values:</para>
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
