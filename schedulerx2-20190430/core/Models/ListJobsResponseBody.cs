// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The node list information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The node list and node details.</para>
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataJobs> Jobs { get; set; }
            public class ListJobsResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>The retry interval on error, in seconds. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <para>The full path of the node interface class. This field is returned only when the node is of the Java type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.schedulerx.test.helloworld</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The script code content for Python, Shell, or Go node types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo \&quot;hello\&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The node description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The node execution mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>standalone</b>: standalone</para>
                /// </description></item>
                /// <item><description><para><b>broadcast</b>: broadcast</para>
                /// </description></item>
                /// <item><description><para><b>parallel</b>: parallel computing</para>
                /// </description></item>
                /// <item><description><para><b>grid</b>: memory grid</para>
                /// </description></item>
                /// <item><description><para><b>batch</b>: grid computing</para>
                /// </description></item>
                /// <item><description><para><b>shard</b>: shard</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standalone</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// <para>The full path of the JAR package in OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https:doc***.oss-cn-hangzhou.aliyuncs.com/sc-****-D-0.0.2-SNAPSHOT.jar</para>
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99341</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The node monitoring information.</para>
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
                        /// <para>The mobile phone number of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1381111****</para>
                        /// </summary>
                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    /// <summary>
                    /// <para>The alert switch and threshold configuration.</para>
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable the failure alert switch. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>true</b>: Enabled.</para>
                        /// </description></item>
                        /// <item><description><para><b>false</b>: Disabled.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the no-available-machine alert.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// <para>The alert notification method. Currently, only sms is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sms</para>
                        /// </summary>
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }

                        /// <summary>
                        /// <para>The timeout threshold, in seconds. Default value: 7200.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12300</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the timeout alert switch. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>true</b>: Enabled.</para>
                        /// </description></item>
                        /// <item><description><para><b>false</b>: Disabled.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the timeout termination switch for the current trigger. This is disabled by default. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>true</b>: Enabled.</para>
                        /// </description></item>
                        /// <item><description><para><b>false</b>: Disabled.</para>
                        /// </description></item>
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
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The advanced configuration. This is used only for parallel computing, memory grid, and grid computing.</para>
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public ListJobsResponseBodyDataJobsMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class ListJobsResponseBodyDataJobsMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// <para>The number of threads for a single trigger on a single machine. Default value: 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ConsumerSize")]
                    [Validation(Required=false)]
                    public int? ConsumerSize { get; set; }

                    /// <summary>
                    /// <para>The number of subtask dispatch threads. Default value: 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("DispatcherSize")]
                    [Validation(Required=false)]
                    public int? DispatcherSize { get; set; }

                    /// <summary>
                    /// <para>The number of subtasks pulled per batch for a parallel node. Default value: 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <para>The upper limit of the subtask queue cache. Default value: 10000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    /// <summary>
                    /// <para>The retry interval for a subtask on failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TaskAttemptInterval")]
                    [Validation(Required=false)]
                    public int? TaskAttemptInterval { get; set; }

                    /// <summary>
                    /// <para>The number of retries for a subtask on failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TaskMaxAttempt")]
                    [Validation(Required=false)]
                    public int? TaskMaxAttempt { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of retries on error. Set this based on business requirements. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrently running instances. Default value: 1. This means that if the previous trigger has not finished running, the next trigger will not be initiated even if the scheduled time has arrived.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>helloworld</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user-defined parameters that can be obtained at runtime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The node status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Enabled. The node can be triggered normally.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: Disabled. The node will not be triggered.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time configuration information.</para>
                /// </summary>
                [NameInMap("TimeConfig")]
                [Validation(Required=false)]
                public ListJobsResponseBodyDataJobsTimeConfig TimeConfig { get; set; }
                public class ListJobsResponseBodyDataJobsTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>The custom calendar that can be specified for the cron type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>workday</para>
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// <para>The time offset that can be specified for the cron type, in seconds.</para>
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
                    /// <item><description><para><b>api</b>: No time expression.</para>
                    /// </description></item>
                    /// <item><description><para><b>fix_rate</b>: A specific fixed frequency value. For example, 30 indicates that the node is triggered every 30 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>cron</b>: A standard cron expression.</para>
                    /// </description></item>
                    /// <item><description><para><b>second_delay</b>: A fixed delay in seconds before each execution (1s to 60s).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0/10 * * * ?</para>
                    /// </summary>
                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    /// <summary>
                    /// <para>The time configuration type. Valid values:</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimeType")]
                    [Validation(Required=false)]
                    public int? TimeType { get; set; }

                }

                /// <summary>
                /// <para>The node extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;pageSize&quot;:5,&quot;queueSize&quot;:10,&quot;consumerSize&quot;:5,&quot;dispatcherSize&quot;:5,&quot;taskMaxAttempt&quot;:0,&quot;taskAttemptInterval&quot;:0,&quot;globalConsumerSize&quot;:1000,&quot;taskDispatchMode&quot;:&quot;push&quot;}</para>
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is returned only if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace can not find namespace: 1a72ecb1-b4cc-400a-a71b-20cdec9b****, namespaceSource:null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71BCC0E3-64B2-4B63-A870-AFB64EBCB58B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
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
