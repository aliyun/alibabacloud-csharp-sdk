// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateJobRequest : TeaModel {
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
        /// <para>The custom calendar. This parameter is available for the cron time type.</para>
        /// </summary>
        [NameInMap("Calendar")]
        [Validation(Required=false)]
        public string Calendar { get; set; }

        /// <summary>
        /// <para>The full path of the node interface class.</para>
        /// <para>This field is required only when you select the Java node type. Specify the full path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.schedulerx.test.helloworld</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The advanced configuration for parallel grid nodes. The number of threads triggered for a single execution on a single machine. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConsumerSize")]
        [Validation(Required=false)]
        public int? ConsumerSize { get; set; }

        /// <summary>
        /// <para>The node contact information.</para>
        /// <remarks>
        /// <para>Notice: This field is deprecated.</notice></para>
        /// </remarks>
        /// </summary>
        [NameInMap("ContactInfo")]
        [Validation(Required=false)]
        public List<CreateJobRequestContactInfo> ContactInfo { get; set; }
        public class CreateJobRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>The webhook URL of the DingTalk chatbot for the alert contact\&quot;s DingTalk group. References: <a href="https://open.dingtalk.com/document/org/application-types">DingTalk development documentation</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>**********</para>
            /// </summary>
            [NameInMap("Ding")]
            [Validation(Required=false)]
            public string Ding { get; set; }

            /// <summary>
            /// <para>The email address of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test***@***.com</para>
            /// </summary>
            [NameInMap("UserMail")]
            [Validation(Required=false)]
            public string UserMail { get; set; }

            /// <summary>
            /// <para>The name of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Smith</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the alert recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("UserPhone")]
            [Validation(Required=false)]
            public string UserPhone { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the node type is python, shell, or k8s, specify the corresponding script content.</description></item>
        /// <item><description>If the node type is golang, the content format example is {&quot;jobName&quot;:&quot;HelloWorld&quot;}.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>echo \&quot;hello\&quot;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The time offset. Unit: seconds. This parameter is available for the cron time type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2400</para>
        /// </summary>
        [NameInMap("DataOffset")]
        [Validation(Required=false)]
        public int? DataOffset { get; set; }

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
        /// <para>The advanced configuration for parallel grid nodes. The number of subtask dispatch threads. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DispatcherSize")]
        [Validation(Required=false)]
        public int? DispatcherSize { get; set; }

        /// <summary>
        /// <para>The node execution mode. The following execution modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Standalone</b>: standalone</description></item>
        /// <item><description><b>Broadcast</b>: broadcast</description></item>
        /// <item><description><b>Visual MapReduce</b>: parallel</description></item>
        /// <item><description><b>MapReduce</b>: batch</description></item>
        /// <item><description><b>Sharding</b>: sharding</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standalone</para>
        /// </summary>
        [NameInMap("ExecuteMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the failure alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables the failure alert.</description></item>
        /// <item><description><b>false</b>: Disables the failure alert.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FailEnable")]
        [Validation(Required=false)]
        public bool? FailEnable { get; set; }

        /// <summary>
        /// <para>The number of consecutive failures before an alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailTimes")]
        [Validation(Required=false)]
        public int? FailTimes { get; set; }

        /// <summary>
        /// <para>The application ID. You can obtain the application ID on the Application Management page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The node type. The following node types are supported:</para>
        /// <list type="bullet">
        /// <item><description>java</description></item>
        /// <item><description>python</description></item>
        /// <item><description>shell</description></item>
        /// <item><description>go</description></item>
        /// <item><description>http</description></item>
        /// <item><description>xxljob</description></item>
        /// <item><description>dataworks</description></item>
        /// <item><description>k8s</description></item>
        /// <item><description>springschedule</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

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
        /// <para>The maximum number of concurrently running instances. Default value: 1. This means that if the previous trigger has not finished running, the next trigger is not performed even if the scheduled time arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the no-available-machine alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables the no-available-machine alert.</description></item>
        /// <item><description><b>false</b>: Disables the no-available-machine alert.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MissWorkerEnable")]
        [Validation(Required=false)]
        public bool? MissWorkerEnable { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>helloworld</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the Namespace page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>This parameter is required only for special third-party users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The advanced configuration for parallel grid nodes. The number of subtasks pulled in a single request. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The node priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: low</description></item>
        /// <item><description><b>5</b>: medium</description></item>
        /// <item><description><b>10</b>: high</description></item>
        /// <item><description><b>15</b>: very high</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The advanced configuration for parallel grid nodes. The maximum cache size of the subtask queue. Default value: 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("QueueSize")]
        [Validation(Required=false)]
        public int? QueueSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The alert notification channel.</para>
        /// <list type="bullet">
        /// <item><description>Use the default channel of the application group: default.</description></item>
        /// <item><description>Specify a notification channel for the node: sms, mail, phone, or webhook.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sms</para>
        /// </summary>
        [NameInMap("SendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The node status. Valid values: 0: disabled. 1: enabled. Default value: 1 (enabled).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the success notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SuccessNoticeEnable")]
        [Validation(Required=false)]
        public bool? SuccessNoticeEnable { get; set; }

        /// <summary>
        /// <para>The advanced configuration for parallel grid nodes. The retry interval for a failed subtask. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskAttemptInterval")]
        [Validation(Required=false)]
        public int? TaskAttemptInterval { get; set; }

        /// <summary>
        /// <para>The advanced configuration for parallel grid nodes. The number of retries for a failed subtask. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskMaxAttempt")]
        [Validation(Required=false)]
        public int? TaskMaxAttempt { get; set; }

        /// <summary>
        /// <para>The time expression. Set the time expression based on the selected time type.</para>
        /// <list type="bullet">
        /// <item><description><b>cron</b>: Specify a standard cron expression. Online verification is supported.</description></item>
        /// <item><description><b>api</b>: No time expression is required.</description></item>
        /// <item><description><b>fixed_rate</b>: Specify a fixed frequency value in seconds. For example, 30 indicates that the node is triggered every 30 seconds.</description></item>
        /// <item><description><b>second_delay</b>: Specify a fixed delay in seconds before each execution (1s to 60s).</description></item>
        /// <item><description><b>one_time</b>: Specify a time in the format of yyyy-MM-dd HH:mm:ss or a timestamp in milliseconds. For example, &quot;2022-10-10 10:10:00&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0 0/10 * * * ?</para>
        /// </summary>
        [NameInMap("TimeExpression")]
        [Validation(Required=false)]
        public string TimeExpression { get; set; }

        /// <summary>
        /// <para>The time type. The following time types are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>cron</b>: 1</description></item>
        /// <item><description><b>fixed_rate</b>: 3</description></item>
        /// <item><description><b>second_delay</b>: 4</description></item>
        /// <item><description><b>one_time</b>: 5 </description></item>
        /// <item><description><b>api</b>: 100</description></item>
        /// <item><description><b>none</b>: -1</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

        /// <summary>
        /// <para>The timeout threshold. Unit: seconds. Default value: 7200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("TimeoutEnable")]
        [Validation(Required=false)]
        public bool? TimeoutEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable timeout termination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables timeout termination.</description></item>
        /// <item><description><b>false</b>: Disables timeout termination.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TimeoutKillEnable")]
        [Validation(Required=false)]
        public bool? TimeoutKillEnable { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+8</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>If the node type is k8s, configure this parameter.
        /// Job task: {&quot;resource&quot;:&quot;job&quot;}
        /// Shell task: {&quot;image&quot;:&quot;busybox&quot;,&quot;resource&quot;:&quot;shell&quot;}</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;resource&quot;:&quot;job&quot;}</para>
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
