// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. You must make sure that the token is unique among different requests. The <c>ClientToken</c> parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content, which can be in plaintext or Base64-encoded. Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the Base64-encoded command content is limited to 18 KB if <c>KeepCommand</c> is <c>true</c>, or 24 KB if <c>KeepCommand</c> is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para>If the command content is Base64-encoded, you must set <c>ContentEncoding</c> to <c>Base64</c>.</para>
        /// </description></item>
        /// <item><description><para>Set <c>EnableParameter</c> to <c>true</c> to enable the custom parameter feature in the command content.</para>
        /// <list type="bullet">
        /// <item><description><para>Define custom parameters by using the <c>{{}}</c> format. Spaces and line breaks before and after the parameter names within <c>{{}}</c> are ignored.</para>
        /// </description></item>
        /// <item><description><para>You can define up to 20 custom parameters.</para>
        /// </description></item>
        /// <item><description><para>A custom parameter name can contain only letters, digits, underscores (_), and hyphens (-). The name is case-insensitive and cannot start with <c>acs::</c>, which is reserved for built-in environment parameters.</para>
        /// </description></item>
        /// <item><description><para>A custom parameter name can be up to 64 bytes long.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can use built-in environment parameters, which Cloud Assistant automatically replaces with their corresponding values at runtime. The following built-in environment parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{{ACS::RegionId}}</c>: the region ID.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceId}}</c>: the instance ID. To use this parameter on multiple instances, the required Cloud Assistant Agent version is 2.2.3.309 or later for Linux instances, or 2.1.3.309 or later for Windows instances.</para>
        /// <list type="bullet">
        /// <item><description><para>Linux: 2.2.3.309</para>
        /// </description></item>
        /// <item><description><para>Windows: 2.1.3.309</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceName}}</c>: the instance name. To use this parameter on multiple instances, the required Cloud Assistant Agent version is 2.2.3.344 or later for Linux instances, or 2.1.3.344 or later for Windows instances.</para>
        /// <list type="bullet">
        /// <item><description><para>Linux: 2.2.3.344</para>
        /// </description></item>
        /// <item><description><para>Windows: 2.1.3.344</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InvokeId}}</c>: the invocation ID. To use this parameter, the required Cloud Assistant Agent version is 2.2.3.309 or later for Linux instances, or 2.1.3.309 or later for Windows instances.</para>
        /// <list type="bullet">
        /// <item><description><para>Linux: 2.2.3.309</para>
        /// </description></item>
        /// <item><description><para>Windows: 2.1.3.309</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::CommandId}}</c>: the command ID. To use this parameter, the required Cloud Assistant Agent version is 2.2.3.309 or later for Linux instances, or 2.1.3.309 or later for Windows instances.</para>
        /// <list type="bullet">
        /// <item><description><para>Linux: 2.2.3.309</para>
        /// </description></item>
        /// <item><description><para>Windows: 2.1.3.309</para>
        /// </description></item>
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
        /// <para>The ID of the container. The ID must be a 64-bit hexadecimal string. You can add the <c>docker://</c>, <c>containerd://</c>, or <c>cri-o://</c> prefix to explicitly specify the container runtime.</para>
        /// <para>Notes:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the specified <c>Username</c> and <c>WorkingDir</c> parameters are ignored. The command is run only by the default user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Run commands in a container by using Cloud Assistant</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In Linux containers, you can run only Shell scripts. You cannot use commands such as <c>#!/usr/bin/python</c> at the beginning of a script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Run commands in a container by using Cloud Assistant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// <para>Notes:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only on Linux instances with Cloud Assistant Agent version 2.2.3.344 or later.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the specified <c>Username</c> and <c>WorkingDir</c> parameters are ignored. The command is run only by the default user in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Run commands in a container by using Cloud Assistant</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In Linux containers, you can run only Shell scripts. You cannot use commands such as <c>#!/usr/bin/python</c> at the beginning of a script to specify an interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Run commands in a container by using Cloud Assistant</a>.</para>
        /// </remarks>
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
        /// <item><description><para><c>PlainText</c>: The command content is not encoded and is transmitted in plaintext.</para>
        /// </description></item>
        /// <item><description><para><c>Base64</c>: The command content is Base64-encoded.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PlainText</c>. If you specify an invalid value, the value is automatically set to <c>PlainText</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The description of the command. It can be up to 512 characters long and supports all character sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use custom parameters in the command.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The schedule for the command. You can specify a rate expression, an at expression for one-time execution, or a cron expression.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Fixed-interval execution</b>: Runs the command at fixed intervals defined by a rate expression. You can specify the interval in seconds (s), minutes (m), hours (h), or days (d). This method is suitable for tasks that must be run at fixed intervals. The format is <c>rate(&lt;value&gt;&lt;unit&gt;)</c>. For example, to run a command every 5 minutes, use <c>rate(5m)</c>. The following limits apply to this method:</para>
        /// <list type="bullet">
        /// <item><description><para>The interval must be in the range of 60 seconds to 7 days, and must be longer than the timeout of the scheduled task.</para>
        /// </description></item>
        /// <item><description><para>The interval is fixed and starts from the beginning of the previous execution, not from its completion.</para>
        /// </description></item>
        /// <item><description><para>The task does not immediately run after it is created. For example, if you set an interval of 5 minutes, the first run starts 5 minutes after the task is created.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>One-time execution</b>: Run the command once at a specified time and in a specified time zone. The format is <c>at(yyyy-MM-dd HH:mm:ss &lt;time_zone&gt;)</c>. If you do not specify a time zone, UTC is used by default. The following time zone formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>Full time zone name, such as <c>Asia/Shanghai</c> or <c>America/Los_Angeles</c>.</para>
        /// </description></item>
        /// <item><description><para>Offset from GMT, such as <c>GMT+8:00</c> or <c>GMT-7:00</c>. When you use the GMT format, you cannot add a leading zero to the hour.</para>
        /// </description></item>
        /// <item><description><para>Time zone abbreviation. Only <c>UTC</c> is supported.</para>
        /// </description></item>
        /// </list>
        /// <para>Example 1: To run a task at 13:15:30 on June 6, 2022 in the <c>Asia/Shanghai</c> time zone, use <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. Example 2: To run a task at 13:15:30 on June 6, 2022 in the <c>GMT-7:00</c> time zone, use <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Scheduled execution based on a cron expression</b>: Runs the command on a schedule defined by a cron expression. The format is <c>&lt;second&gt; &lt;minute&gt; &lt;hour&gt; &lt;day_of_month&gt; &lt;month&gt; &lt;day_of_week&gt; &lt;year (optional)&gt; &lt;time_zone&gt;</c>, or <c>&lt;cron_expression&gt; &lt;time_zone&gt;</c>. The task is run based on the cron expression in the specified time zone. If you do not specify a time zone, the system time zone of the instance where the task is run is used by default. For more information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The following time zone formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>Full time zone name, such as <c>Asia/Shanghai</c> or <c>America/Los_Angeles</c>.</para>
        /// </description></item>
        /// <item><description><para>Offset from GMT, such as <c>GMT+8:00</c> or <c>GMT-7:00</c>. When you use the GMT format, you cannot add a leading zero to the hour.</para>
        /// </description></item>
        /// <item><description><para>Time zone abbreviation. Only <c>UTC</c> is supported.
        /// For example, to run a command at 10:15 every day in 2022 in the <c>Asia/Shanghai</c> time zone, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To run a command every 30 minutes from 10:00 to 11:30 every day in 2022 in the <c>GMT+8:00</c> time zone, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To run a command every 5 minutes from 14:00 to 14:55 every day in October of every two years starting from 2022 in <c>UTC</c>, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum interval must be greater than or equal to the timeout of the scheduled task, and cannot be less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances on which to run the command. You can specify from 1 to 100 instance IDs.</para>
        /// <para>If any specified instance does not meet the execution requirements, the entire operation fails.</para>
        /// <para>You can apply for a quota increase in Quota Center. The quota is named Maximum number of instances supported per command execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6neg****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to save the command after it is run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Saves the command. You can then re-run it by calling InvokeCommand. Saved commands count towards your Cloud Assistant command quota.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not save the command. The command is deleted after execution and does not count towards your quota.</para>
        /// </description></item>
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
        /// <para>The launcher that is used to run the script. The value can be up to 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The name of the command. It can be up to 128 characters long and supports all character sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration for the command output.</para>
        /// <list type="bullet">
        /// <item><description>Format: oss\://${BucketName}/${Prefix}, where ${BucketName} is the name of the destination OSS bucket and ${Prefix} is the destination prefix.</description></item>
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
        /// <para>The key-value pairs for custom parameters. For example, if <c>CommandContent</c> is <c>echo {{name}}</c>, setting <c>Parameters</c> to <c>{&quot;name&quot;:&quot;Jack&quot;}</c> results in the command <c>echo Jack</c> being run.</para>
        /// <para>You can specify 0 to 10 key-value pairs. Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>The key cannot be an empty string and can be up to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The value can be an empty string.</para>
        /// </description></item>
        /// <item><description><para>After Base64 encoding, the total size of the custom parameters and the original command content is limited to 18 KB if <c>KeepCommand</c> is <c>true</c>, or 24 KB if <c>KeepCommand</c> is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para>The set of custom parameter names that you specify must be a subset of the parameters defined in <c>CommandContent</c>. The value of an omitted parameter defaults to an empty string.</para>
        /// </description></item>
        /// </list>
        /// <para>By default, this parameter is empty, which indicates that no custom parameters are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI*************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest Alibaba Cloud regions.</para>
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
        /// <item><description><para><c>Once</c>: The command is immediately run.</para>
        /// </description></item>
        /// <item><description><para><c>Period</c>: Runs the command as a scheduled task. This mode requires the <c>Frequency</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>NextRebootOnly</c>: The command is automatically run the next time the instance starts.</para>
        /// </description></item>
        /// <item><description><para><c>EveryReboot</c>: The command is automatically run every time the instance starts.</para>
        /// </description></item>
        /// <item><description><para><c>DryRun</c>: Performs a dry run to check parameters and the environment without actually running the command.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If the <c>Frequency</c> parameter is not specified, the default value is <c>Once</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Frequency</c> is specified, this parameter is automatically set to <c>Period</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Notes:</para>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> operation to stop pending or scheduled commands.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <c>Period</c> or <c>EveryReboot</c>, you can call the <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation and set <c>IncludeHistory=true</c> to query the historical execution records of the scheduled command.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group for the command execution. When you specify this parameter, the following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para>If an ECS instance specified by <c>InstanceId</c> is in a non-default resource group, it must belong to the resource group specified by this parameter.</para>
        /// </description></item>
        /// <item><description><para>You can use this parameter to filter command execution results when you call the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> or <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation.</para>
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
        /// <para>Tags used to filter instances for command execution. This allows you to run the command on all instances with matching tags, as an alternative to specifying instance IDs. The array can contain 0 to 20 tags.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<RunCommandRequestResourceTag> ResourceTag { get; set; }
        public class RunCommandRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key that is used to filter instances.</para>
            /// <para>Notes:</para>
            /// <list type="bullet">
            /// <item><description><para>You cannot specify both this parameter and the InstanceId parameter.</para>
            /// </description></item>
            /// <item><description><para>The tag key cannot be an empty string.</para>
            /// </description></item>
            /// <item><description><para>The number of instances matching the specified tag cannot exceed the per-execution instance limit (100 by default). If the number of matching instances exceeds this limit, you can use additional tags, such as <c>batch:b1</c>, to refine the selection.</para>
            /// </description></item>
            /// <item><description><para>The value can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It also cannot contain <c>http://</c> or <c>https://</c>.</para>
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
            /// <para>The tag value that is used to filter instances.</para>
            /// <para>Notes:</para>
            /// <list type="bullet">
            /// <item><description><para>The value can be an empty string.</para>
            /// </description></item>
            /// <item><description><para>The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
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
        /// <para>An array of tag pairs. The array can contain 0 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandRequestTag> Tag { get; set; }
        public class RunCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key for the command execution. The key cannot be an empty string.</para>
            /// <para>The key can be up to 64 characters long and cannot start with <c>aliyun</c> or <c>acs:</c>. It also cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>The value can be up to 64 characters long and cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value for the command execution. The value can be an empty string.</para>
            /// <para>The value can be up to 128 characters long and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The mode for stopping the task when it is manually stopped or times out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Process</c>: Stops the current script process.</para>
        /// </description></item>
        /// <item><description><para><c>ProcessTree</c>: Stops the current process tree. A process tree includes the current script process and all of its subprocesses.</para>
        /// </description></item>
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
        /// <para>This parameter is deprecated and no longer has any effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// <para>The command execution timeout, in seconds.</para>
        /// <para>A timeout forcibly terminates the command process if the command fails to run due to exceptions, such as a process conflict, a missing module, or a disabled Cloud Assistant Agent.</para>
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
        /// <item><description><para><c>RunBatScript</c>: Bat commands for Windows instances.</para>
        /// </description></item>
        /// <item><description><para><c>RunPowerShellScript</c>: PowerShell commands for Windows instances.</para>
        /// </description></item>
        /// <item><description><para><c>RunShellScript</c>: Shell commands for Linux instances.</para>
        /// </description></item>
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
        /// <para>The name of the user that runs the command on the ECS instance. The name can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description><para>Default on Linux: <c>root</c>.</para>
        /// </description></item>
        /// <item><description><para>Default on Windows: <c>System</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>You can specify another existing user on the instance to run the command. Running Cloud Assistant commands as a standard user is more secure. For more information, see <a href="https://help.aliyun.com/document_detail/203771.html">Run Cloud Assistant commands as a standard user</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the password of the user that runs the command on a Windows instance. The name can be up to 255 characters in length.</para>
        /// <para>To run a command as a non-default user on a Windows instance, you must specify both <c>Username</c> and <c>WindowsPasswordName</c>. To reduce the risk of password leaks, we recommend storing the password in OOS Parameter Store and providing the parameter name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encryption parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Run Cloud Assistant commands as a standard user</a>.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter when you run a command as the <c>root</c> user on a Linux instance or as the <c>System</c> user on a Windows instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The working directory for the command on the instance. The path can be up to 200 characters long.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description><para>For Linux instances, the default is the home directory of the <c>root</c> user (<c>/root</c>).</para>
        /// </description></item>
        /// <item><description><para>For Windows instances, the default is the directory of the Cloud Assistant Agent process, such as <c>C:\\Windows\\System32</c>.</para>
        /// </description></item>
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
