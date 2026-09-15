// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the specified node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The node configuration information.</para>
            /// </summary>
            [NameInMap("JobConfigInfo")]
            [Validation(Required=false)]
            public GetJobInfoResponseBodyDataJobConfigInfo JobConfigInfo { get; set; }
            public class GetJobInfoResponseBodyDataJobConfigInfo : TeaModel {
                /// <summary>
                /// <para>The retry interval on failure. Unit: seconds. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <para>The full path of the node interface class. This field is available only for Java-type nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.test.helloword</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The script content for script-type nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo &quot;clear&quot; &gt; /home/admin/edas-container/logs/catalina.out</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The node description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1789454134000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The node execution mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>standalone</b>: standalone</description></item>
                /// <item><description><b>broadcatst</b>: broadcast</description></item>
                /// <item><description><b>parallel</b>: parallel computing</description></item>
                /// <item><description><b>grid</b>: in-memory grid</description></item>
                /// <item><description><b>batch</b>: grid computing</description></item>
                /// <item><description><b>shard</b>: shard</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standalone</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// <para>The full path of the file uploaded to Object Storage Service (OSS).</para>
                /// <para>If you select JAR package execution, you can upload the corresponding JAR package to this OSS path.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/schedulerX/test.jar">https://test.oss-cn-hangzhou.aliyuncs.com/schedulerX/test.jar</a></para>
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>538039</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The node monitoring information.</para>
                /// </summary>
                [NameInMap("JobMonitorInfo")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo JobMonitorInfo { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo : TeaModel {
                    /// <summary>
                    /// <para>The contact information.</para>
                    /// </summary>
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo : TeaModel {
                        /// <summary>
                        /// <para>The webhook URL of DingTalk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=XXXXXX">https://oapi.dingtalk.com/robot/send?access_token=XXXXXX</a></para>
                        /// </summary>
                        [NameInMap("Ding")]
                        [Validation(Required=false)]
                        public string Ding { get; set; }

                        /// <summary>
                        /// <para>The email address of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="mailto:user@demo.com">user@demo.com</a></para>
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
                    public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable the failure alert. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: Enables the failure alert.</description></item>
                        /// <item><description><b>false</b>: Disables the failure alert.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the alert for no available machines.</para>
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
                        /// <para>The timeout threshold. Unit: seconds. Default value: 7200.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12300</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the timeout alert. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: Enables the timeout alert.</description></item>
                        /// <item><description><b>false</b>: Disables the timeout alert.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to terminate the current trigger upon timeout. This feature is disabled by default.</para>
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
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The advanced configuration. This configuration is available only for parallel computing, in-memory grid, and grid computing modes.</para>
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs : TeaModel {
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
                    /// <para>The number of threads for subtask distribution. Default value: 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("DispatcherSize")]
                    [Validation(Required=false)]
                    public int? DispatcherSize { get; set; }

                    /// <summary>
                    /// <para>The number of subtasks pulled per request for parallel nodes. Default value: 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <para>The maximum number of subtasks that can be cached in the queue. Default value: 10000.</para>
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
                    /// <para>The maximum number of retries for a subtask on failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TaskMaxAttempt")]
                    [Validation(Required=false)]
                    public int? TaskMaxAttempt { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of retries on failure. Set this parameter based on your business requirements. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrently running instances. Default value: 1. A value of 1 indicates that if the previous trigger has not finished running, the next trigger is skipped even if the scheduled time has arrived.</para>
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

                /// <summary>
                /// <para>The node status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Enabled. The node can be triggered normally.</description></item>
                /// <item><description><b>0</b>: Disabled. The node is not triggered.</description></item>
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
                public GetJobInfoResponseBodyDataJobConfigInfoTimeConfig TimeConfig { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>The custom calendar for the <b>cron</b> type. This parameter is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>workday</para>
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// <para>The time offset for the <b>cron</b> type. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// <para>The time expression. The following time expression types are supported:</para>
                    /// <list type="bullet">
                    /// <item><description><b>api</b>: No time expression is required.</description></item>
                    /// <item><description><b>fix_rate</b>: A fixed frequency value. For example, 30 indicates that the node is triggered every 30 seconds.</description></item>
                    /// <item><description><b>cron</b>: A standard cron expression.</description></item>
                    /// <item><description><b>second_delay</b>: A fixed delay in seconds before each execution (valid range: 1s to 60s).</description></item>
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
                /// <para>The extended fields of the node.</para>
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
        /// <para>The error message. This parameter is returned only when an error occurs.</para>
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
        /// <para>Indicates whether the node details were retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The node details were retrieved.</description></item>
        /// <item><description><b>false</b>: The node details failed to be retrieved.</description></item>
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
