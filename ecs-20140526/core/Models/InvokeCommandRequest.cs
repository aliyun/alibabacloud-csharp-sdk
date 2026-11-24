// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command ID. You can call the <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> operation to query all available command IDs. </para>
        /// <remarks>
        /// <para>For public commands, you can run them by command name. For more information, see <a href="https://help.aliyun.com/document_detail/429635.html">View and run Cloud Assistant public commands</a>.</para>
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
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container on the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can only be run on Linux instances where the Cloud Assistant Agent version is 2.2.3.344 or later.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// <item><description>For more information about how to upgrade the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable the upgrade of the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command can only be run by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify an interpreter for the script content by using a command such as <c>#!/usr/bin/python</c> at the beginning of the script. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <item><description><para>If you specify this parameter, Cloud Assistant runs the script in the specified container on the instance.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the command can only be run on Linux instances where the Cloud Assistant Agent version is 2.2.3.344 or later.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// <item><description>For more information about how to upgrade the Cloud Assistant Agent version, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable the upgrade of the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the <c>Username</c> parameter specified in this operation and the <c>WorkingDir</c> parameter specified in <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> do not take effect. The command can only be run by the default user of the container in the default working directory of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify an interpreter for the script content by using a command such as <c>#!/usr/bin/python</c> at the beginning of the script. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
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
        /// <para>The execution time of the scheduled command. Three scheduled execution modes are supported: execution at fixed intervals (based on rate expressions), one-time execution at a specified time, and clock-based scheduled execution (based on cron expressions).</para>
        /// <list type="bullet">
        /// <item><description><para>Execution at fixed intervals: runs the command at a specified interval based on a rate expression. The interval can be set in seconds (s), minutes (m), hours (h), or days (d). This mode is suitable for scenarios where tasks are run at fixed intervals. The format is <c>rate(&lt;interval value&gt;&lt;interval unit&gt;)</c>. For example, to run the command every 5 minutes, use <c>rate(5m)</c>. The following limits apply to execution at fixed intervals:</para>
        /// <list type="bullet">
        /// <item><description>The specified interval must not exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task.</description></item>
        /// <item><description>The execution interval is based only on the fixed frequency and is independent of the actual time required to run the task. For example, if you set the command to run every 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task is completed.</description></item>
        /// <item><description>The task is not run immediately upon creation. For example, if you set the command to run every 5 minutes, the command is not run immediately upon task creation, but starts 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: runs the command once at the specified time zone and time point. The format is <c>at(yyyy-MM-dd HH:mm:ss &lt;time zone&gt;)</c>. If you do not specify a time zone, the UTC time zone is used by default. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: for example, <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: for example, <c>GMT+8:00</c> (East 8th zone) and <c>GMT-7:00</c> (West 7th zone). When you use the GMT format, leading zeros are not supported for the hour.</description></item>
        /// <item><description>Time zone abbreviation: only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to run the command once at 13:15:30 on June 6, 2022 in the China/Shanghai time zone, use <c>at(2022-06-06 13:15:30 Asia/Shanghai)</c>. To run the command once at 13:15:30 on June 6, 2022 in the West 7th zone, use <c>at(2022-06-06 13:15:30 GMT-7:00)</c>.</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on cron expressions): runs the command based on a cron expression. The format is <c>&lt;seconds&gt; &lt;minutes&gt; &lt;hours&gt; &lt;day of month&gt; &lt;month&gt; &lt;day of week&gt; &lt;year (optional)&gt; &lt;time zone&gt;</c>, which is <c>&lt;cron expression&gt; &lt;time zone&gt;</c>. The scheduled task execution time is calculated and executed based on the cron expression in the specified time zone. If you do not specify a time zone, the internal system time zone of the instance that runs the scheduled task is used by default. For more information about cron expressions, see <a href="https://help.aliyun.com/document_detail/64769.html">Cron expressions</a>. The time zone supports the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Time zone full name: for example, <c>Asia/Shanghai</c> (China/Shanghai time) and <c>America/Los_Angeles</c> (US/Los Angeles time).</description></item>
        /// <item><description>Time zone offset from Greenwich Mean Time: for example, <c>GMT+8:00</c> (East 8th zone) and <c>GMT-7:00</c> (West 7th zone). When you use the GMT format, leading zeros are not supported for the hour.</description></item>
        /// <item><description>Time zone abbreviation: only UTC (Coordinated Universal Time) is supported.
        /// For example, to run the command once at 10:15 every day in 2022 in the China/Shanghai time zone, use <c>0 15 10 ? * * 2022 Asia/Shanghai</c>. To run the command every half hour from 10:00 to 11:30 every day in 2022 in the East 8th zone, use <c>0 0/30 10-11 * * ? 2022 GMT+8:00</c>. To run the command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in the UTC time zone, use <c>0 0/5 14 * 10 ? 2022/2 UTC</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum specified time interval must be greater than or equal to the timeout period of the scheduled task and not less than 10 seconds.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The list of instance IDs on which the command is run. You can specify up to 100 instance IDs. Valid values of N: 1 to 100.</para>
        /// <para>You can also apply for a quota increase in Quota Center. The quota name is the maximum number of instances supported for command execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp185dy2o3o6n****&quot;]</para>
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
        /// <para>The OSS data shipping configuration for the command execution output.</para>
        /// <list type="bullet">
        /// <item><description>Format: <c>oss://${BucketName}/${Prefix}</c>. <c>${BucketName}</c> is the name of the OSS bucket to which the data is shipped, and <c>${Prefix}</c> is the directory prefix to which the data is shipped.</description></item>
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
        /// <para>The key-value pairs of custom parameters passed when the command is run if the custom parameter feature is enabled. The number of custom parameters ranges from 0 to 10.</para>
        /// <list type="bullet">
        /// <item><description>The key in the map cannot be an empty string and can be up to 64 characters in length.</description></item>
        /// <item><description>The value in the map can be an empty string.</description></item>
        /// <item><description>The total length of the custom parameters and the original command content cannot exceed 24 KB after Base64 encoding.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed, you can use an empty string instead.</description></item>
        /// </list>
        /// <para>You can leave this parameter unspecified to disable custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI************&quot;}</para>
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
        /// <item><description>DryRun: only prechecks the request. The command is not actually run. The check items include the request parameters, instance execution environment, and Cloud Assistant Agent running status.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <c>Frequency</c> parameter, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify the <c>Frequency</c> parameter, the value is processed as <c>Period</c> regardless of whether this parameter is set.</description></item>
        /// </list>
        /// <para>Precautions:</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/64838.html">StopInvocation</a> operation to stop a pending or scheduled command.</description></item>
        /// <item><description>If you set this parameter to <c>Period</c> or <c>EveryReboot</c>, you can call the <a href="https://help.aliyun.com/document_detail/64845.html">DescribeInvocationResults</a> operation and set <c>IncludeHistory</c> to <c>true</c> to view the historical records of the scheduled command execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group in which the command is run. When you specify this parameter:</para>
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
        /// <para>The list of tags used to filter instances. You can run the command on instances with the same tag in batches without specifying InstanceId.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<InvokeCommandRequestResourceTag> ResourceTag { get; set; }
        public class InvokeCommandRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The tag key used to filter instances.</para>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter conflicts with the InstanceId parameter and cannot be specified at the same time.</para>
            /// </description></item>
            /// <item><description><para>Valid values of N: 1 to 10. The value cannot be an empty string.</para>
            /// </description></item>
            /// <item><description><para>The number of instances under the tag cannot exceed the limit of InstanceId.N. If the number of instances exceeds the limit, control the number of instances by adding batch tags, such as batch: b1.</para>
            /// </description></item>
            /// <item><description><para>The value can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
            /// <item><description>The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InvokeCommandRequestTag> Tag { get; set; }
        public class InvokeCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key for the command to execute. Valid values of N: 1 to 20. The value cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count under the tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources attached to all the specified tags cannot exceed 1,000. If the resource count exceeds 1,000, you must use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The value can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The value can be an empty string.</para>
            /// <para>The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description>ProcessTree: stops the current process tree, which includes the script process and all its child processes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not take effect even if it is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// <para>The timeout period for running the command. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot be less than 10.</para>
        /// </description></item>
        /// <item><description><para>A timeout occurs when the command cannot be run due to process issues, missing modules, or a missing Cloud Assistant Agent. After a timeout, the command process is forcibly terminated.</para>
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
        /// <para>The name of the user that runs the command on the ECS instance. The name can be up to 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For ECS instances that run Linux, the command is run by the root user by default.</description></item>
        /// <item><description>For ECS instances that run Windows, the command is run by the System user by default.</description></item>
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
        /// <para>The name of the password for the user that executes the command on a Windows instance. The name can be up to 255 characters in length.</para>
        /// <para>If you want to execute the command on a Windows instance as a non-default user (other than System), you must specify both <c>Username</c> and this parameter. To reduce the risk of password leakage, the plaintext password must be hosted in the parameter repository of System Operations Management. Here, you only pass the name of the password. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encrypt parameters</a> and <a href="https://help.aliyun.com/document_detail/203771.html">Settings for regular users to execute Cloud Assistant commands</a>.</para>
        /// <remarks>
        /// <para>You do not need to pass this parameter when you run the command as the root user on a Linux instance or the System user on a Windows instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The directory in which the command is run on the ECS instance. The length cannot exceed 200 characters.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the running directory specified when the command was created is used.</description></item>
        /// <item><description>This value applies only to the current command execution and does not change the running directory of the command itself.</description></item>
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
