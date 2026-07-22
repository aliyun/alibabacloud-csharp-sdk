// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateJobRequest : TeaModel {
        [NameInMap("AppGroupId")]
        [Validation(Required=false)]
        public long? AppGroupId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The retry interval upon node failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AttemptInterval")]
        [Validation(Required=false)]
        public int? AttemptInterval { get; set; }

        /// <summary>
        /// <para>The custom calendar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workday</para>
        /// </summary>
        [NameInMap("Calendar")]
        [Validation(Required=false)]
        public string Calendar { get; set; }

        /// <summary>
        /// <para>The child node IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ChildJobId")]
        [Validation(Required=false)]
        public string ChildJobId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The dependency strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DependentStrategy")]
        [Validation(Required=false)]
        public int? DependentStrategy { get; set; }

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
        /// <para>The client blocking strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: serial execution on a single machine</description></item>
        /// <item><description>2: ignore subsequent scheduling</description></item>
        /// <item><description>3: override previous scheduling</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecutorBlockStrategy")]
        [Validation(Required=false)]
        public int? ExecutorBlockStrategy { get; set; }

        /// <summary>
        /// <para>The JobHandler name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testJobVoidHandler</para>
        /// </summary>
        [NameInMap("JobHandler")]
        [Validation(Required=false)]
        public string JobHandler { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The maximum number of retry attempts upon node failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAttempt")]
        [Validation(Required=false)]
        public int? MaxAttempt { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent instances for the node.</para>
        /// <remarks>
        /// <para>The maximum number of instances that can run simultaneously for the same node. A value of 1 indicates that repeated execution is not allowed. If the concurrency limit is exceeded, the current scheduling is skipped.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification configuration.</para>
        /// </summary>
        [NameInMap("NoticeConfig")]
        [Validation(Required=false)]
        public UpdateJobRequestNoticeConfig NoticeConfig { get; set; }
        public class UpdateJobRequestNoticeConfig : TeaModel {
            /// <summary>
            /// <para>The early termination threshold, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EndEarly")]
            [Validation(Required=false)]
            public int? EndEarly { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the early termination alert.</para>
            /// </summary>
            [NameInMap("EndEarlyEnable")]
            [Validation(Required=false)]
            public bool? EndEarlyEnable { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the failure alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FailEnable")]
            [Validation(Required=false)]
            public bool? FailEnable { get; set; }

            /// <summary>
            /// <para>The number of consecutive failures.</para>
            /// <remarks>
            /// <para>An alert is sent only when the number of consecutive failures exceeds the configured value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FailLimitTimes")]
            [Validation(Required=false)]
            public int? FailLimitTimes { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the no-available-machine alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MissWorkerEnable")]
            [Validation(Required=false)]
            public bool? MissWorkerEnable { get; set; }

            /// <summary>
            /// <para>The notification channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sms: text message</description></item>
            /// <item><description>phone: phone call</description></item>
            /// <item><description>mail: email</description></item>
            /// <item><description>webhook: webhook<remarks>
            /// <para>Separate multiple notification channels with commas.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>webhook,sms,mail,phone</para>
            /// </summary>
            [NameInMap("SendChannel")]
            [Validation(Required=false)]
            public string SendChannel { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the success notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SuccessNotice")]
            [Validation(Required=false)]
            public bool? SuccessNotice { get; set; }

            /// <summary>
            /// <para>The node execution timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the timeout alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
            /// <para>Specifies whether to enable the timeout termination for the current trigger. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TimeoutKillEnable")]
            [Validation(Required=false)]
            public bool? TimeoutKillEnable { get; set; }

        }

        /// <summary>
        /// <para>The notification contact configuration.</para>
        /// </summary>
        [NameInMap("NoticeContacts")]
        [Validation(Required=false)]
        public List<UpdateJobRequestNoticeContacts> NoticeContacts { get; set; }
        public class UpdateJobRequestNoticeContacts : TeaModel {
            /// <summary>
            /// <para>The contact type. </para>
            /// <remarks>
            /// <para>Default configurations: 1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContactType")]
            [Validation(Required=false)]
            public int? ContactType { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xiaoming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The node parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The node execution priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: low</description></item>
        /// <item><description>5: medium</description></item>
        /// <item><description>10: high</description></item>
        /// <item><description>15: very high</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The routing strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: round robin</description></item>
        /// <item><description>2: random</description></item>
        /// <item><description>3: first</description></item>
        /// <item><description>4: last</description></item>
        /// <item><description>5: least frequently used</description></item>
        /// <item><description>6: least recently used</description></item>
        /// <item><description>7: consistent hashing</description></item>
        /// <item><description>8: shard broadcast</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteStrategy")]
        [Validation(Required=false)]
        public int? RouteStrategy { get; set; }

        /// <summary>
        /// <para>The script content for non-BEAN nodes. Use this field to configure the script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo &quot;hello world&quot;</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The scheduling start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716902187</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The start time type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartTimeType")]
        [Validation(Required=false)]
        public string StartTimeType { get; set; }

        /// <summary>
        /// <para>The time expression. Set the time expression based on the selected time type.</para>
        /// <list type="bullet">
        /// <item><description>none: No value is required.</description></item>
        /// <item><description>cron: Specify a standard cron expression. Online verification is supported.</description></item>
        /// <item><description>api: No value is required.</description></item>
        /// <item><description>fixed_rate: Specify a fixed frequency value in seconds. For example, 30 indicates that the node is triggered every 30 seconds.</description></item>
        /// <item><description>one_time: Specify a scheduling time in the format of yyyy-MM-dd HH:mm:ss or a timestamp in milliseconds. For example, &quot;2022-10-10 10:10:00&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 4 ? * Mon/1</para>
        /// </summary>
        [NameInMap("TimeExpression")]
        [Validation(Required=false)]
        public string TimeExpression { get; set; }

        /// <summary>
        /// <para>The time type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: none</description></item>
        /// <item><description>1: cron</description></item>
        /// <item><description>3: fix_rate</description></item>
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
        /// <para>The time zone.</para>
        /// <remarks>
        /// <para>The default value is the time zone of the SchedulerX server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Hongkong</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The node weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;reponseMode&quot;:&quot;streaming&quot;}</para>
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
