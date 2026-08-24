// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content. The command content can be plaintext or Base64-encoded. Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the command content after Base64 encoding cannot exceed 24 KB. You can use <c>KeepCommand</c> to specify whether to retain the command.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, set <c>ContentEncoding=Base64</c>.</para>
        /// </description></item>
        /// <item><description><para>Set <c>EnableParameter=true</c> to enable custom parameters in the command content:</para>
        /// <list type="bullet">
        /// <item><description>Custom parameters are defined by enclosing them in <c>{{}}</c>. Spaces and line breaks before and after the parameter name within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>A maximum of 20 custom parameters are supported.</description></item>
        /// <item><description>Custom parameter names can contain only a-z, A-Z, 0-9, hyphens (-), and underscores (_). The acs:: prefix for specifying non-built-in environment parameters is not supported. Other characters are not supported. Parameter names are case-insensitive.</description></item>
        /// <item><description>Each custom parameter name cannot exceed 64 bytes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters. When the command is run, Cloud Assistant automatically replaces the parameters with the corresponding values in the environment without manual assignment. The following built-in environment parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{{ACS::RegionId}}</c>: The region ID.</description></item>
        /// <item><description><c>{{ACS::AccountId}}</c>: The UID of the Alibaba Cloud account.</description></item>
        /// <item><description><c>{{ACS::InstanceId}}</c>: The instance ID. When the command is sent to multiple instances and you want to use <c>{{ACS::InstanceId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InstanceName}}</c>: The instance name. When the command is sent to multiple instances and you want to use <c>{{ACS::InstanceName}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following:<list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InvokeId}}</c>: The command execution ID. To use <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::CommandId}}</c>: The command ID. When you call this operation to run a command and want to use <c>{{ACS::CommandId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following:<list type="bullet">
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
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. The <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> prefix can be added to specify the container runtime.</para>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, Cloud Assistant runs the script in the specified container of the instance.</description></item>
        /// <item><description>If this parameter is specified, the script can run only on Linux instances whose Cloud Assistant Agent version is 2.2.3.344 or later.</description></item>
        /// <item><description>If this parameter is specified, the specified <c>Username</c> and <c>WorkingDir</c> parameters do not take effect. Commands can be run only by using the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>In Linux containers, only shell scripts are supported. You cannot use a command such as <c>#!/usr/bin/python</c> at the beginning of a script to specify the interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <item><description>If this parameter is specified, the script can run only on Linux instances whose Cloud Assistant Agent version is 2.2.3.344 or later.</description></item>
        /// <item><description>If this parameter is specified, the Username and WorkingDir parameters do not take effect. Commands can be run only by using the default user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>In Linux containers, only shell scripts can be run. You cannot specify an interpreter for the script content by adding a command such as <c>#!/usr/bin/python</c> to the beginning of the script. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <para>The encoding mode of the command content (<c>CommandContent</c>). Valid values (case-insensitive):</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The command description. The description supports all character sets and can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the command contains custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The execution time for scheduled command execution. Three scheduling methods are supported: fixed interval execution (based on Rate expressions), one-time execution at a specified time, and clock-based scheduled execution (based on Cron expressions).</para>
        /// <list type="bullet">
        /// <item><description><para>Fixed interval execution: Based on Rate expressions, commands are executed at the specified time interval. The time interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This method is suitable for scenarios that require task execution at fixed intervals. The format is <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to execute a command every 5 minutes, use <c>rate(5m)</c>. The following limits apply to fixed interval execution:</para>
        /// <list type="bullet">
        /// <item><description>The specified interval cannot exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The execution interval is based on a fixed frequency and is independent of the actual execution time of the task. For example, if a command is set to execute every 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task is completed.</description></item>
        /// <item><description>The task is not executed immediately upon creation. For example, if a command is set to execute every 5 minutes, the command is not executed immediately when the task is created. Instead, execution starts 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: The command is executed once at the specified time and time zone. The format is <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If no time zone is specified, the default is UTC. The following three time zone formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> (UTC+8) or <c>GMT-7:00</c> (UTC-7). When using the GMT format, leading zeros are not supported for the hour value.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute a command once at 13:15:30 on June 6, 2022 in China/Shanghai time, use <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To execute a command once at 13:15:30 on June 6, 2022 in UTC-7, use <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on Cron expressions): Based on Cron expressions, commands are executed according to the scheduled task settings. The format is <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, which is <c>&lt;Cron expression&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated based on the Cron expression in the specified time zone. If no time zone is specified, the default is the internal system time zone of the instance that runs the scheduled task. For more information about Cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The following three time zone formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>Full time zone name: For example, <c>Asia/Shanghai</c> (China/Shanghai time) or <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>GMT offset from Greenwich Mean Time: For example, <c>GMT+8:00</c> (UTC+8) or <c>GMT-7:00</c> (UTC-7). When using the GMT format, leading zeros are not supported for the hour value.</description></item>
        /// <item><description>Time zone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute a command once at 10:15 every day in 2022 in China/Shanghai time, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To execute a command every 30 minutes from 10:00 to 11:30 every day in 2022 in UTC+8, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To execute a command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in UTC, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</para>
        /// <remarks>
        /// <para>The minimum time interval must be greater than or equal to the timeout period of the scheduled task and no less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The ECS instance ID array. Array length: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6neg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the command after it is run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The command is retained. You can run it again by calling InvokeCommand. The command counts against the Cloud Assistant command quota.</description></item>
        /// <item><description>false: The command is not retained. It is automatically deleted after execution and does not count against the Cloud Assistant command quota.</description></item>
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
        /// <para>The bootstrap program for script execution. The value can be up to 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The command name. The name supports all character sets and can be up to 128 characters in length.</para>
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
        /// <item><description>Format: oss://${BucketName}/${Prefix}, where ${BucketName} is the name of the destination OSS bucket and ${Prefix} is the directory prefix of the destination.</description></item>
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
        /// <para>The key-value pairs of custom parameters to pass in when the command contains custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can use the <c>Parameter</c> parameter to pass in the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c>. The custom parameter automatically replaces the variable value <c>name</c>, and the command that is actually run is <c>echo Jack</c>.</para>
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
        /// <item><description>Once: immediately executes the command.</description></item>
        /// <item><description>Period: executes the command on a schedule. If you set this parameter to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: automatically executes the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically executes the command every time the instance starts.</description></item>
        /// <item><description>DryRun: performs only a dry run of the request without actually executing the command. The dry run checks items such as request parameters, instance execution environment, and Cloud Assistant Agent status.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If the <c>Frequency</c> parameter is not specified, the default value is <c>Once</c>.</description></item>
        /// <item><description>If the <c>Frequency</c> parameter is specified, the command is executed as <c>Period</c> regardless of whether this parameter is set.</description></item>
        /// </list>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> to stop a pending or scheduled command.</description></item>
        /// <item><description>If this parameter is set to <c>Period</c> or <c>EveryReboot</c>, you can call <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> and specify <c>IncludeHistory=true</c> to view the historical records of scheduled command executions.</description></item>
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
        /// <item><description><para>If the ECS instance specified by InstanceId belongs to a non-default resource group, the ECS instance must belong to this resource group.</para>
        /// </description></item>
        /// <item><description><para>You can filter command execution results by specifying this parameter when you call <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> or <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a>.</para>
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
        /// <para>The tags that are used to filter instances. Array length: 0 to 20. You can run commands on instances that have the same tags in batches without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestResourceTag> ResourceTag { get; set; }
        public class RunCommandShrinkRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key that is used to filter instances.</para>
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
            /// <item><description>The value can be up to 128 characters in length and cannot contain http:// or https://.</description></item>
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
            /// <para>The tag key of the command execution. If this value is specified, it cannot be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. The value can be an empty string.</para>
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
        /// <para>A timeout occurs when the command cannot run due to process issues, missing modules, or missing Cloud Assistant Agent. After a timeout, the command process is forcefully terminated.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the command. Valid values:</para>
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
        /// <para>The username that is used to run the command on the ECS instance. The username can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux ECS instances, the command is run by the root user by default.</description></item>
        /// <item><description>For Windows ECS instances, the command is run by the System user by default.</description></item>
        /// </list>
        /// <para>You can also specify another existing user of the instance to run the command. Running Cloud Assistant commands as a regular user is more secure. For more information, see <a href="https://help.aliyun.com/document_detail/203771.html">Run Cloud Assistant commands as a regular user</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the password for the user who runs the command on a Windows instance. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The working directory of the command on the ECS instance. Maximum length: 200 characters.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the default directory is the home directory of the root user, which is <c>/root</c>.</description></item>
        /// <item><description>For Windows instances, the default directory is the directory where the Cloud Assistant Agent process resides, such as <c>C:\\Windows\\System32</c>.</description></item>
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
