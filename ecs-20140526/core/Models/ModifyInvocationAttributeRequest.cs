// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInvocationAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The content of the command after modification. The command content can be plaintext or Base64-encoded. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You can specify whether to retain the command after the command is run when you created the command. If you specified to retain the command, the Base64-encoded command content cannot exceed 18 KB in size. If you specified not to retain the command, the Base64-encoded command content cannot exceed 24 KB in size.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, set <c>ContentEncoding</c> to Base64.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>EnableParameter</c> to true, the custom parameter feature is enabled and you can configure custom parameters based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>You can define custom parameters in the <c>{{}}</c> format. Within <c>{{}}</c>, the spaces and line feeds before and after the parameter names are ignored.</description></item>
        /// <item><description>The number of custom parameters cannot exceed 20.</description></item>
        /// <item><description>A custom parameter name can contain letters, digits, underscores (_), and hyphens (-). The name is case-insensitive. The ACS:: prefix cannot be used to specify non-built-in environment parameters.</description></item>
        /// <item><description>Each custom parameter name cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters. Then, when you run the command, these parameters are automatically specified by Cloud Assistant. You can specify the following built-in environment parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{{ACS::RegionId}}</c>: the region ID.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceId}}</c>: the instance ID. If you want to specify <c>{{ACS::InstanceId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following ones:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceName}}</c>: the instance name. When the command is run on multiple instances, if you want to specify <c>{{ACS::InstanceName}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following ones:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InvokeId}}</c>: the ID of the task. If you want to specify <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following ones:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::CommandId}}</c>: the command ID. If you want to specify <c>{{ACS::CommandId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following ones:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The encoding mode of the command content that is specified by <c>CommandContent</c>. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The command content is not encoded.</description></item>
        /// <item><description>Base64: The command content is encoded in Base64.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If the value is invalid, the PlainText mode is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to include custom parameters in the command.</para>
        /// <list type="bullet">
        /// <item><description>If you want to enable the custom parameter feature, or configure <c>Parameters</c> to modify the custom parameters in the command, set EnableParameter to <c>true</c>.</description></item>
        /// <item><description>If you do not want to configure <c>Parameters</c> to modify the custom parameters in the command, leave EnableParameter empty or set it to <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The frequency at which to run the command. This parameter takes effect only when <c>RepeatMode</c> is set to <c>Period</c>. You can configure a command to run at a fixed interval based on a rate expression, run only once at a specific point in time, or run at designated points in time based on a cron expression.</para>
        /// <list type="bullet">
        /// <item><description><para>To run the command at a fixed interval, use a rate expression to specify the interval. You can specify the interval in seconds, minutes, hours, or days. This option is suitable for scenarios in which tasks need to be executed at a fixed interval. Specify the interval in the following format: <c>rate(&lt;Execution interval value&gt; &lt;Execution interval unit&gt;)</c>. For example, specify <c>rate(5m)</c> to run the command every 5 minutes. Take note of the following limits when you specify an interval:</para>
        /// <list type="bullet">
        /// <item><description>The specified interval must be in the range of 60 seconds to 7 days and must be longer than the timeout period specified when you created the scheduled task.</description></item>
        /// <item><description>The interval is the amount of time that elapses between two consecutive executions. The interval is irrelevant to the amount of time that is required to run the command once. For example, you set the interval to 5 minutes and the command requires 2 minutes to run once. Each time the command running is complete, the system waits 3 minutes instead of 5 minutes before the system runs the command again.</description></item>
        /// <item><description>The point in time at which the command is run the next time is calculated based on the creation time of the task (the <a href="https://help.aliyun.com/document_detail/64840.html">CreationTime</a> value returned by the <c>DescribeInvocations</c> operation) and the modified execution interval.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To run a command only once at a specific time, specify a point in time and a time zone. Specify the point in time in the <c>at(yyyy-MM-dd HH:mm:ss &lt;Time zone&gt;)</c> format, which indicates <c>at(Year-Month-Day Hours:Minutes:Seconds &lt;Time zone&gt;)</c>. If you do not specify a time zone, the Coordinated Universal Time (UTC) time zone is used by default. You can specify a time zone in the following forms:</para>
        /// <list type="bullet">
        /// <item><description>The time zone name. Examples: <c>Asia/Shanghai</c> and <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>The time offset from GMT. Examples: <c>GMT+8:00</c> (UTC+8) and <c>GMT-7:00</c> (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value.</description></item>
        /// <item><description>The time zone abbreviation. Only UTC is supported.</description></item>
        /// </list>
        /// <para>For example, to configure a command to run only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To configure a command to run only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>To run a command at designated points in time, use a cron expression to define the schedule. Specify a schedule in the <c>&lt;Cron expression&gt; &lt;Time zone&gt;</c> format. The cron expression is in the <c>&lt;Seconds&gt; &lt;Minutes&gt; &lt;Hours&gt; &lt;Day of the month&gt; &lt;Month&gt; &lt;Day of the week&gt; &lt;Year (optional)&gt;</c> format. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zones of the instances on which you want to run the command are used by default. For information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. You can specify the time zone in the following forms:</para>
        /// <list type="bullet">
        /// <item><description>The time zone name. Examples: <c>Asia/Shanghai</c> and <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>The time offset from GMT. Examples: <c>GMT+8:00</c> (UTC+8) and <c>GMT-7:00</c> (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value.</description></item>
        /// <item><description>The time zone abbreviation. Only UTC is supported. For example, to configure a command to run at 10:15:00 every day in 2022 (Shanghai time), set the schedule to <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To configure a command to run every half an hour from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the schedule to <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To configure a command to run every 5 minutes from 14:00:00 to 14:55:00 every October every two years from 2022 in UTC, set the schedule to <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Note</b> The minimum interval must be 10 seconds or longer and cannot be shorter than the timeout period of scheduled executions.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances or managed instances that you want to add to the scheduled command task.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The execution ID of the command.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the custom parameters that are passed in if custom parameters are included in the command.</para>
        /// <para>You can specify 0 to 10 custom parameters. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The key of a custom parameter can be up to 64 characters in length and cannot be an empty string.</description></item>
        /// <item><description>The value of a custom parameter can be an empty string.</description></item>
        /// <item><description>If you specified to retain the command when you create the command task, the total size of the custom parameters and original command content that are encoded in Base64 cannot exceed 18 KB. If you specified not to retain the command when you create the command task, the total size of the custom parameters and original command content that are encoded in Base64 cannot exceed 24 KB.</description></item>
        /// <item><description>The custom parameter names that are specified by Parameters must be included in the custom parameter names that you specified when you created the command. You can use empty strings to represent the parameters that are not passed in.</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates not to modify the key-value pairs of the custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAIdyvdIqaRY****&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
