// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Specify <c>EnableParameter=true</c> to enable the custom parameter feature in the command content.</description></item>
        /// <item><description>Define custom parameters by enclosing them in <c>{{}}</c>. Spaces and line breaks before and after the parameter names within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>You can define up to 20 custom parameters.</description></item>
        /// <item><description>Custom parameter names can contain only letters, digits, hyphens (-), and underscores (_). Parameter names are not case-sensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The command ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-e996287206324975b5fbe1d***</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding format of the script content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The content is not encoded and is transmitted in plaintext.</description></item>
        /// <item><description>Base64: The content is Base64-encoded.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If you specify an invalid value, the value is processed as PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The command description.</para>
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
        /// <para>The scheduled execution time of the command. Three scheduled execution modes are supported: execution at fixed intervals (based on rate expressions), one-time execution at a specified time, and clock-based scheduled execution (based on cron expressions).</para>
        /// <list type="bullet">
        /// <item><description><para>Execution at fixed intervals: Executes the command at the specified interval based on a rate expression. The interval can be specified in seconds (s), minutes (m), hours (h), or days (d). This mode is suitable for scenarios where tasks are executed at fixed intervals. The format is rate(<interval value><interval unit>). For example, to execute the command every 5 minutes, use rate(5m). Limits on execution at fixed intervals: </para>
        /// <list type="bullet">
        /// <item><description>The interval cannot exceed 7 days or be less than 60 seconds, and must be greater than the timeout period of the scheduled task. </description></item>
        /// <item><description>The execution interval is based only on the fixed frequency and is independent of the actual time required to execute the task. For example, if you set the interval to 5 minutes and the task takes 2 minutes to complete, the next execution starts 3 minutes after the task is completed. </description></item>
        /// <item><description>The task is not executed immediately upon creation. For example, if you set the interval to 5 minutes, the command is not executed immediately when the task is created. Instead, the first execution starts 5 minutes after the task is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>One-time execution at a specified time: Executes the command once at the specified time zone and time point. The format is at(yyyy-MM-dd HH:mm:ss <time zone>). If you do not specify a time zone, the UTC time zone is used by default. The time zone can be in one of the following formats: Full name of the time zone, such as Asia/Shanghai and America/Los_Angeles. Offset from Greenwich Mean Time (GMT), such as GMT+8:00 and GMT-7:00. When you use the GMT format, leading zeros are not supported for the hour. Time zone abbreviation: Only UTC is supported.
        /// For example, to execute the command once at 13:15:30 on June 6, 2022 in the Asia/Shanghai time zone, use at(2022-06-06 13:15:30 Asia/Shanghai). To execute the command once at 13:15:30 on June 6, 2022 in the GMT-7:00 time zone, use at(2022-06-06 13:15:30 GMT-7:00).</para>
        /// </description></item>
        /// <item><description><para>Clock-based scheduled execution (based on cron expressions): Executes the command based on a cron expression. The format is <seconds> <minutes> <hours> <day of month> <month> <day of week> &lt;year (optional)&gt; <time zone>, which is <cron expression> <time zone>. The execution time is calculated based on the cron expression in the specified time zone. If you do not specify a time zone, the system time zone of the instance is used by default. For more information about cron expressions, see Cron expressions. The time zone can be in one of the following formats: </para>
        /// <list type="bullet">
        /// <item><description>Full name of the time zone, such as Asia/Shanghai and America/Los_Angeles. </description></item>
        /// <item><description>Offset from GMT, such as GMT+8:00 and GMT-7:00. When you use the GMT format, leading zeros are not supported for the hour. </description></item>
        /// <item><description>Time zone abbreviation: Only UTC is supported.</description></item>
        /// </list>
        /// <para>  For example, to execute the command once at 10:15 every day in 2022 in the Asia/Shanghai time zone, use 0 15 10 ? * * 2022 Asia/Shanghai. To execute the command every 30 minutes from 10:00 to 11:30 every day in 2022 in the GMT+8:00 time zone, use 0 0/30 10-11 * * ? 2022 GMT+8:00. To execute the command every 5 minutes from 14:00 to 14:55 every day in October every two years starting from 2022 in the UTC time zone, use 0 0/5 14 * 10 ? 2022/2 UTC.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The launcher for script execution. The size cannot exceed 1 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>The command name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of nodes. The node IDs must belong to created Lingjun nodes. You can call the ListClusterNodes or ListFreeNodes operation to query the node IDs.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the custom parameters that are passed when the command is executed, if the command contains custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can pass the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c> by using the <c>Parameter</c> parameter. The custom parameter automatically replaces the variable <c>name</c>, generating a new command <c>echo Jack</c> to be executed.</para>
        /// <para>The number of custom parameters ranges from 0 to 10. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The key cannot be an empty string and can contain up to 64 characters.</description></item>
        /// <item><description>The value can be an empty string.</description></item>
        /// <item><description>After the custom parameters and the original command content are Base64-encoded, if the command is saved, the size of the Base64-encoded command content cannot exceed 18 KB. If the command is not saved, the size cannot exceed 24 KB. You can use <c>KeepCommand</c> to specify whether to retain the command.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed, you can use empty strings.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that this parameter is not specified and the custom parameter feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI***********&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The execution mode of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: Executes the command immediately.</description></item>
        /// <item><description>Period: Executes the command on a schedule. If you set this parameter to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: Automatically executes the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: Automatically executes the command every time the instance starts.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <c>Frequency</c> parameter, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify the <c>Frequency</c> parameter, the value is processed as <c>Period</c> regardless of whether this parameter is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The mode used when the task is stopped manually or interrupted due to execution timeout. Valid values:</para>
        /// <para>Process: Stops the current script process.
        /// ProcessTree: Stops the current process tree, which includes the script process and all its child processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <para>The timeout period for executing the command, in seconds. A timeout occurs when the command cannot be executed due to process issues, missing modules, or a missing Cloud Assistant Agent. After a timeout, the command process is forcibly terminated. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The name of the user that is used to execute the command on the instance. The name cannot exceed 255 characters in length.
        /// For Linux instances, the command is executed by the root user by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The custom execution path of the command. Default paths:</para>
        /// <para>Linux instances: The default execution path is the /home directory of the root user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/user</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
