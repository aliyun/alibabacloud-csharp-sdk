// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInvocationAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The modified command content. The command content can be plaintext or Base64-encoded. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the Base64-encoded command content cannot exceed 24 KB.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, you must set <c>ContentEncoding</c> to <c>Base64</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>EnableParameter</c> to <c>true</c>, you can use custom parameters in the command content:</para>
        /// <list type="bullet">
        /// <item><description>Custom parameters are enclosed in <c>{{}}</c>. Spaces and line breaks before and after the parameter name inside <c>{{}}</c> are ignored.</description></item>
        /// <item><description>You can specify a maximum of 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain letters, digits, hyphens (-), and underscores (_). The <c>acs::</c> prefix is not supported for specifying non-built-in environment variables. Other characters are not supported. Parameter names are not case-sensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment variables as custom parameters. When the command is executed, you do not need to manually assign values to the parameters. Cloud Assistant automatically replaces the parameters with the corresponding values in the environment. The following built-in environment variables are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{{ACS::RegionId}}</c>: the region ID.</description></item>
        /// <item><description><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</description></item>
        /// <item><description><c>{{ACS::InstanceId}}</c>: the instance ID. If the command is sent to multiple instances and you want to specify <c>{{ACS::InstanceId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InstanceName}}</c>: the instance name. If the command is sent to multiple instances and you want to specify <c>{{ACS::InstanceName}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InvokeId}}</c>: the command execution ID. If you want to specify <c>{{ACS::InvokeId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::CommandId}}</c>: the command ID. If you call this operation to execute a command and want to specify <c>{{ACS::CommandId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent version is not earlier than the following versions: <list type="bullet">
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
        /// <para>The encoding method of the command content specified by <c>CommandContent</c>. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The command content is not encoded and is transmitted in plaintext.</description></item>
        /// <item><description>Base64: The command content is Base64-encoded.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If an invalid value is specified, PlainText is used.</para>
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
        /// <item><description>If you enable custom parameters or modify the custom parameters specified by <c>Parameters</c>, set this parameter to <c>true</c>.</description></item>
        /// <item><description>If you do not modify the custom parameters specified by <c>Parameters</c>, do not set this parameter or set it to <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The modified scheduled execution frequency. This parameter takes effect only when <c>RepeatMode</c> is set to <c>Period</c>. Three scheduled execution modes are supported: execution at a fixed time interval (based on a rate expression), one-time execution at a specified time, and clock-based scheduled execution (based on a cron expression).</para>
        /// <list type="bullet">
        /// <item><description><para>Execution at a fixed time interval: The command is executed at a specified time interval based on a rate expression. The time interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This mode is suitable for scenarios where tasks are executed at fixed time intervals. The format is <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to execute the command every 5 minutes, use <c>rate(5m)</c>. The following limits apply to execution at a fixed time interval:</para>
        /// <list type="bullet">
        /// <item><description>The specified time interval cannot exceed 7 days or be less than 60 seconds, and must be greater than the timeout period specified when the scheduled task was created.</description></item>
        /// <item><description>The execution interval is based only on the fixed frequency and is independent of the actual time required to execute the task. For example, if the command is executed every 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task is completed.</description></item>
        /// <item><description>The next execution time is calculated based on the task creation time (refer to <a href="https://help.aliyun.com/document_detail/64840.html">CreationTime</a> returned by <c>DescribeInvocations</c>, not the modification time) and the modified execution interval.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: The command is executed once at a specified time in a specified time zone. The format is <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If no time zone is specified, the UTC time zone is used by default. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: such as <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time (GMT): such as <c>GMT+8:00</c> (East 8th zone) and <c>GMT-7:00</c> (West 7th zone). When the GMT format is used, leading zeros are not supported for the hour.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute the command once at 13:15:30 on June 6, 2022 in the China/Shanghai time zone, use <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To execute the command once at 13:15:30 on June 6, 2022 in the West 7th zone, use <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on a cron expression): The command is executed based on a cron expression. The format is <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, which is <c>&lt;cron expression&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated and executed based on the cron expression in the specified time zone. If no time zone is specified, the internal system time zone of the instance that executes the scheduled task is used by default. For more information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: such as <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from GMT: such as <c>GMT+8:00</c> (East 8th zone) and <c>GMT-7:00</c> (West 7th zone). When the GMT format is used, leading zeros are not supported for the hour.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC is supported.
        /// For example, to execute the command once at 10:15 every day in 2022 in the China/Shanghai time zone, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To execute the command every half hour from 10:00 to 11:30 every day in 2022 in the East 8th zone, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To execute the command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in the UTC time zone, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum time interval must be greater than or equal to the timeout period specified when the scheduled task was created, and cannot be less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The ECS instance ID or managed instance ID to be added to the task.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The execution ID of the command for the task to be modified.</para>
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
        /// <para>The key-value pairs of the custom parameters passed in when the command is executed. This parameter is required when the command contains custom parameters.</para>
        /// <para>You can specify 0 to 10 custom parameters. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>A key cannot be an empty string and can be up to 64 characters in length.</description></item>
        /// <item><description>A value can be an empty string.</description></item>
        /// <item><description>After the custom parameters and the original command content are Base64-encoded, the size of the Base64-encoded command content cannot exceed 24 KB.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use empty strings.</description></item>
        /// </list>
        /// <para>Default value: empty. This indicates that the key-value pairs of custom parameters are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
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
