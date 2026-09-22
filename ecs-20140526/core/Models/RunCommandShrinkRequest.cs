// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content. The command content can be plaintext or Base64-encoded. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The command content cannot exceed 24 KB after Base64 encoding. You can use <c>KeepCommand</c> to specify whether to retain the command.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, you must set <c>ContentEncoding=Base64</c>.</para>
        /// </description></item>
        /// <item><description><para>When <c>EnableParameter=true</c>, you can enable the custom parameter feature in the command content:</para>
        /// <list type="bullet">
        /// <item><description>Define custom parameters by enclosing them in <c>{{}}</c>. Spaces and line breaks before and after the parameter name within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>The number of custom parameters cannot exceed 20.</description></item>
        /// <item><description>Custom parameter names can contain a-zA-Z0-9-_ combinations. The acs:: prefix for specifying non-built-in environment parameters is not supported. Other characters are not supported. Parameter names are case-insensitive.</description></item>
        /// <item><description>Each custom parameter name cannot exceed 64 bytes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters. When running the command, you do not need to manually assign values to these parameters because Cloud Assistant automatically replaces them with the corresponding values. The following built-in environment parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{{ACS::RegionId}}</c>: The region ID.</description></item>
        /// <item><description><c>{{ACS::AccountId}}</c>: The UID of the Alibaba Cloud account.</description></item>
        /// <item><description><c>{{ACS::InstanceId}}</c>: The instance ID. When a command is sent to multiple instances and you want to use <c>{{ACS::InstanceId}}</c> as a built-in environment parameter, make sure Cloud Assistant Agent is at or above the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InstanceName}}</c>: The instance name. When a command is sent to multiple instances and you want to use <c>{{ACS::InstanceName}}</c> as a built-in environment parameter, make sure Cloud Assistant Agent is at or above the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InvokeId}}</c>: The invocation ID. To use <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, make sure Cloud Assistant Agent is at or above the following versions:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::CommandId}}</c>: The command ID. When calling this operation to run a command and you want to use <c>{{ACS::CommandId}}</c> as a built-in environment parameter, make sure Cloud Assistant Agent is at or above the following versions: <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. You can use the <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> prefix to specify the container runtime.</para>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, Cloud Assistant runs the script in the specified container of the instance.</description></item>
        /// <item><description>If this parameter is specified, the command can only run on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</description></item>
        /// <item><description>If this parameter is specified, the <c>Username</c> and <c>WorkingDir</c> parameters do not take effect. The command runs only as the default container user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>Only Shell scripts are supported in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of the script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, Cloud Assistant runs the script in the specified container of the instance.</description></item>
        /// <item><description>If this parameter is specified, the command can only run on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</description></item>
        /// <item><description>If this parameter is specified, the <c>Username</c> and <c>WorkingDir</c> parameters do not take effect. The command runs only as the default container user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>Only Shell scripts are supported in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of the script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-container</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The encoding method of the command content (<c>CommandContent</c>). Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description>PlainText: no encoding. The content is transmitted in plaintext.</description></item>
        /// <item><description>Base64: Base64 encoding.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If an invalid value is specified, it is treated as PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The command description. All character sets are supported. The description can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the command contains custom parameters.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The schedule for running the command. Three scheduling methods are supported: execution at fixed intervals (based on a Rate expression), one-time execution at a specified time, and clock-based scheduled execution (based on a Cron expression).</para>
        /// <list type="bullet">
        /// <item><description><para>Execution at fixed intervals: Based on a Rate expression, the command runs at the specified interval. The interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This method is suitable for scenarios that require execution at fixed intervals. Format: <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to run the command every 5 minutes, use <c>rate(5m)</c>. The following limits apply to fixed-interval execution:</para>
        /// <list type="bullet">
        /// <item><description>The interval cannot exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The interval is based on a fixed frequency and is not related to the actual execution time of the task. For example, if the command is set to run every 5 minutes and the task takes 2 minutes to complete, the next round starts 3 minutes after the task completes.</description></item>
        /// <item><description>The task does not run immediately upon creation. For example, if the command is set to run every 5 minutes, it does not run immediately when the task is created. Instead, it starts running 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: Runs the command once at the specified time zone and time. Format: <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If no time zone is specified, UTC is used by default. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: such as <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (UTC+8) or <c>GMT-7:00</c> (UTC-7). When using the GMT format, leading zeros are not supported for the hour value.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to run the command once at 13:15:30 on June 6, 2022 in China/Shanghai time, use: <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To run the command once at 13:15:30 on June 6, 2022 in UTC-7, use: <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on a Cron expression): Based on a Cron expression, the command runs according to the specified schedule. Format: <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated based on the Cron expression in the specified time zone. If no time zone is specified, the system time zone of the instance running the scheduled task is used. For more information about Cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: such as <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (UTC+8) or <c>GMT-7:00</c> (UTC-7). When using the GMT format, leading zeros are not supported for the hour value.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.
        /// For example, to run the command once every day at 10:15 AM in China/Shanghai time in 2022, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To run the command every 30 minutes from 10:00 AM to 11:30 AM every day in UTC+8 in 2022, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To run the command every 5 minutes from 2:00 PM to 2:55 PM every day in October every two years starting from 2022 in UTC, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum interval must be greater than or equal to the timeout period of the scheduled task and no less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The array of ECS instance IDs. Array length: 1 to 100.</para>
        /// <para>If any of the specified instances does not meet the conditions to execute the command, you must reselect the instances.</para>
        /// <para>You can also request a quota increase in Quota Center (quota name: Maximum number of instances that can execute commands).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6neg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the command after execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Retains the command. You can run it again by calling InvokeCommand. The command counts toward the Cloud Assistant command retention quota.</description></item>
        /// <item><description>false: Does not retain the command. The command is automatically deleted after execution and does not count toward the Cloud Assistant command retention quota.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeepCommand")]
        [Validation(Required=false)]
        public bool? KeepCommand { get; set; }

        /// <summary>
        /// <para>The bootstrap program for script execution. The value cannot exceed 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The command name. All character sets are supported. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration for command execution output.</para>
        /// <list type="bullet">
        /// <item><description>Format: oss://${BucketName}/${Prefix}, where ${BucketName} is the name of the destination OSS bucket and ${Prefix} is the directory prefix for delivery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://testBucket/testPrefix</para>
        /// </summary>
        [NameInMap("OssOutputDelivery")]
        [Validation(Required=false)]
        public string OssOutputDelivery { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key-value pairs of custom parameters to pass in when the command contains custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can pass in the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c> through the Parameter parameter. The custom parameter automatically replaces the variable value <c>name</c>, and the actual command executed is <c>echo Jack</c>.</para>
        /// <para>The number of custom parameters ranges from 0 to 10. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Keys cannot be empty strings and can be up to 64 characters in length.</description></item>
        /// <item><description>Values can be empty strings.</description></item>
        /// <item><description>After the custom parameters and original command content are Base64-encoded, the total size of the command content cannot exceed 24 KB. You can use <c>KeepCommand</c> to specify whether to retain the command.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use empty strings as substitutes.</description></item>
        /// </list>
        /// <para>Default value: empty, which disables custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The execution mode of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: Runs the command immediately.</description></item>
        /// <item><description>Period: Runs the command on a schedule. When this parameter is set to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: Automatically runs the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: Automatically runs the command each time the instance starts.</description></item>
        /// <item><description>DryRun: Only performs a dry run of the request. The command is not actually executed. The dry run checks request parameters, instance execution environment, and Cloud Assistant Agent status.</description></item>
        /// </list>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>When the <c>Frequency</c> parameter is not specified, the default value is <c>Once</c>.</description></item>
        /// <item><description>When the <c>Frequency</c> parameter is specified, the command is processed as <c>Period</c> regardless of whether this parameter is set.</description></item>
        /// </list>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> to stop a pending or scheduled command.</description></item>
        /// <item><description>When this parameter is set to <c>Period</c> or <c>EveryReboot</c>, you can call <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> and specify <c>IncludeHistory=true</c> to view the execution history of the scheduled command.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group for the command execution. When this parameter is specified:</para>
        /// <list type="bullet">
        /// <item><description><para>If the ECS instance specified by InstanceId belongs to a non-default resource group, the ECS instance must belong to this resource group.</para>
        /// </description></item>
        /// <item><description><para>You can filter command execution results by specifying this parameter (by calling <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> or <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a>).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags used to filter instances. Array length: 0 to 20. You can run commands in batches on instances that have the same tags without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestResourceTag> ResourceTag { get; set; }
        public class RunCommandShrinkRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key used to filter instances.</para>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter conflicts with the InstanceId parameter. You cannot specify both parameters at the same time.</para>
            /// </description></item>
            /// <item><description><para>If this value is specified, it cannot be an empty string.</para>
            /// </description></item>
            /// <item><description><para>The number of instances under the tag cannot exceed the limit of InstanceId.N. If the number of instances exceeds the limit, control the number of instances by adding batch tags, such as batch: b1.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value used to filter instances.</para>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description>The value can be an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length and cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tags. Array length: 0 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestTag> Tag { get; set; }
        public class RunCommandShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key to use when you execute the command. If this value is specified, it cannot be an empty string.</para>
            /// <para>When you use a single tag to filter resources, the resource count under that tag cannot exceed 1,000. When you use multiple tags to filter resources, the resource count that are attached to all specified tags cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. The value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The mode for stopping the task (manual stop or timeout interruption). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Process: Stops the current script process.</description></item>
        /// <item><description>ProcessTree: Stops the current process tree (the collection of the script process and all child processes it created).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. Specifying this parameter has no effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// <para>The timeout period for command execution. Unit: seconds.</para>
        /// <para>When a command cannot run due to process issues, missing modules, or missing Cloud Assistant Agent, a timeout occurs. When a timeout occurs, the command process is forcefully terminated.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: Bat command for Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command for Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell command for Linux instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The username for running the command on the ECS instance. The value can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux ECS instances, the command is run as the root user by default.</description></item>
        /// <item><description>For Windows ECS instances, the command is run as the System user by default.</description></item>
        /// </list>
        /// <para>You can also specify another existing user on the instance to run the command. Running Cloud Assistant commands as a regular user is more secure. For more information, see <a href="https://help.aliyun.com/document_detail/203771.html">Configure a regular user to run Cloud Assistant commands</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the password for the user who executes the command on a Windows instance. The name can be up to 255 characters in length.</para>
        /// <para>If you want to execute a command as a non-default user (System) on a Windows instance, you must specify both <c>Username</c> and this parameter. To reduce the risk of password leaks, store the plaintext password in the parameter repository of Operations Management in Settings and specify only the password name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encryption parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Configure a regular user to execute Cloud Assistant commands</a>.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter if you execute the command as the root user on a Linux instance or the System user on a Windows instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The working directory of the command on the ECS instance. The value can be up to 200 characters in length.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the default directory is the home directory of the root user, which is <c>/root</c>.</description></item>
        /// <item><description>For Windows instances, the default directory is the directory where the Cloud Assistant Agent process is located, such as <c>C:\\Windows\\System32</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/home/user</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
