// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateJobShrinkRequest : TeaModel {
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
        public string CoordinateShrink { get; set; }

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
        public string NoticeConfigShrink { get; set; }

        /// <summary>
        /// <para>The notification contact configuration.</para>
        /// </summary>
        [NameInMap("NoticeContacts")]
        [Validation(Required=false)]
        public string NoticeContactsShrink { get; set; }

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
