// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInvocationAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The modified command content. The command content can be plaintext or Base64-encoded. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the command content after Base64 encoding cannot exceed 24 KB.</para>
        /// </description></item>
        /// <item><description><para>If your command content is Base64-encoded, you must set <c>ContentEncoding=Base64</c>.</para>
        /// </description></item>
        /// <item><description><para>You can set <c>EnableParameter=true</c> to enable the custom parameter feature in the command content:</para>
        /// <list type="bullet">
        /// <item><description>Custom parameters are defined by enclosing them in <c>{{}}</c>. Spaces and line breaks before and after the parameter name within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>The number of custom parameters cannot exceed 20.</description></item>
        /// <item><description>Custom parameter names can contain a-z, A-Z, 0-9, hyphens (-), and underscores (_). The acs:: prefix for specifying non-built-in environment parameters is not supported. Other characters are not supported. Parameter names are case-insensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters. When the command is executed, you do not need to manually assign values to the parameters. Cloud Assistant automatically replaces them with the corresponding values in the environment. The following built-in environment parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{{ACS::RegionId}}</c>: The region ID.</description></item>
        /// <item><description><c>{{ACS::AccountId}}</c>: The UID of the Alibaba Cloud account.</description></item>
        /// <item><description><c>{{ACS::InstanceId}}</c>: The instance ID. When the command is sent to multiple instances, to specify <c>{{ACS::InstanceId}}</c> as a built-in environment parameter, ensure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InstanceName}}</c>: The instance name. When the command is sent to multiple instances, to specify <c>{{ACS::InstanceName}}</c> as a built-in environment parameter, ensure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InvokeId}}</c>: The command execution ID. To specify <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, ensure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::CommandId}}</c>: The command ID. When you call this operation to execute a command, to specify <c>{{ACS::CommandId}}</c> as a built-in environment parameter, ensure that the Cloud Assistant Agent version is not earlier than the following versions: <list type="bullet">
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
        /// <para>The encoding method of the command content (<c>CommandContent</c>). Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description>PlainText: no encoding. The content is transmitted in plaintext.</description></item>
        /// <item><description>Base64: Base64 encoding.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If an invalid value is specified, it is treated as PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether the modified command contains custom parameters.</para>
        /// <list type="bullet">
        /// <item><description>When you enable custom parameters or modify the custom parameters <c>Parameters</c>, set this parameter to <c>true</c>.</description></item>
        /// <item><description>When you do not modify the custom parameters <c>Parameters</c>, do not set this parameter or set it to <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The modified scheduled execution frequency. This parameter takes effect only when <c>RepeatMode</c> is set to <c>Period</c>. Three types of scheduled execution are supported: fixed interval execution (based on Rate expressions), one-time execution at a specified time, and clock-based scheduled execution (based on Cron expressions).</para>
        /// <list type="bullet">
        /// <item><description><para>Fixed interval execution: Based on Rate expressions, the command is executed at the specified time interval. The time interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This is applicable to scenarios where tasks are executed at fixed intervals. Format: <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to execute every 5 minutes, the format is <c>rate(5m)</c>. The following limits apply to fixed interval execution:</para>
        /// <list type="bullet">
        /// <item><description>The specified interval cannot exceed 7 days or be less than 60 seconds, and must be greater than the timeout period specified when the scheduled task was created.</description></item>
        /// <item><description>The execution interval is based only on the fixed frequency and is not related to the actual time required for task execution. For example, if the command is set to execute every 5 minutes and the task takes 2 minutes to complete, the next round of execution starts 3 minutes after the task is completed.</description></item>
        /// <item><description>The next execution time is calculated based on the task creation time (see <a href="https://help.aliyun.com/document_detail/64840.html">CreationTime</a> returned by <c>DescribeInvocations</c>, note that this is not the modification time) and the modified execution interval.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: The command is executed once at the specified time zone and time point. Format: <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>, which is <c>at(year-month-day hour:minute:second &lt;time zone&gt;)</c>. If no time zone is specified, the default is UTC. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: such as <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (East 8th time zone) or <c>GMT-7:00</c> (West 7th time zone). When using the GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute once at 13:15:30 on June 6, 2022 in China/Shanghai time, the format is: <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To execute once at 13:15:30 on June 6, 2022 in the West 7th time zone, the format is: <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on Cron expressions): Based on Cron expressions, the command is executed according to the scheduled task settings. Format: <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, which is <c>&lt;Cron expression&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated based on the Cron expression in the specified time zone. If no time zone is specified, the default is the internal system time zone of the instance running the scheduled task. For more information about Cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: such as <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (East 8th time zone) or <c>GMT-7:00</c> (West 7th time zone). When using the GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.
        /// For example, to execute a command once a day at 10:15 AM in China/Shanghai time in 2022, the format is <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To execute every half hour from 10:00 AM to 11:30 AM every day in the East 8th time zone in 2022, the format is <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To execute every 5 minutes from 2:00 PM to 2:55 PM every day in October every two years starting from 2022 in UTC, the format is <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum time interval must be greater than or equal to the timeout period specified when the scheduled task was created, and must not be less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The instance ID of the ECS instance or managed instance to add to the task.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The command execution ID of the task to modify.</para>
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
        /// <para>The key-value pairs of custom parameters to modify when the command contains custom parameters.</para>
        /// <para>The number of custom parameters ranges from 0 to 10. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Keys cannot be empty strings and can contain up to 64 characters.</description></item>
        /// <item><description>Values can be empty strings.</description></item>
        /// <item><description>After the custom parameters and original command content are Base64-encoded, the total size of the command content cannot exceed 24 KB.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use empty strings as substitutes.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that no custom parameter key-value pairs are modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

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
