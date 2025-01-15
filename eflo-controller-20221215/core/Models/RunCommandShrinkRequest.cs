// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Ensures idempotence of the request. Generate a unique parameter value from your client to ensure that the value is unique across different requests. 
        /// ClientToken supports only ASCII characters and cannot exceed 64 characters. For more information, see How to Ensure Idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Command content. Please note the following:</para>
        /// <list type="bullet">
        /// <item><description>Specify <c>EnableParameter=true</c> to enable custom parameters in the command content.</description></item>
        /// <item><description>Define custom parameters using the {{}} format; spaces and newlines within <c>{{}}</c> will be ignored.</description></item>
        /// <item><description>The number of custom parameters cannot exceed 20.</description></item>
        /// <item><description>Custom parameter names can only contain a-zA-Z0-9-_, and are case-insensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>Command ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-e996287206324975b5fbe1d***</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>Encoding method for the script content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: No encoding, transmitted in plain text.</description></item>
        /// <item><description>Base64: Base64 encoding.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If an invalid value is provided, it will be treated as PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Command description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether the command contains custom parameters.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>Execution time for scheduled commands. Currently, three types of scheduling methods are supported: fixed interval (based on Rate expression), one-time execution at a specific time, and clock-based scheduling (based on Cron expression).</para>
        /// <para>Fixed interval execution: Based on the Rate expression, the command is executed at the set interval. The interval can be set in seconds (s), minutes (m), hours (h), and days (d), suitable for scenarios where tasks need to be executed at fixed intervals. The format is rate(<interval value><interval unit>), such as rate(5m) for every 5 minutes. The following restrictions apply to fixed interval execution:</para>
        /// <list type="bullet">
        /// <item><description>The interval should not exceed 7 days and should be no less than 60 seconds, and it must be greater than the timeout of the scheduled task.</description></item>
        /// <item><description>The interval is based on a fixed frequency and is independent of the actual execution time of the task. For example, if the command is set to execute every 5 minutes and the task takes 2 minutes to complete, the next round will start 3 minutes after the completion of the task.</description></item>
        /// <item><description>The task will not be executed immediately upon creation. For example, if the command is set to execute every 5 minutes, it will not be executed immediately upon creation but will start 5 minutes after the task is created.
        /// One-time execution at a specific time: Executes the command once at the specified time and timezone. The format is at(yyyy-MM-dd HH:mm:ss <timezone>), which is at(year-month-day hour:minute:second <timezone>). If no timezone is specified, UTC is used by default. Timezones support the following three formats:</description></item>
        /// <item><description>Full timezone name: e.g., Asia/Shanghai (China/Shanghai time), America/Los_Angeles (America/Los Angeles time), etc.</description></item>
        /// <item><description>Timezone offset from GMT: e.g., GMT+8:00 (UTC+8:00), GMT-7:00 (UTC-7:00). When using the GMT format, leading zeros are not allowed in the hour position.</description></item>
        /// <item><description>Timezone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute once at 13:15:30 on June 6, 2022, in Shanghai, China, the format would be: at(2022-06-06 13:15:30 Asia/Shanghai); to execute once at 13:15:30 on June 6, 2022, in the GMT-7:00 timezone, the format would be: at(2022-06-06 13:15:30 GMT-7:00).</para>
        /// <para>Clock-based scheduling (based on Cron expression): Based on the Cron expression, the command is executed according to the set schedule. The format is <second> <minute> <hour> <day> <month> <weekday> &lt;year (optional)&gt; <timezone>, i.e., <Cron expression> <timezone>. In the specified timezone, the scheduled task execution time is calculated based on the Cron expression and then executed. If no timezone is specified, the system\&quot;s internal timezone of the instance running the scheduled task is used by default. For more information about Cron expressions, see Cron Expressions. Timezones support the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Full timezone name: e.g., Asia/Shanghai (China/Shanghai time), America/Los_Angeles (America/Los Angeles time), etc.</description></item>
        /// <item><description>Timezone offset from GMT: e.g., GMT+8:00 (UTC+8:00), GMT-7:00 (UTC-7:00). When using the GMT format, leading zeros are not allowed in the hour position.</description></item>
        /// <item><description>Timezone abbreviation: Only UTC (Coordinated Universal Time) is supported.</description></item>
        /// </list>
        /// <para>For example, to execute the command at 10:15 AM every day in 2022 in Shanghai, China, the format would be 0 15 10 ? * * 2022 Asia/Shanghai; to execute the command every 30 minutes between 10:00 AM and 11:30 AM every day in 2022 in the GMT+8:00 timezone, the format would be 0 0/30 10-11 * * ? 2022 GMT+8:00; to execute the command every 5 minutes between 2:00 PM and 2:55 PM every day in October every two years starting from 2022 in UTC, the format would be 0 0/5 14 * 10 ? 2022/2 UTC.</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>Bootstrap for script execution. The length must not exceed 1 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
        /// </summary>
        [NameInMap("Launcher")]
        [Validation(Required=false)]
        public string Launcher { get; set; }

        /// <summary>
        /// <para>Command name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>List of nodes.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

        /// <summary>
        /// <para>When the command contains custom parameters, you need to pass in key-value pairs of these custom parameters when executing the command. For example, if the command content is <c>echo {{name}}</c>, you can pass in the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c> through the <c>Parameter</c> parameter. The custom parameter will automatically replace the variable value <c>name</c>, resulting in a new command, which actually executes as <c>echo Jack</c>.</para>
        /// <para>The number of custom parameters ranges from 0 to 10, and you should note:</para>
        /// <list type="bullet">
        /// <item><description>Keys cannot be empty strings and support up to 64 characters at most.</description></item>
        /// <item><description>Values can be empty strings.</description></item>
        /// <item><description>When combined with the original command content and Base64 encoded, if the command is saved, the size after Base64 encoding must not exceed 18 KB; if the command is not saved, the size after Base64 encoding must not exceed 24 KB. You can set whether to keep the command via <c>KeepCommand</c>.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined during command creation. For parameters that are not passed in, you can use an empty string as a substitute.</description></item>
        /// </list>
        /// <para>The default value is empty, indicating that the parameter is not set, thus disabling custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAIdyvdIqaRY****&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>Set the command execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: Execute the command immediately.</description></item>
        /// <item><description>Period: Execute the command at a scheduled time. When this parameter is set to <c>Period</c>, you must also specify the <c>Frequency</c> parameter.</description></item>
        /// <item><description>NextRebootOnly: Automatically execute the command when the instance starts next time.</description></item>
        /// <item><description>EveryReboot: Automatically execute the command every time the instance starts.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If the <c>Frequency</c> parameter is not specified, the default value is <c>Once</c>.</description></item>
        /// <item><description>If the <c>Frequency</c> parameter is specified, regardless of whether this parameter is already set, it will be processed as <c>Period</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The mode when stopping a task (manually or due to execution timeout). Possible values:
        /// Process: Stops the current script process. ProcessTree: Stops the current process tree (a collection of the script process and all its child processes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <para>Timeout for executing the command, in seconds. If the command cannot run due to process issues, missing modules, or the absence of the Cloud Assistant Agent, a timeout will occur. After a timeout, the command process will be forcibly terminated. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The username to execute the command in the instance. The length must not exceed 255 characters.
        ///     For Linux systems, the command is executed by the root user by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>You can customize the execution path of the command. The default paths are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Linux instances: The default execution path is under the /home directory of the root user.</description></item>
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
