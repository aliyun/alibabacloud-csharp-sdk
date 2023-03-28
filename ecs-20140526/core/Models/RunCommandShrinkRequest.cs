// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// The content of the command. The command content can be plaintext or Base64-encoded. Take note of the following items:
        /// 
        /// *   If you want to retain the command, make sure that the Base64-encoded command content does not exceed 18 KB in size. If you do not want to retain the command, make sure that the Base64-encoded command content does not exceed 24 KB in size. You can use the `KeepCommand` parameter to specify whether to retain the command.
        /// 
        /// *   If the command content is Base64-encoded, set the `ContentEncoding` parameter to Base64.
        /// 
        /// *   If you set the `EnableParameter` parameter to true, the custom parameter feature is enabled and you can specify custom parameters based on the following rules:
        /// 
        ///     *   Specify custom parameters in the `{{}}` format. Within `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        ///     *   You can specify up to 20 custom parameters.
        ///     *   A custom parameter name can contain only letters, digits, underscores (\_), and hyphens (-). The name is not case-sensitive.
        ///     *   Each custom parameter name cannot exceed 64 bytes in length.
        /// 
        /// *   You can specify built-in environment parameters as custom parameters. Then, Cloud Assistant automatically specifies the parameters when you run the command. You can specify the following built-in environment parameters:
        /// 
        ///     *   `{{ACS::RegionId}}`: the ID of the region.
        /// 
        ///     *   `{{ACS::AccountId}}`: the UID of the Alibaba Cloud account.
        /// 
        ///     *   `{{ACS::InstanceId}}`: the ID of the instance. If you want to run the command on multiple instances and specify `{{ACS::InstanceId}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following versions:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::InstanceName}}`: the name of the instance. If you want to run the command on multiple instances and specify `{{ACS::InstanceName}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following versions:
        /// 
        ///         *   Linux: 2.2.3.344
        ///         *   Windows: 2.1.3.344
        /// 
        ///     *   `{{ACS::InvokeId}}`: the ID of the command task. If you want to specify `{{ACS::InvokeId}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following versions:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::CommandId}}`: the ID of the command. If you want to specify `{{ACS::CommandId}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following versions:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// The ID of the container. Only 64-bit hexadecimal strings are supported. Container IDs that are prefixed with `docker://`, `containerd://`, or `cri-o://` can specify container runtimes.
        /// 
        /// Take note of the following items:
        /// 
        /// *   If you specify this parameter, Cloud Assistant runs scripts in the specified container of the instance.
        /// *   If you specify this parameter, scripts can be run only on Linux instances on which the Cloud Assistant client of version 2.2.3.344 or later is installed.
        /// *   If you specify this parameter, the specified `Username` and `WorkingDir` parameters do not take effect. You can run the command in the default working directory of the container by using only the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify a script interpreter by adding a command in a format that is similar to `#!/usr/bin/python` at the beginning of a script. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The name of the container.
        /// 
        /// Take note of the following items:
        /// 
        /// *   If you specify this parameter, Cloud Assistant runs scripts in the specified container of the instance.
        /// *   If you specify this parameter, scripts can be run only on Linux instances on which the Cloud Assistant client of version 2.2.3.344 or later is installed.
        /// *   If you specify this parameter, the specified `Username` and `WorkingDir` parameters do not take effect. You can run the command in the default working directory of the container by using only the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify a script interpreter by adding a command in a format that is similar to `#!/usr/bin/python` at the beginning of a script. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The encoding mode of the command content that is specified by the `CommandContent` parameter. The valid values are not case-sensitive. Valid values:
        /// 
        /// *   PlainText: The command content is not encoded.
        /// *   Base64: The command content is encoded in Base64.
        /// 
        /// Default value: PlainText. If an invalid value is specified for this parameter, PlainText is used.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The description of the command. The description supports all character sets and can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to include custom parameters in the command.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// The schedule based on which the command is run. When you set the `Timed` parameter to `true`, you must specify this parameter. You can run a command at a fixed interval based on a rate expression, run the command only once at a specific time, or run the command at specific times based on a cron expression.
        /// 
        /// *   To run a command at a fixed interval, use a rate expression to specify the interval. You can specify the interval in seconds, minutes, hours, or days. This option is suitable for scenarios in which tasks need to be executed at a fixed interval. Specify the interval in the following format: `rate(<Execution interval value><Execution interval unit>)`. For example, specify `rate(5m)` to run the command every 5 minutes. When you specify an interval, take note of the following limits:
        /// 
        ///     *   The specified interval can range from 60 seconds to 7 days and must be longer than the timeout period of the scheduled task.
        ///     *   The interval is the amount of time that elapsed between two consecutive executions. The interval is irrelevant to the amount of time that is required to run the command once. For example, you set the interval to 5 minutes, and the amount of time that is required to run the command once is 2 minutes. Each time the command is run, the system waits 3 minutes before the system reruns the command.
        ///     *   A task is not immediately run after it is created. For example, you set the interval to 5 minutes and create a task to run the command. The task runs 5 minutes after it is created.
        /// 
        /// *   To run a command only once at a specific time, specify a point in time and a time zone. Specify the point in time in the `at(yyyy-MM-dd HH:mm:ss <Time zone>)` format, which indicates `at(Year-Month-Day Hour:Minute:Second <Time zone>)`. If you do not specify a time zone, the default time zone UTC is used. You can specify the time zone in the following formats:
        /// 
        ///     *   The name of the time zone. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not add leading zeros to the hour value.
        ///     *   The abbreviation of the time zone. Only UTC is supported.
        /// 
        ///     For example, to specify a command that runs only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to `at(2022-06-06 13:15:30 Asia/Shanghai)`. To specify a command that runs only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to `at(2022-06-06 13:15:30 GMT-7:00)`.
        /// 
        /// *   To run a command at specific times, specify a cron expression. Specify the time in the `<Cron expression> <Time zone>` format. The cron expression is in the `<seconds> <minutes> <hours> <day of the month> <month> <day of the week> <year (optional)>` format. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zone of the instance on which you want to run the command is used. For more information about cron expressions, see [Cron expressions](~~64769~~). You can specify the time zone in the following formats:
        /// 
        ///     *   The name of the time zone. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not add leading zeros to the hour value.
        ///     *   The abbreviation of the time zone. Only UTC is supported.
        /// 
        ///     For example, to specify a command that runs at 10:15:00 every day in 2022 (Shanghai time), set the time to `0 15 10 ? * * 2022 Asia/Shanghai`. To specify a command that runs every 30 minutes from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the time to `0 0/30 10-11 * * ? 2022 GMT +8:00`. To specify a command to run every 5 minutes from 14:00:00 to 14:55:00 every October every two years starting from 2022 (UTC), set the time to `0 0/5 14 * 10 ? 2022/2 UTC`.
        /// 
        ///     **
        /// 
        ///     **Note**The interval must be at least 10 seconds and cannot be shorter than the timeout period of scheduled executions.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The ID of instance N on which you want to run the command. Valid values of N: 1 to 50.
        /// 
        /// If one of the specified instances does not meet the conditions for running the command, the call fails. To ensure that the call is successful, specify only the IDs of instances that meet the conditions.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to retain the command after the command is run. Valid values:
        /// 
        /// *   true: retains the command. You can call the InvokeCommand operation to rerun the command. The retained command counts against the quota of Cloud Assistant commands.
        /// *   false: does not retain the command. The command is automatically deleted after it is run and does not count against the quota of Cloud Assistant commands.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("KeepCommand")]
        [Validation(Required=false)]
        public bool? KeepCommand { get; set; }

        /// <summary>
        /// The name of the command. The name supports all character sets and can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key-value pairs of the custom parameters that are passed in when the command includes custom parameters. For example, the command content is `echo {{name}}`, and you can use the `Parameter` parameter to pass in the `{"name":"Jack"}` key-value pair. The `name` key of the custom parameter is automatically replaced by the paired Jack value to generate a new command. As a result, the `echo Jack` command is run.
        /// 
        /// You can specify up to 10 custom parameters. Take note of the following items:
        /// 
        /// *   The key cannot be an empty string. It can be up to 64 characters in length.
        /// *   The value can be an empty string.
        /// *   If you want to retain the command, make sure that the size of the command after Base64 encoding, including custom parameters and original command content, does not exceed 18 KB. If you do not want to retain the command, make sure that the size of the command after Base64-encoding does not exceed 24 KB. You can use the `KeepCommand` parameter to specify whether to retain the command.
        /// *   The custom parameter names that are specified by the Parameters parameter must be included in the custom parameter names that you specify when you created the command. You can use empty strings to represent the parameters that are not passed in.
        /// 
        /// By default, this parameter is left empty. If you want to disable the custom parameter feature, you can leave this parameter empty.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the mode in which you want to run the command. Valid values:
        /// 
        /// *   Once: immediately runs the command.
        /// *   Period: runs the command based on a schedule. If you set this parameter to `Period`, you must set the `Timed` parameter to true and specify the `Frequency` parameter.
        /// *   NextRebootOnly: automatically runs the command the next time the instance is started.
        /// *   EveryReboot: automatically runs the command every time the instance is started.
        /// 
        /// Default value:
        /// 
        /// *   If you set the `Timed` parameter to false and do not specify the `Frequency` parameter, the default value of the RepeatMode parameter is `Once`.
        /// *   If you set the `Timed` parameter to true and specify the `Frequency` parameter, `Period` is used as the value of the RepeatMode parameter regardless of whether you specify the RepeatMode parameter.
        /// 
        /// Take note of the following items:
        /// 
        /// *   If you set this parameter to `Period`, `NextRebootOnly`, or `EveryReboot`, you can call the [StopInvocation](~~64838~~) operation to stop the pending or scheduled execution of the command.
        /// *   If you set this parameter to `Period` or `EveryReboot`, you can call the [DescribeInvocationResults](~~64845~~) operation and set the `IncludeHistory` parameter to true to view the results of previous scheduled executions.
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the command executions. When you specify this parameter, take note of the following items:
        /// 
        /// *   The instances that are specified by the InstanceId parameter must belong to the specified resource group.
        /// *   You can specify this parameter to call the [DescribeInvocations](~~64840~~) or [DescribeInvocationResults](~~64845~~) operation to query execution results in the specified resource group.
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
        /// The tags that you want to add to the command.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandShrinkRequestTag> Tag { get; set; }
        public class RunCommandShrinkRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the command. You can specify up to 20 tag keys for the command. The tag key cannot be an empty string.
            /// 
            /// If you specify a tag to query resources, up to 1,000 resources that have the specified tag can be displayed in the response. If you specify multiple tags to query resources, up to 1,000 resources that have all specified tags can be displayed in the response. To query more than 1,000 resources that have the specified tags, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the command. You can specify up to 20 tag values for the command. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to run the command based on a schedule. Valid values:
        /// 
        /// *   true: runs the command based on the schedule that is specified by the `Frequency` parameter. The results of a command execution do not affect the next command execution.
        /// *   false: runs the command only once.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// The timeout period for the command execution. Unit: seconds.
        /// 
        /// A timeout error occurs when a command cannot be run because the command process slows down or because a specific module or the Cloud Assistant client does not exist. When an execution times out, the command process is forcibly terminated.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The language type of the command. Valid values:
        /// 
        /// *   RunBatScript: batch command, applicable to Windows instances
        /// *   RunPowerShellScript: PowerShell command, applicable to Windows instances
        /// *   RunShellScript: shell command, applicable to Linux instances
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The username that you use to run the command on instances.
        /// 
        /// *   For Linux instances, the root username is used.
        /// *   For Windows instances, the System username is used.
        /// 
        /// You can also specify other usernames that already exist on the instances to run the command. For security purposes, we recommend that you run Cloud Assistant commands as a regular user. For more information, see [Run Cloud Assistant commands as a regular user](~~203771~~).
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The name of the password that you use to run the command on Windows instances.
        /// 
        /// If you do not want to use the default username System to run the command on Windows instances, you must specify the WindowsPasswordName and `Username` parameters. The password is stored in plaintext in the parameter repository of Operation Orchestration Service (OOS) to reduce the risk of password leaks. Only the name of the password is passed in by using the WindowsPasswordName parameter. For more information, see [Encrypt parameters](~~186828~~) and [Configure a regular user to run Cloud Assistant commands](~~203771~~).
        /// 
        /// > If you use the root username for Linux instances or the System username for Windows instances to run the command, you do not need to specify the WindowsPasswordName parameter.
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// The working directory of the command on the instance.
        /// 
        /// Default values:
        /// 
        /// *   For Linux instances, the default value is `/root`, which is the home directory of the administrator (the root user).
        /// *   For Windows instances, the default value is the directory where the Cloud Assistant client process resides. Example: `C:\Windows\System32`.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
