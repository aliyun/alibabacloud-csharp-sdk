// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token to ensure the idempotency of the request. Use your client to generate the token that is unique among requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see &quot;How to ensure idempotence&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command content. Take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>When <c>EnableParameter</c> is set to true, you can use custom parameters in the command.</description></item>
        /// <item><description>Define custom parameters in the {{}} format. Within <c>{{}}</c>, the spaces and line feeds before and after the parameter names are ignored.</description></item>
        /// <item><description>You can specify up to 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain only letters, digits, underscores (_), and hyphens (-). The name is not case-sensitive.</description></item>
        /// <item><description>Each custom parameter name is up to 64 bytes in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The ID of the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-e996287206324975b5fbe1d***</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding mode of the command content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText</description></item>
        /// <item><description>Base64</description></item>
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
        /// <para>The command description.</para>
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
        /// <para>The schedule to run the command. Supported schedule types: at a fixed interval based on a rate expression, run only once at a specific time, or run at specific times based on a cron expression.</para>
        /// <list type="bullet">
        /// <item><description><para>To run the command at a fixed interval, use a rate expression to specify the interval. The interval can be in seconds, minutes, hours, or days. This option is suitable for scenarios in which tasks need to be executed at a fixed interval. Format: rate(\<Execution interval value> \<Execution interval unit>). For example, rate(5m) means to run the command every 5 minutes. When you specify an interval, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The interval can be anywhere from 60 seconds to 7 days, but must be longer than the timeout period of the scheduled task.</description></item>
        /// <item><description>The interval is the time between two consecutive executions, irrelevant of the time required to run the command. For example, assume that you set the interval to 5 minutes and that it takes 2 minutes to run the command each time. The system waits 3 minutes before running the command again.</description></item>
        /// <item><description>The command is not immediately executed after the task is created. For example, assume that you set the interval to 5 minutes. The task begins to be executed 5 minutes after it is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To run a command only once at a specific point in time, specify a point in time and a time zone. Format: at(yyyy-MM-dd HH:mm:ss \<Time zone>). If you do not specify a time zone, the Coordinated Universal Time (UTC) time zone is used by default. The time zone name supports the following formats: Full name, such as Asia/Shanghai and America/Los_Angeles. The time offset from GMT. Examples: GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value. The time zone abbreviation. Only UTC is supported. For example, to configure a command to run only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to at(2022-06-06 13:15:30 Asia/Shanghai). To configure a command to run only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to at(2022-06-06 13:15:30 GMT-7:00).</para>
        /// </description></item>
        /// <item><description><para>To run a command at designated points in time, use a cron expression to define the schedule. Format: \<Cron expression> \<Time zone>. Example: \<Seconds> \<Minutes> \<Hours> \<Day of the month> \<Month> \<Day of the week> \&lt;Year (optional)&gt; \<Time zone>. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zone of the instance is used by default. For more information, see Cron expressions. The time zone name supports the following formats:</para>
        /// <list type="bullet">
        /// <item><description>Full name, such as Asia/Shanghai and America/Los_Angeles.</description></item>
        /// <item><description>The time offset from GMT. Examples: GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). If you use the GMT format, you cannot add leading zeros to the hour value.</description></item>
        /// <item><description>The time zone abbreviation. Only UTC is supported.</description></item>
        /// </list>
        /// <para>For example, if you specify a command to run at 10:15:00 every day in 2022 in China/Shanghai time, set the time to 0 15 10 ? \* \* 2022 Asia/Shanghai. To configure a command to run every half an hour from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the schedule to 0 0/30 10-11 \* \* ? 2022 GMT+8:00. To configure a command to run every 5 minutes from 14:00:00 to 14:55:00 every October every two years from 2022 in UTC, set the schedule to 0 0/5 14 \* 10 ? 2022/2 UTC.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The launcher for script execution. Cannot exceed 1 KB.</para>
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
        /// <para>The node list.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

        /// <summary>
        /// <para>The key-value pairs of custom parameters to pass in when the command includes custom parameters. For example, the command content is <c>echo {{name}}</c>. You can use <c>Parameters</c> to pass in the <c>{&quot;name&quot;:&quot;Jack&quot;}</c> key-value pair. The <c>name</c> key of the custom parameter is automatically replaced by the paired Jack value to generate a new command. As a result, the <c>echo Jack</c> command is run.</para>
        /// <para>You can specify 0 to 10 custom parameters. Take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>The key of a custom parameter can be up to 64 characters in length, and cannot be an empty string.</description></item>
        /// <item><description>The value of a custom parameter can be an empty string.</description></item>
        /// <item><description>If you want to retain a command, make sure that the command after Base64 encoding, including custom parameters and original command content, does not exceed 18 KB in size. If you do not want to retain the command, make sure that the command after Base64 encoding does not exceed 24 KB in size. You can set <c>KeepCommand</c> to specify whether to retain the command.</description></item>
        /// <item><description>The specified custom parameter names must be included in the custom parameter names that you specify when you create the command. You can use empty strings to represent the parameters that are not passed in.</description></item>
        /// </list>
        /// <para>This parameter is left empty by default, which indicates that the custom parameter feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAIdyvdIqaRY****&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The mode to run the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: runs the command immediately.</description></item>
        /// <item><description>Period: runs the command based on a schedule. When set to <c>Period</c>, <c>Frequency</c> is required.</description></item>
        /// <item><description>NextRebootOnly: runs the command the next time the instances is started.</description></item>
        /// <item><description>EveryReboot: runs the command every time the instance is started.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify <c>Frequency</c>, the default value is <c>Once</c>.</description></item>
        /// <item><description>If you specify <c>Frequency</c>, RepeatMode is set to <c>Period</c> regardless of whether a value is already specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>Indicates how the command task is stopped when a command execution is manually stopped or times out. Valid values:</para>
        /// <para>Process: The process of the command is stopped. ProcessTree: The process tree of the command is stopped. In this case, the process of the command and all subprocesses are stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessTree</para>
        /// </summary>
        [NameInMap("TerminationMode")]
        [Validation(Required=false)]
        public string TerminationMode { get; set; }

        /// <summary>
        /// <para>The timeout period for the command. Unit: seconds. A timeout error occurs if the command cannot be run because the process slows down or because a specific module or Cloud Assistant Agent does not exist. When the specified timeout period ends, the command process is forcefully terminated. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The username that you use to run the command. The name can be up to 255 characters in length. For Linux instances, the root user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The working path of the command. You can specify a custom path. Default path:</para>
        /// <para>Linux instances: By default, the path is in the /home directory of the root user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/user</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
