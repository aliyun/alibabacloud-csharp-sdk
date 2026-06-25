// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateJobShrinkRequest : TeaModel {
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
        /// <para>The interval in seconds between retry attempts.</para>
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
        /// <para>The client blocking strategy.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Serial execution</para>
        /// </description></item>
        /// <item><description><para>2: Ignore later schedules</para>
        /// </description></item>
        /// <item><description><para>3: Overwrite earlier schedules</para>
        /// </description></item>
        /// </list>
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
        /// <para>Notification contact configuration</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecutorBlockStrategy")]
        [Validation(Required=false)]
        public int? ExecutorBlockStrategy { get; set; }

        /// <summary>
        /// <para>The job handler name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testJobVoidHandler</para>
        /// </summary>
        [NameInMap("JobHandler")]
        [Validation(Required=false)]
        public string JobHandler { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The maximum number of retries for a failed job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAttempt")]
        [Validation(Required=false)]
        public int? MaxAttempt { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent job instances.</para>
        /// <remarks>
        /// <para>This parameter defines the maximum number of instances for a single job that can run concurrently. A value of <c>1</c> prevents duplicate execution. If this limit is exceeded, the scheduler skips the current job.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Time zone</para>
        /// <remarks>
        /// <para>The default is the time zone of the SchedulerX server.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NoticeConfig")]
        [Validation(Required=false)]
        public string NoticeConfigShrink { get; set; }

        /// <summary>
        /// <para>Notification configuration</para>
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
        /// <para>The job execution priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>1</c>: Low</para>
        /// </description></item>
        /// <item><description><para><c>5</c>: Medium</para>
        /// </description></item>
        /// <item><description><para><c>10</c>: High</para>
        /// </description></item>
        /// <item><description><para><c>15</c>: Very High</para>
        /// </description></item>
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
        /// <item><description><para><c>1</c>: round-robin</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: random</para>
        /// </description></item>
        /// <item><description><para><c>3</c>: first</para>
        /// </description></item>
        /// <item><description><para><c>4</c>: last</para>
        /// </description></item>
        /// <item><description><para><c>5</c>: least frequently used</para>
        /// </description></item>
        /// <item><description><para><c>6</c>: least recently used</para>
        /// </description></item>
        /// <item><description><para><c>7</c>: consistent hashing</para>
        /// </description></item>
        /// <item><description><para><c>8</c>: sharded broadcast</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteStrategy")]
        [Validation(Required=false)]
        public int? RouteStrategy { get; set; }

        /// <summary>
        /// <para>The script content for non-BEAN jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo &quot;hello world&quot;</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The type of the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716902187</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The task execution priority. The following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Low</para>
        /// </description></item>
        /// <item><description><para>5: Medium</para>
        /// </description></item>
        /// <item><description><para>10: High</para>
        /// </description></item>
        /// <item><description><para>15: Very High</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartTimeType")]
        [Validation(Required=false)]
        public string StartTimeType { get; set; }

        /// <summary>
        /// <para>The time expression. The expression format depends on the <c>TimeType</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>none</c>: Leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para><c>cron</c>: Specify a standard cron expression. Online validation is supported.</para>
        /// </description></item>
        /// <item><description><para><c>api</c>: Leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para><c>fixed_rate</c>: An integer that represents a fixed interval in seconds. For example, <c>30</c> triggers the job every 30 seconds.</para>
        /// </description></item>
        /// <item><description><para><c>one_time</c>: A single execution time, specified in the <c>yyyy-MM-dd HH:mm:ss</c> format or as a timestamp in milliseconds. For example, &quot;2022-10-10 10:10:00&quot;.</para>
        /// </description></item>
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
        /// <item><description><para><c>-1</c>: none</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: cron</para>
        /// </description></item>
        /// <item><description><para><c>3</c>: fixed_rate</para>
        /// </description></item>
        /// <item><description><para><c>5</c>: one_time</para>
        /// </description></item>
        /// <item><description><para><c>100</c>: api</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

        /// <summary>
        /// <para>The start time of the schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hongkong</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The ID of the child job. Separate multiple IDs with a comma.</para>
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
