// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateJobRequest : TeaModel {
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
        /// <para>The retry interval for errors. Unit: seconds. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AttemptInterval")]
        [Validation(Required=false)]
        public int? AttemptInterval { get; set; }

        /// <summary>
        /// <para>The custom calendar. You can specify a custom calendar for the cron type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workday</para>
        /// </summary>
        [NameInMap("Calendar")]
        [Validation(Required=false)]
        public string Calendar { get; set; }

        /// <summary>
        /// <para>The IDs of child jobs. Separate multiple IDs with commas.</para>
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
        /// <para>The coordinates of the node in the workflow.</para>
        /// </summary>
        [NameInMap("Coordinate")]
        [Validation(Required=false)]
        public CreateJobRequestCoordinate Coordinate { get; set; }
        public class CreateJobRequestCoordinate : TeaModel {
            /// <summary>
            /// <para>The height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.0</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>The width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

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
        /// <para>The job description.</para>
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
        /// <item><description>3: overwrite previous scheduling</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecutorBlockStrategy")]
        [Validation(Required=false)]
        public int? ExecutorBlockStrategy { get; set; }

        /// <summary>
        /// <para>The name of the job handler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testJobVoidHandler</para>
        /// </summary>
        [NameInMap("JobHandler")]
        [Validation(Required=false)]
        public string JobHandler { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The job label information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{key:value}</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The maximum number of retries for errors. Set this parameter based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAttempt")]
        [Validation(Required=false)]
        public int? MaxAttempt { get; set; }

        /// <summary>
        /// <para>The maximum concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// <para>This parameter is required.</para>
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
        public CreateJobRequestNoticeConfig NoticeConfig { get; set; }
        public class CreateJobRequestNoticeConfig : TeaModel {
            /// <summary>
            /// <para>The early completion threshold. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EndEarly")]
            [Validation(Required=false)]
            public int? EndEarly { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the early completion alert.</para>
            /// </summary>
            [NameInMap("EndEarlyEnable")]
            [Validation(Required=false)]
            public bool? EndEarlyEnable { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable failure alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables failure alerts.</description></item>
            /// <item><description><b>false</b>: disables failure alerts.</description></item>
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
            /// <para>An alert is triggered only when the number of consecutive failures exceeds the specified value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailLimitTimes")]
            [Validation(Required=false)]
            public int? FailLimitTimes { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable alerts for unavailable workers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables alerts for unavailable workers.</description></item>
            /// <item><description><b>false</b>: disables alerts for unavailable workers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MissWorkerEnable")]
            [Validation(Required=false)]
            public bool? MissWorkerEnable { get; set; }

            /// <summary>
            /// <para>The notification channels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sms: SMS</description></item>
            /// <item><description>phone: phone call</description></item>
            /// <item><description>mail: email</description></item>
            /// <item><description>webhook: webhook<remarks>
            /// <para>Separate multiple notification channels with commas.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mail</para>
            /// </summary>
            [NameInMap("SendChannel")]
            [Validation(Required=false)]
            public string SendChannel { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable success notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables success notifications.</description></item>
            /// <item><description>false: disables success notifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SuccessNotice")]
            [Validation(Required=false)]
            public bool? SuccessNotice { get; set; }

            /// <summary>
            /// <para>The timeout period. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the timeout alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled</para>
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
            /// <para>Specifies whether to enable the timeout termination feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables the timeout termination feature.</description></item>
            /// <item><description><b>false</b>: disables the timeout termination feature.</description></item>
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
        public List<CreateJobRequestNoticeContacts> NoticeContacts { get; set; }
        public class CreateJobRequestNoticeContacts : TeaModel {
            /// <summary>
            /// <para>The notification recipient type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: alert contact</para>
            /// </description></item>
            /// <item><description><para>2: alert contact group</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContactType")]
            [Validation(Required=false)]
            public int? ContactType { get; set; }

            /// <summary>
            /// <para>The name of the alert contact or alert contact group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xiaoming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The job parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: low</description></item>
        /// <item><description>5: medium</description></item>
        /// <item><description>10: high</description></item>
        /// <item><description>15: very high</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The routing strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: round-robin</description></item>
        /// <item><description>2: random</description></item>
        /// <item><description>3: first</description></item>
        /// <item><description>4: last</description></item>
        /// <item><description>5: least frequently used</description></item>
        /// <item><description>6: least recently used</description></item>
        /// <item><description>7: consistent hashing</description></item>
        /// <item><description>8: sharding broadcast</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteStrategy")]
        [Validation(Required=false)]
        public int? RouteStrategy { get; set; }

        /// <summary>
        /// <para>The script content for non-BEAN job types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo &quot;hello world&quot;</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The start time. Use a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1701310327000</para>
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
        public int? StartTimeType { get; set; }

        /// <summary>
        /// <para>The job status. Default value: enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled</description></item>
        /// <item><description>1: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The time expression. Set the time expression based on the selected time type.</para>
        /// <list type="bullet">
        /// <item><description><b>none</b>: Leave this parameter empty.</description></item>
        /// <item><description><b>cron</b>: Enter a standard cron expression. Online verification is supported.</description></item>
        /// <item><description><b>api</b>: Leave this parameter empty.</description></item>
        /// <item><description><b>fixed_rate</b>: Enter a specific fixed frequency value. Unit: seconds. For example, 200 indicates that the job is triggered once every 200 seconds.</description></item>
        /// <item><description><b>one_time</b>: Enter the scheduling time in the yyyy-MM-dd HH:mm:ss format or a timestamp in milliseconds. Example: &quot;2022-10-10 10:10:00&quot;.</description></item>
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
        /// <item><description>-1: none<br/></description></item>
        /// <item><description>1: cron<br/></description></item>
        /// <item><description>3: fix_rate<br/></description></item>
        /// <item><description>5: one_time<br/></description></item>
        /// <item><description>100: api</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

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
        /// <para>The job weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <para>The extended attributes. This parameter is required for Kubernetes job types.
        /// Job: {&quot;resource&quot;:&quot;job&quot;}
        /// Shell: {&quot;image&quot;:&quot;busybox&quot;,&quot;resource&quot;:&quot;shell&quot;}</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;responseMode&quot;:&quot;streaming&quot;}</para>
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
