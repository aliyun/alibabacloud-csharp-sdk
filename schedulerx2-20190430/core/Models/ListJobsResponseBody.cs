// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListJobsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListJobsResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the jobs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The jobs and their details.</para>
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataJobs> Jobs { get; set; }
            public class ListJobsResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>The interval at which the system retries to run the job after a job failure. Unit: seconds. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <para>The full path of the job interface class. This parameter is returned only for a Java job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.schedulerx.test.helloworld</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The script of the job. This parameter is returned only for a Python, Shell, or Go job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo \&quot;hello\&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The description of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The execution mode of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>standalone</b>: The job runs in standalone mode.</description></item>
                /// <item><description><b>broadcast</b>: The job runs in broadcast mode.</description></item>
                /// <item><description><b>parallel</b>: The job runs in parallel computing mode.</description></item>
                /// <item><description><b>grid</b>: The job runs in memory grid mode.</description></item>
                /// <item><description><b>batch</b>: The job runs in grid computing mode.</description></item>
                /// <item><description><b>shard</b>: The job runs in multipart mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standalone</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// <para>The full path to which a JAR package is uploaded in Object Storage Service (OSS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>https:doc***.oss-cn-hangzhou.aliyuncs.com/sc-****-D-0.0.2-SNAPSHOT.jar</para>
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// <para>The ID of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99341</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The monitoring information of the job.</para>
                /// </summary>
                [NameInMap("JobMonitorInfo")]
                [Validation(Required=false)]
                public ListJobsResponseBodyDataJobsJobMonitorInfo JobMonitorInfo { get; set; }
                public class ListJobsResponseBodyDataJobsJobMonitorInfo : TeaModel {
                    /// <summary>
                    /// <para>The contact information.</para>
                    /// </summary>
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo : TeaModel {
                        /// <summary>
                        /// <para>The webhook URL of the DingTalk chatbot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>**********</para>
                        /// </summary>
                        [NameInMap("Ding")]
                        [Validation(Required=false)]
                        public string Ding { get; set; }

                        /// <summary>
                        /// <para>The email address of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="mailto:user@mail.com">user@mail.com</a></para>
                        /// </summary>
                        [NameInMap("UserMail")]
                        [Validation(Required=false)]
                        public string UserMail { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userA</para>
                        /// </summary>
                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public string UserName { get; set; }

                        /// <summary>
                        /// <para>The mobile number of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1381111****</para>
                        /// </summary>
                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of the alerting feature and the alert threshold.</para>
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the feature of generating an alert upon a failure is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: The feature is enabled.</description></item>
                        /// <item><description><b>false</b>: The feature is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the feature of generating an alert when no machine is available for running the job is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// <para>The method that is used to send an alert notification. Only Short Message Service (SMS) is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sms</para>
                        /// </summary>
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }

                        /// <summary>
                        /// <para>The timeout threshold. Unit: seconds. Default value: 7200.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12300</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the feature of generating an alert upon a timeout is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: The feature is enabled.</description></item>
                        /// <item><description><b>false</b>: The feature is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the feature of stopping job triggering upon a timeout is enabled. By default, the feature is disabled.</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: The feature is enabled.</description></item>
                        /// <item><description><b>false</b>: The feature is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("TimeoutKillEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutKillEnable { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The advanced configurations of the job. The parameters are returned only if the value of the ExecuteMode parameter is parallel, grid, or batch.</para>
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public ListJobsResponseBodyDataJobsMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class ListJobsResponseBodyDataJobsMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// <para>The number of threads that are triggered by a standalone job at a time. Default value: 5.</para>
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
                    /// <para>The number of tasks that are pulled by a parallel job at a time. Default value: 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <para>The maximum number of task queues that can be cached. Default value: 10000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    /// <summary>
                    /// <para>The interval at which the system retries to run the task after a task failure.</para>
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
                /// <para>The maximum number of retries after a job failure. This parameter is specified based on your business requirements. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <para>The maximum number of instances that can concurrently run for the job. Default value: 1. A value of 1 indicates that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the instance is reached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The name of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>helloworld</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user-defined parameters. These parameters can be obtained when the job is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>Indicates whether the job is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The job is enabled and can be triggered.</description></item>
                /// <item><description><b>0</b>: The job is disabled and cannot be triggered.</description></item>
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
                public ListJobsResponseBodyDataJobsTimeConfig TimeConfig { get; set; }
                public class ListJobsResponseBodyDataJobsTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>If the TimeType parameter is set to cron, you can specify custom calendar days.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Business days</para>
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// <para>The time offset if the TimeType parameter is set to cron. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// <para>The time expression. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>api</b>: indicates that no time expression is used to specify the time when to schedule the job.</description></item>
                    /// <item><description><b>fix_rate</b>: indicates that the job is triggered at a fixed frequency. For example, a value of 30 indicates that the job is triggered every 30 seconds.</description></item>
                    /// <item><description><b>cron</b>: indicates that a standard CRON expression is used to specify the time when to schedule the job.</description></item>
                    /// <item><description><b>second_delay</b>: indicates that the job is triggered after a fixed delay. Valid values: 1 to 60. Unit: seconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0/10 * * * ?</para>
                    /// </summary>
                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    /// <summary>
                    /// <para>The method that is used to specify the time when to schedule the job. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: cron</description></item>
                    /// <item><description><b>3</b>: fix_rate</description></item>
                    /// <item><description><b>4</b>: second_delay</description></item>
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
        /// <para>The error message that is returned if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace can not find namespace: 1a72ecb1-b4cc-400a-a71b-20cdec9b****, namespaceSource:null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71BCC0E3-64B2-4B63-A870-AFB64EBCB58B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
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
