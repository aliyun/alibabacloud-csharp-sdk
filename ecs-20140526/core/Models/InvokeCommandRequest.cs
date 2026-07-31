// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandRequest : TeaModel {
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
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. Container IDs that are prefixed with <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> are supported to specify the container runtime.</para>
        /// <para>Usage notes:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can be run only on Linux instances that have Cloud Assistant Agent 2.2.3.344 or later installed.</para>
        /// <list type="bullet">
        /// <item><description>To view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install Cloud Assistant Agent</a>.</description></item>
        /// <item><description>To upgrade Cloud Assistant Agent, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable upgrades for Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command is run only by the default user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only shell scripts can be run in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of a script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <para>Usage notes:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can be run only on Linux instances that have Cloud Assistant Agent 2.2.3.344 or later installed.</para>
        /// <list type="bullet">
        /// <item><description>To view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install Cloud Assistant Agent</a>.</description></item>
        /// <item><description>To upgrade Cloud Assistant Agent, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable upgrades for Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command is run only by the default user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only shell scripts can be run in Linux containers. You cannot use a format such as <c>#!/usr/bin/python</c> at the beginning of a script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <para>The schedule on which the command is run. Three types of scheduled execution are supported: fixed interval (Rate expression-based), one-time execution at a specified time, and clock-based scheduling (Cron expression-based).</para>
        /// <list type="bullet">
        /// <item><description><para>Fixed interval execution: Based on a Rate expression, the command is run at a set interval. The interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This is suitable for scenarios that require execution at fixed intervals. Format: <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to run the command every 5 minutes, use <c>rate(5m)</c>. Fixed interval execution has the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The interval must not exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The interval is based on a fixed frequency and is unrelated to the actual execution time of the task. For example, if the command is set to run every 5 minutes and the task takes 2 minutes to complete, the next round starts 3 minutes after the task completes.</description></item>
        /// <item><description>The task is not run immediately upon creation. For example, if the command is set to run every 5 minutes, it does not run immediately when the task is created. Instead, it starts running 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: The command is run once at the specified time zone and time. Format: <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If no time zone is specified, UTC is used by default. The time zone can be specified in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> or <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> or <c>GMT-7:00</c>. When using the GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to run the command once at 13:15:30 on June 6, 2022 in the Asia/Shanghai time zone, use: <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To run the command once at 13:15:30 on June 6, 2022 in GMT-7:00, use: <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduling (Cron expression-based): Based on a Cron expression, the command is run according to the specified schedule. Format: <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>. The scheduled execution time is calculated based on the Cron expression in the specified time zone. If no time zone is specified, the system time zone of the instance running the scheduled task is used. For more information about Cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone can be specified in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> or <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> or <c>GMT-7:00</c>. When using the GMT format, leading zeros are not supported in the hour field.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.
        /// For example, to run the command once a day at 10:15 in the Asia/Shanghai time zone in 2022, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To run the command every 30 minutes from 10:00 to 11:30 every day in GMT+8:00 in 2022, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To run the command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in UTC, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
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
        /// <para>The list of instances on which to run the command. You can specify up to 100 instance IDs. Valid values of N: 1 to 100.</para>
        /// <para>You can also apply for a quota increase in Quota Center (quota name: Maximum number of instances supported for command execution).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6n****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

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
        /// <para>The key-value pairs of custom parameters to pass in when the custom parameter feature is enabled. The number of custom parameters ranges from 0 to 10.</para>
        /// <list type="bullet">
        /// <item><description>Map keys cannot be empty strings and can be up to 64 characters in length.</description></item>
        /// <item><description>Map values can be empty strings.</description></item>
        /// <item><description>After Base64 encoding, the total length of the custom parameters and the original command content cannot exceed 18 KB.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use empty strings as substitutes.</description></item>
        /// </list>
        /// <para>You can unset this parameter to disable custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

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
        /// <item><description>Once: immediately runs the command.</description></item>
        /// <item><description>Period: runs the command on a schedule. If you set this parameter to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: automatically runs the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically runs the command every time the instance starts.</description></item>
        /// <item><description>DryRun: performs a dry run of the request without actually running the command. The dry run checks request parameters, instance execution environment, and Cloud Assistant Agent status.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <c>Frequency</c> parameter, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify the <c>Frequency</c> parameter, the command is run on a schedule regardless of whether you set this parameter. The value is treated as <c>Period</c>.</description></item>
        /// </list>
        /// <para>Usage notes:</para>
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
        /// <para>The tags used to filter instances. You can run a command in batches on instances that have the same tag without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<InvokeCommandRequestResourceTag> ResourceTag { get; set; }
        public class InvokeCommandRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key used to filter instances.</para>
            /// <para>Usage notes:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter conflicts with the InstanceId parameter. You cannot specify both parameters at the same time.</para>
            /// </description></item>
            /// <item><description><para>Valid values of N: 1 to 10. The tag key cannot be an empty string once specified.</para>
            /// </description></item>
            /// <item><description><para>The number of instances with the specified tag cannot exceed the limit of InstanceId.N. If the number of instances exceeds the limit, control the number of instances by adding batch tags, such as batch: b1.</para>
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
            /// <para>Usage notes:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 10.</description></item>
            /// <item><description>The tag value can be an empty string.</description></item>
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
        public List<InvokeCommandRequestTag> Tag { get; set; }
        public class InvokeCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command execution. Valid values of N: 1 to 20. The tag key cannot be an empty string once specified.</para>
            /// <para>If you use a single tag to filter resources, the number of resources with this tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources that are attached with all specified tags cannot exceed 1,000. If the number of resources exceeds 1,000, execute the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
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
        /// <para>The mode in which the task is stopped (manually stopped or interrupted due to timeout). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Process: stops the current script process.</description></item>
        /// <item><description>ProcessTree: stops the current process tree (the script process and all child processes it created).</description></item>
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
        /// <item><description><para>The value must be at least 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>If the command cannot be run due to process issues, missing modules, or missing Cloud Assistant Agent, a timeout occurs. When a timeout occurs, the command process is forcefully terminated.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the timeout period specified when the command was created is used.</para>
        /// </description></item>
        /// <item><description><para>This value applies only to the current command execution and does not change the timeout period of the command itself.</para>
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
        /// <para>The username used to run the command on the ECS instance. The username can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the root user is used by default.</description></item>
        /// <item><description>For Windows instances, the System user is used by default.</description></item>
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
        /// <para>To execute a command as a non-default user (System) on a Windows instance, you must specify both <c>Username</c> and this parameter. To reduce the risk of password leaks, store the plaintext password in the parameter repository of operations management, and pass in only the password name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encryption parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Configure a regular user to execute Cloud Assistant commands</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required when you use the root user on a Linux instance or the System user on a Windows instance to execute the command.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The directory in which the command is run on the ECS instance. The value can be up to 200 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the working directory specified when the command was created is used.</description></item>
        /// <item><description>This value applies only to the current command execution and does not change the working directory of the command itself.</description></item>
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
