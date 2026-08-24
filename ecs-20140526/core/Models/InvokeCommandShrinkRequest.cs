// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command ID. You can call <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> to query all available command IDs. </para>
        /// <remarks>
        /// <para>You can run public commands by specifying the command name. For more information, see <a href="https://help.aliyun.com/document_detail/429635.html">View and run Cloud Assistant public commands</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-e996287206324975b5fbe1d****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. You can use the <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> prefix to specify the container runtime.</para>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, Cloud Assistant executes the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can only run on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</para>
        /// <list type="bullet">
        /// <item><description>To view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install Cloud Assistant Agent</a>.</description></item>
        /// <item><description>To upgrade the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable upgrades for Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command can only be executed by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only Shell scripts can be executed in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of the script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <item><description><para>If you specify this parameter, Cloud Assistant executes the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can only run on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</para>
        /// <list type="bullet">
        /// <item><description>To view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install Cloud Assistant Agent</a>.</description></item>
        /// <item><description>To upgrade the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable upgrades for Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command can only be executed by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only Shell scripts can be executed in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of the script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <para>The schedule on which the command is executed. Three types of scheduled execution are supported: fixed interval (based on a Rate expression), one-time execution at a specified time, and clock-based scheduling (based on a Cron expression).</para>
        /// <list type="bullet">
        /// <item><description><para>Fixed interval execution: Based on a Rate expression, the command is executed at a set interval. The interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This is suitable for scenarios that require execution at fixed intervals. Format: <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to execute every 5 minutes, use <c>rate(5m)</c>. Fixed interval execution has the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The interval must not exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The execution interval is based on a fixed frequency and is unrelated to the actual execution time of the task. For example, if the command is set to execute every 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task completes.</description></item>
        /// <item><description>The task is not executed immediately upon creation. For example, if the command is set to execute every 5 minutes, the first execution starts 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: The command is executed once at the specified time zone and time. Format: <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If no time zone is specified, UTC is used by default. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> (East 8th time zone) or <c>GMT-7:00</c> (West 7th time zone). When using GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute once at 13:15:30 on June 6, 2022 in China/Shanghai time, use: <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To execute once at 13:15:30 on June 6, 2022 in the West 7th time zone, use: <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduling (based on a Cron expression): Based on a Cron expression, the command is executed according to the scheduled task settings. Format: <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, that is, <c>&lt;Cron expression&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated based on the Cron expression in the specified time zone. If no time zone is specified, the system time zone of the instance running the scheduled task is used. For more information about Cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> (East 8th time zone) or <c>GMT-7:00</c> (West 7th time zone). When using GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.
        /// For example, to execute once at 10:15 every day in 2022 in China/Shanghai time, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To execute every 30 minutes from 10:00 to 11:30 every day in 2022 in the East 8th time zone, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To execute every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in UTC, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
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
        /// <para>The list of instances on which to execute the command. You can specify up to 100 instance IDs. Valid values of N: 1 to 100.</para>
        /// <para>You can also apply for a quota increase in Quota Center (quota name: Maximum number of instances supported for command execution).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6n****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The bootstrap program for script execution. The length cannot exceed 1 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration for command execution output.</para>
        /// <list type="bullet">
        /// <item><description>Format: oss://${BucketName}/${Prefix}, where ${BucketName} is the name of the OSS bucket to deliver to, and ${Prefix} is the directory prefix to deliver to.</description></item>
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
        /// <para>The key-value pairs of custom parameters to pass in when executing the command with the custom parameter feature enabled. The number of custom parameters ranges from 0 to 10.</para>
        /// <list type="bullet">
        /// <item><description>Map keys cannot be empty strings and can contain up to 64 characters.</description></item>
        /// <item><description>Map values can be empty strings.</description></item>
        /// <item><description>After Base64 encoding, the total length of custom parameters and the original command content cannot exceed 24 KB.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use an empty string as a substitute.</description></item>
        /// </list>
        /// <para>You can disable custom parameters by not setting this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI************&quot;}</para>
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
        /// <item><description>Once: immediately executes the command.</description></item>
        /// <item><description>Period: executes the command on a schedule. If you set this parameter to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: automatically executes the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically executes the command every time the instance starts.</description></item>
        /// <item><description>DryRun: only performs a dry run of the request. The command is not actually executed. The dry run checks request parameters, the instance execution environment, and the Cloud Assistant Agent running status.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <c>Frequency</c> parameter, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify the <c>Frequency</c> parameter, the command is executed as <c>Period</c> regardless of whether this parameter is set.</description></item>
        /// </list>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> to stop a pending or scheduled command.</description></item>
        /// <item><description>If you set this parameter to <c>Period</c> or <c>EveryReboot</c>, you can call <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> and specify <c>IncludeHistory=true</c> to view the execution history of the scheduled command.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group for the command execution. When you specify this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The ECS instance specified by InstanceId must belong to this resource group if the instance is not in the default resource group.</para>
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
        /// <para>The tags used to filter instances. You can run commands in batches on instances with the same tag without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<InvokeCommandShrinkRequestResourceTag> ResourceTag { get; set; }
        public class InvokeCommandShrinkRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key used to filter instances.</para>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter conflicts with the InstanceId parameter. You cannot specify both parameters at the same time.</para>
            /// </description></item>
            /// <item><description><para>Valid values of N: 1 to 10. The tag key cannot be an empty string once specified.</para>
            /// </description></item>
            /// <item><description><para>The number of instances with the tag cannot exceed the limit of InstanceId.N. If the number of instances exceeds the limit, control the number of instances by adding batch tags, such as batch: b1.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 64 characters in length and cannot start with aliyun or acs:, or contain http:// or https://.</para>
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
            /// <item><description>Valid values of N: 1 to 10.</description></item>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InvokeCommandShrinkRequestTag> Tag { get; set; }
        public class InvokeCommandShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command execution. Valid values of N: 1 to 20. The tag key cannot be an empty string once specified.</para>
            /// <para>If you use a single tag to filter resources, the resource count with this tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count with all specified tags attached cannot exceed 1,000. If the resource count exceeds 1,000, execute the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The value can be an empty string.</para>
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
        /// <item><description>Process: stops the current script process.</description></item>
        /// <item><description>ProcessTree: stops the current process tree (the collection of the script process and all child processes it created).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated and has no effect if specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// <para>The timeout period for the command execution. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot be less than 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>If the command cannot run due to process issues, missing modules, or missing Cloud Assistant Agent, a timeout occurs. When a timeout occurs, the command process is forcefully terminated.</para>
        /// </description></item>
        /// <item><description><para>If this value is not set, the timeout period specified when the command was created is used.</para>
        /// </description></item>
        /// <item><description><para>This value only applies as the timeout period for this command execution and does not change the timeout period of the command itself.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The username used to execute the command on the ECS instance. The length cannot exceed 255 characters.</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the command is executed as the root user by default.</description></item>
        /// <item><description>For Windows instances, the command is executed as the System user by default.</description></item>
        /// </list>
        /// <para>You can also specify another existing user on the instance to execute the command. Executing Cloud Assistant commands as a regular user is more secure. For more information, see <a href="https://help.aliyun.com/document_detail/203771.html">Configure a regular user to run Cloud Assistant commands</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the password for the user who executes the command on a Windows instance. The length cannot exceed 255 characters.</para>
        /// <para>When you want to execute a command as a non-default user (System) on a Windows instance, you must specify both <c>Username</c> and this parameter. To reduce the risk of password leaks, the plaintext password must be stored in the parameter repository of CloudOps Orchestration Service. Only the password name is passed in here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encryption parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Settings for a regular user to run Cloud Assistant commands</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required when you execute a command as the root user on a Linux instance or the System user on a Windows instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The directory in which the command is executed on the ECS instance. The length cannot exceed 200 characters.</para>
        /// <list type="bullet">
        /// <item><description>If this value is not set, the working directory specified when the command was created is used.</description></item>
        /// <item><description>This value only applies as the working directory for this command execution and does not change the working directory of the command itself.</description></item>
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
