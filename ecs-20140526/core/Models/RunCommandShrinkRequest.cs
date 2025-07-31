// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The content of the command. The command content can be plaintext or Base64-encoded. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you want to retain the command, make sure that the size of the Base64-encoded command content does not exceed 18 KB. If you do not want to retain the command, make sure that the size of the Base64-encoded command content does not exceed 24 KB. You can set <c>KeepCommand</c> to specify whether to retain the command.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, set <c>ContentEncoding</c> to Base64.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>EnableParameter</c> to true, the custom parameter feature is enable. You can configure custom parameters based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>Specify custom parameters in the <c>{{}}</c> format. The spaces and line feeds before and after the parameter names within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>You can specify up to 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain letters, digits, underscores (_), and hyphens (-). The name is case-insensitive. The ACS:: prefix cannot be used to specify non-built-in environment parameters.</description></item>
        /// <item><description>Each custom parameter name cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters. When you run a command, the parameters are automatically specified by Cloud Assistant. You can specify the following built-in environment parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{{ACS::RegionId}}</c>: the region ID.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceId}}</c>: the instance ID. If you want to run the command on multiple instances and specify <c>{{ACS::InstanceId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceName}}</c>: the instance name. If you want to run the command on multiple instances and specify <c>{{ACS::InstanceName}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InvokeId}}</c>: the task ID. If you want to specify <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::CommandId}}</c>: the command ID. If you want to specify <c>{{ACS::CommandId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
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
        /// <para>The container ID. Only 64-bit hexadecimal strings are supported. <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> can be used as the prefix of the container ID to specify the container runtime.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, Cloud Assistant runs the command in the specified container of the instances.</description></item>
        /// <item><description>If you specify this parameter, make sure that the Cloud Assistant Agent version installed on Linux instances is 2.2.3.344 or later.</description></item>
        /// <item><description>If you specify this parameter, <c>Username</c> and <c>WorkingDir</c> do not take effect. You can run the command in the default working directory of the container by using only the default user of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only shell scripts can run in Linux containers. You cannot add a command whose format is similar to <c>#!/usr/bin/python</c> at the beginning of a script to specify a script interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, Cloud Assistant runs the command in the specified container of the instances.</description></item>
        /// <item><description>If you specify this parameter, make sure that the Cloud Assistant Agent version installed on Linux instances is 2.2.3.344 or later.</description></item>
        /// <item><description>If you specify this parameter, <c>Username</c> and <c>WorkingDir</c> do not take effect. You can run the command in the default working directory of the container by using only the default user of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only shell scripts can run in Linux containers. You cannot add a command whose format is similar to <c>#!/usr/bin/python</c> at the beginning of a script to specify a script interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-container</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The encoding mode of command content (<c>CommandContent</c>). The valid values are case-insensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The command content is not encoded.</description></item>
        /// <item><description>Base64: The command content is encoded in Base64.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If the specified value of this parameter is invalid, PlainText is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The description of the command. The description supports all character sets and can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to include custom parameters in the command.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The schedule on which to run the command. You can configure a command to run at a fixed interval based on a rate expression, run only once at a specified time, or run at designated times based on a cron expression.</para>
        /// <list type="bullet">
        /// <item><description><para>To run a command at a fixed interval, use a rate expression to specify the interval. You can specify the interval in seconds, minutes, hours, or days. This option is suitable for scenarios in which tasks need to be executed at a fixed interval. Specify the interval in the following format: <c>rate(&lt;Execution interval value&gt; &lt;Execution interval unit&gt;)</c>. For example, specify <c>rate(5m)</c> to run the command every 5 minutes. When you specify an interval, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The interval can be anywhere from 60 seconds to 7 days, but must be longer than the timeout period of the scheduled task.</description></item>
        /// <item><description>The interval is the amount of time that elapses between two consecutive executions. The interval is irrelevant to the amount of time that is required to run the command once. For example, assume that you set the interval to 5 minutes and that it takes 2 minutes to run the command each time. Each time the command is run, the system waits 3 minutes before the system runs the command again.</description></item>
        /// <item><description>A task is not immediately executed after the task is created. For example, assume that you set the interval to 5 minutes for a task. The task begins to be executed 5 minutes after it is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To run a command only once at a specific time, specify a point in time and a time zone. Specify the point in time in the <c>at(yyyy-MM-dd HH:mm:ss &lt;Time zone&gt;)</c> format, which indicates <c>at(Year-Month-Day Hour:Minute:Second &lt;Time zone&gt;)</c>. If you do not specify a time zone, the UTC time zone is used by default. You can specify the time zone in the following forms:</para>
        /// <list type="bullet">
        /// <item><description>The time zone name. Examples: <c>Asia/Shanghai</c> and <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>The time offset from GMT. Examples: <c>GMT+8:00</c> (UTC+8) and <c>GMT-7:00</c> (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value.</description></item>
        /// <item><description>The time zone abbreviation. Only UTC is supported.</description></item>
        /// </list>
        /// <para>For example, to configure a command to run only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To configure a command to run only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>To run a command at specific times, use a cron expression to define the schedule. Specify a schedule in the <c>&lt;Cron expression&gt; &lt;Time zone&gt;</c> format. The cron expression is in the <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of the month&gt; &lt;month&gt; &lt;day of the week&gt; &lt;year (optional)&gt;</c> format. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zone of the instance on which you want to run the command is used by default. For more information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. You can specify the time zone in the following forms:</para>
        /// <list type="bullet">
        /// <item><description>The time zone name. Examples: <c>Asia/Shanghai</c> and <c>America/Los_Angeles</c>.</description></item>
        /// <item><description>The time offset from GMT. Examples: <c>GMT+8:00</c> (UTC+8) and <c>GMT-7:00</c> (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value.</description></item>
        /// <item><description>The time zone abbreviation. Only UTC is supported. For example, to configure a command to run at 10:15:00 every day in 2022 (Shanghai time), set the schedule to <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To configure a command to run every half an hour from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the schedule to <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To configure a command to run every 5 minutes from 14:00:00 to 14:55:00 every October every two years from 2022 in UTC, set the schedule to <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Note</b> The minimum interval must be 10 seconds or more and cannot be shorter than the timeout period of scheduled executions.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The IDs of instances on which to create and run the command. Specify at least one instance ID. You can specify up to 100 instance IDs.</para>
        /// <para>If one of the specified instances does not meet the conditions for running the command, the call fails. To ensure that the call is successful, specify only the IDs of instances that meet the conditions.</para>
        /// <para>You can request a quota increase in the Quota Center console. The quota name is Maximum number of instances supported for command execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6neg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the command after the command is run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: retains the command. Then, you can call the InvokeCommand operation to rerun the command. The retained command counts against the quota of Cloud Assistant commands.</description></item>
        /// <item><description>false: does not retain the command. The command is automatically deleted after it is run and does not count against the quota of Cloud Assistant commands.</description></item>
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
        /// <para>The launcher for script execution. The value cannot exceed 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The name of the command. The name supports all character sets and can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The key-value pairs of custom parameters to pass in when the command can include custom parameters. For example, the command content is <c>echo {{name}}</c>. You can use <c>Parameters</c> to pass in the <c>{&quot;name&quot;:&quot;Jack&quot;}</c> key-value pair. The <c>name</c> key of the custom parameter is automatically replaced by the paired Jack value to generate a new command. As a result, the <c>echo Jack</c> command is run.</para>
        /// <para>You can specify 0 to 10 custom parameters. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The key of a custom parameter can be up to 64 characters in length and cannot be an empty string.</description></item>
        /// <item><description>The value of a custom parameter can be an empty string.</description></item>
        /// <item><description>If you want to retain a command, make sure that the command after Base64 encoding, including custom parameters and original command content, does not exceed 18 KB in size. If you do not want to retain the command, make sure that the command after Base64 encoding does not exceed 24 KB in size. You can set <c>KeepCommand</c> to specify whether to retain the command.</description></item>
        /// <item><description>The custom parameter names that are specified by Parameters must be included in the custom parameter names that you specified when you created the command. You can use empty strings to represent the parameters that are not passed in.</description></item>
        /// </list>
        /// <para>This parameter is left empty by default, which indicates that the custom parameter feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the command. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies how to run the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: immediately runs the command.</description></item>
        /// <item><description>Period: runs the command based on a schedule. If you set this parameter to <c>Period</c>, you must specify <c>Frequency</c>.</description></item>
        /// <item><description>NextRebootOnly: runs the command the next time the instances start.</description></item>
        /// <item><description>EveryReboot: runs the command every time the instances start.</description></item>
        /// <item><description>DryRun: performs only a dry run, without running the actual command. The system checks the request parameters, the execution environments on the instances, and the status of Cloud Assistant Agent.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify <c>Frequency</c>, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify <c>Frequency</c>, RepeatMode is set to <c>Period</c> regardless of whether a value is already specified for RepeatMode.</description></item>
        /// </list>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> operation to stop the pending or scheduled executions of the command.</description></item>
        /// <item><description>If you set this parameter to <c>Period</c> or <c>EveryReboot</c>, you can call the <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation with <c>IncludeHistory</c> set to true to query the historical scheduled executions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the command executions. When you set this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instances specified by InstanceId.N must belong to the specified resource group.</description></item>
        /// <item><description>After the command is run, you can set this parameter to call the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> or <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation to query the execution results in the specified resource group.</description></item>
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
        /// <para>The tags of the instance. You can leave this parameter empty or specify up to 20 tags. If you do not specify InstanceId, the command is run on instances that have the specified tags.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestResourceTag> ResourceTag { get; set; }
        public class RunCommandShrinkRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the instance.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter and InstanceId.N are mutually exclusive.</description></item>
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// <item><description>The number of instances that have the specified tags cannot exceed 100. Otherwise, we recommend that you use batch tags, such as batch: b1, to group the instances into batches of up to 100 instances.</description></item>
            /// <item><description>The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the instance.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
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
        /// <para>The tags to add to the command task. You can leave this parameter empty or specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestTag> Tag { get; set; }
        public class RunCommandShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the command task. The tag key cannot be an empty string.</para>
            /// <para>If a tag is specified to query resources, up to 1,000 resources that have this tag can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all the tags can be displayed in the response. To query more than 1,000 resources that have the specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the command task. The tag value can be an empty string.</para>
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
        /// <para>Specifies how to stop the command task when a command execution is manually stopped or times out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Process: stops the process of the command.</description></item>
        /// <item><description>ProcessTree: stops the process tree of the command. In this case, the process of the command and all subprocesses of the process are stopped.</description></item>
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
        /// <para> This parameter is no longer used and does not take effect.</para>
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
        /// <para>A timeout error occurs if the command cannot be run because the process slows down or because a specific module or Cloud Assistant Agent does not exist. When an execution times out, the command process is forcefully terminated.</para>
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
        /// <item><description>RunBatScript: batch command, applicable to Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command, applicable to Windows instances.</description></item>
        /// <item><description>RunShellScript: shell command, applicable to Linux instances.</description></item>
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
        /// <para>The username to use to run the command on the ECS instances. The username cannot exceed 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the root username is used by default.</description></item>
        /// <item><description>For Windows instances, the System username is used by default.</description></item>
        /// </list>
        /// <para>You can also specify other usernames that already exist in the instances to run the command. For security purposes, we recommend that you run Cloud Assistant commands as a regular user. For more information, see <a href="https://help.aliyun.com/document_detail/203771.html">Run Cloud Assistant commands as a regular user</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the password to use to run the command on a Windows instance. The name cannot exceed 255 characters in length.</para>
        /// <para>If you do not want to use the default System user to run the command on Windows instances, specify both WindowsPasswordName and <c>Username</c>. To mitigate the risk of password leaks, the password is stored in plaintext in CloudOps Orchestration Service (OOS) Parameter Store, and only the name of the password is passed in by using WindowsPasswordName. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Manage encryption parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Run Cloud Assistant commands as a regular user</a>.</para>
        /// <remarks>
        /// <para> If you use the root username for Linux instances or the System username for Windows instances to run the command, you do not need to specify WindowsPasswordName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The working directory of the command on the instance. The value can be up to 200 characters in length.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, the default value is <c>/root</c>, which is the home directory of the administrator (the root user).</description></item>
        /// <item><description>For Windows instances, the default value is the directory where the Cloud Assistant Agent process resides, such as <c>C:\\Windows\\System32</c>.</description></item>
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
