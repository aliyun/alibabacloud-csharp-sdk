// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content. The command content can be plaintext or Base64-encoded. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the Base64-encoded command content cannot exceed 24 KB. You can use the <c>KeepCommand</c> parameter to specify whether to retain the command.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, you must set <c>ContentEncoding</c> to Base64.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>EnableParameter</c> to true, you can use custom parameters in the command content:</para>
        /// <list type="bullet">
        /// <item><description>Use <c>{{}}</c> to enclose custom parameters. Spaces and line breaks before and after the parameter names within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>You can define up to 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain letters, digits, hyphens (-), and underscores (_). The <c>acs::</c> prefix cannot be used to specify non-built-in environment variables. Other characters are not supported. Parameter names are not case-sensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment variables as custom parameters. When the command is run, you do not need to manually assign values to the parameters. Cloud Assistant automatically replaces them with the corresponding values in the environment. The following built-in environment variables are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{{ACS::RegionId}}</c>: the region ID.</description></item>
        /// <item><description><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</description></item>
        /// <item><description><c>{{ACS::InstanceId}}</c>: the instance ID. If the command is delivered to multiple instances and you want to specify <c>{{ACS::InstanceId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent is of the following versions or later:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InstanceName}}</c>: the instance name. If the command is delivered to multiple instances and you want to specify <c>{{ACS::InstanceName}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent is of the following versions or later:<list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::InvokeId}}</c>: the invocation ID. If you want to specify <c>{{ACS::InvokeId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent is of the following versions or later:<list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>{{ACS::CommandId}}</c>: the command ID. If you call this operation to run a command and want to specify <c>{{ACS::CommandId}}</c> as a built-in environment variable, make sure that the Cloud Assistant Agent is of the following versions or later: <list type="bullet">
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
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. The <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> prefix is allowed to explicitly specify the container runtime.</para>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, Cloud Assistant runs the script in the specified container on the instance.</description></item>
        /// <item><description>If you specify this parameter, it is only supported on Linux instances where the Cloud Assistant Agent version is 2.2.3.344 or later.</description></item>
        /// <item><description>If you specify this parameter, the specified <c>Username</c> and <c>WorkingDir</c> parameters do not take effect. The command can only be run by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>Only Shell scripts can be run in Linux containers. You cannot use a command similar to <c>#!/usr/bin/python</c> at the beginning of the script to specify the interpreter for the script content. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <item><description>If you specify this parameter, Cloud Assistant runs the script in the specified container on the instance.</description></item>
        /// <item><description>If you specify this parameter, it is only supported on Linux instances where the Cloud Assistant Agent version is 2.2.3.344 or later.</description></item>
        /// <item><description>If you specify this parameter, the specified <c>Username</c> and <c>WorkingDir</c> parameters do not take effect. The command can only be run by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.<remarks>
        /// <para>Only Shell scripts can be run in Linux containers. You cannot use a command similar to <c>#!/usr/bin/python</c> at the beginning of the script to specify the interpreter for the script content. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <list type="bullet">
        /// <item><description>PlainText: no encoding. The command content is transmitted in plaintext.</description></item>
        /// <item><description>Base64: Base64 encoding.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If you enter an invalid value, it is processed as PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The command description. It supports all character sets and can be up to 512 characters in length.</para>
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
        /// <para>The execution time of the scheduled command. Three scheduled execution modes are supported: execution at fixed time intervals (based on rate expressions), one-time execution at a specified time, and clock-based scheduled execution (based on cron expressions).</para>
        /// <list type="bullet">
        /// <item><description><para>Execution at fixed time intervals: runs the command at the specified time interval based on a rate expression. The time interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This mode is suitable for scenarios where tasks are run at fixed time intervals. The format is <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to run the command every 5 minutes, the format is <c>rate(5m)</c>. The following limits apply to execution at fixed time intervals:</para>
        /// <list type="bullet">
        /// <item><description>The specified time interval must not exceed 7 days, must not be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The execution interval is based only on the fixed frequency and is independent of the actual time required to run the task. For example, if you set the command to run every 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task is completed.</description></item>
        /// <item><description>The task is not run immediately when it is created. For example, if you set the command to run every 5 minutes, the command is not run immediately when the task is created. Instead, it starts to run 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: runs the command once at the specified time zone and execution time. The format is <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>, which is <c>at(year-month-day hour:minute:second &lt;time zone&gt;)</c>. If you do not specify a time zone, the UTC time zone is used by default. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: such as <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (East 8th time zone) and <c>GMT-7:00</c> (West 7th time zone). When you use the GMT format, leading zeros are not supported for the hour digit.</description></item>
        /// <item><description>Time zone abbreviation: only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to run the command once at 13:15:30 on June 6, 2022 in the China/Shanghai time zone, the format is <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To run the command once at 13:15:30 on June 6, 2022 in the West 7th time zone, the format is <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on cron expressions): runs the command based on a cron expression. The format is <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, which is <c>&lt;cron expression&gt; &lt;time zone&gt;</c>. In the specified time zone, the scheduled task execution time is calculated based on the cron expression and the task is run. If you do not specify a time zone, the internal system time zone of the instance that runs the scheduled task is used by default. For more information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: such as <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: such as <c>GMT+8:00</c> (East 8th time zone) and <c>GMT-7:00</c> (West 7th time zone). When you use the GMT format, leading zeros are not supported for the hour digit.</description></item>
        /// <item><description>Time zone abbreviation: only UTC (Coordinated Universal Time) is supported.
        /// For example, to run the command once at 10:15 every day in 2022 in the China/Shanghai time zone, the format is <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To run the command every half hour from 10:00 to 11:30 every day in 2022 in the East 8th time zone, the format is <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To run the command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in the UTC time zone, the format is <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum time interval must be greater than or equal to the timeout period of the scheduled task and must not be less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The array of ECS instance IDs. Array length: 1 to 100.</para>
        /// <para>If you specify multiple instances and one of the instances does not meet the execution conditions, you must reselect the instances.</para>
        /// <para>You can also apply for a quota increase in Quota Center. The quota name is the maximum number of instances that support command execution.</para>
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
        /// <item><description>true: retains the command. You can call the InvokeCommand operation to run the command again. This consumes the quota for retained Cloud Assistant commands.</description></item>
        /// <item><description>false: does not retain the command. The command is automatically deleted after it is run and does not consume the quota for retained Cloud Assistant commands.</description></item>
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
        /// <para>The bootstrap program for script execution. It cannot exceed 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The command name. It supports all character sets and can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration for the command execution output.</para>
        /// <list type="bullet">
        /// <item><description>Format: oss://${BucketName}/${Prefix}. ${BucketName} is the name of the OSS bucket to which the output is delivered, and ${Prefix} is the directory prefix to which the output is delivered.</description></item>
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
        /// <para>The key-value pairs of custom parameters that are passed in when the command is run, if the command contains custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can pass in the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c> by using the <c>Parameter</c> parameter. The custom parameter automatically replaces the variable value <c>name</c>, and a new command is generated. The actual command that is run is <c>echo Jack</c>.</para>
        /// <para>The number of custom parameters ranges from 0 to 10. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The key cannot be an empty string and can be up to 64 characters in length.</description></item>
        /// <item><description>The value can be an empty string.</description></item>
        /// <item><description>After the custom parameters and the original command content are Base64-encoded, the size of the Base64-encoded command content cannot exceed 24 KB. You can use the <c>KeepCommand</c> parameter to specify whether to retain the command.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command is created. For parameters that are not passed in, you can use empty strings instead.</description></item>
        /// </list>
        /// <para>The default value is empty, which indicates that this parameter is not set and the custom parameter feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description>Once: runs the command immediately.</description></item>
        /// <item><description>Period: runs the command on a schedule. If you set this parameter to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: automatically runs the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically runs the command every time the instance starts.</description></item>
        /// <item><description>DryRun: prechecks the request only. The command is not actually run. The check items include the request parameters, instance execution environment, and Cloud Assistant Agent running status.</description></item>
        /// </list>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <c>Frequency</c> parameter, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify the <c>Frequency</c> parameter, the value is processed as <c>Period</c> regardless of whether this parameter is set.</description></item>
        /// </list>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> operation to stop a pending command or a scheduled command.</description></item>
        /// <item><description>If you set this parameter to <c>Period</c> or <c>EveryReboot</c>, you can call the <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation and set <c>IncludeHistory</c> to true to view the historical records of the scheduled command execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the command execution belongs. When you specify this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>If the ECS instance specified by InstanceId belongs to a non-default resource group, the ECS instance must belong to this resource group.</para>
        /// </description></item>
        /// <item><description><para>You can specify this parameter to filter the corresponding command execution results by calling the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> or <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation.</para>
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
        /// <para>The array of tags used to filter instances. Array length: 0 to 20. You can run the command on multiple instances that have the same tags without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<RunCommandRequestResourceTag> ResourceTag { get; set; }
        public class RunCommandRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key used to filter instances.</para>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter conflicts with the InstanceId parameter and they cannot be specified at the same time.</para>
            /// </description></item>
            /// <item><description><para>It cannot be an empty string once specified.</para>
            /// </description></item>
            /// <item><description><para>The number of instances under the tag cannot exceed the limit on the number of InstanceId.N parameters. If the number of instances exceeds the limit, we recommend that you control the number of instances by adding batch tags, such as batch: b1.</para>
            /// </description></item>
            /// <item><description><para>It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
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
            /// <item><description>It can be an empty string.</description></item>
            /// <item><description>It can be up to 128 characters in length and cannot contain http:// or https://.</description></item>
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
        /// <para>The array of tags. Array length: 0 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandRequestTag> Tag { get; set; }
        public class RunCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command to execute. It cannot be an empty string once specified.</para>
            /// <para>If you use a single tag to filter resources, the resource count under the tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that are attached to all the specified tags cannot exceed 1,000. If the resource count exceeds 1,000, you must use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>It can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. It can be an empty string.</para>
            /// <para>It can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The mode used when the task is stopped (manually stopped or interrupted due to execution timeout). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Process: stops the current script process.</description></item>
        /// <item><description>ProcessTree: stops the current process tree (the set of the script process and all child processes created by it).</description></item>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// <para>The timeout period for running the command. Unit: seconds.</para>
        /// <para>If the command cannot be run because of process issues, missing modules, or a missing Cloud Assistant Agent, a timeout occurs. After a timeout, the command process is forcefully terminated.</para>
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
        /// <item><description>RunBatScript: Bat commands for Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell commands for Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell commands for Linux instances.</description></item>
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
        /// <para>The username that is used to run the command on the ECS instance. It can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux ECS instances, the command is run by the root user by default.</description></item>
        /// <item><description>For Windows ECS instances, the command is run by the System user by default.</description></item>
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
        /// <para>The password name of the user that is used to execute the command on the Windows instance. It can be up to 255 characters in length.</para>
        /// <para>If you want to execute the command as a non-default user (System) on a Windows instance, you must specify both <c>Username</c> and this parameter. To reduce the risk of password leakage, you must host the plaintext password in the parameter repository of CloudOps Orchestration Service and pass in only the password name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encrypt parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Settings for regular users to execute Cloud Assistant commands</a>.</para>
        /// <remarks>
        /// <para>You do not need to pass in this parameter when you execute the command as the root user on a Linux instance or the System user on a Windows instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The running directory of the command on the ECS instance. It can be up to 200 characters in length.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the default running directory is the home directory of the root user, which is <c>/root</c>.</description></item>
        /// <item><description>For Windows instances, the default running directory is the directory where the Cloud Assistant Agent process resides, such as <c>C:\\Windows\\System32</c>.</description></item>
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
