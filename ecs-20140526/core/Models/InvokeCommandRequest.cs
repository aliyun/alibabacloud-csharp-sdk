// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandRequest : TeaModel {
        /// <summary>
        /// The ID of the command. You can call the [DescribeCommands](~~64843~~) operation to query all available command IDs.
        /// 
        /// >  Common Cloud Assistant commands can be run based on the names. For more information, see [View and run common Cloud Assistant commands](~~429635~~).
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The ID of the container. Only 64-bit hexadecimal strings are supported. You can use container IDs that are prefixed with `docker://`, `containerd://`, or `cri-o://` to specify container runtimes.
        /// 
        /// Note:
        /// 
        /// *   If you specify this parameter, Cloud Assistant runs scripts in the specified container of the instance.
        /// 
        /// *   If you specify this parameter, scripts can be run only on Linux instances on which the Cloud Assistant client of version 2.2.3.344 or later is installed.
        /// 
        ///     *   For information about how to view the version of the Cloud Assistant client, see [Install the Cloud Assistant client](~~64921~~).
        ///     *   For information about how to update the version of the Cloud Assistant client, see [Upgrade or disable upgrades for the Cloud Assistant client](~~134383~~).
        /// 
        /// *   If you specify this parameter, the `Username` parameter that is specified in a request to call this operation and the `WorkingDir` parameter that is specified in a request to call the [CreateCommand](~~64844~~) operation do not take effect. You can run the command in the default working directory of the container only by using the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// 
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify a script interpreter by adding a command in a format that is similar to `#!/usr/bin/python` at the beginning of a script. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The name of the container.
        /// 
        /// Note:
        /// 
        /// *   If you specify this parameter, Cloud Assistant runs scripts in the specified container of the instance.
        /// 
        /// *   If you specify this parameter, scripts can be run only on Linux instances on which the Cloud Assistant client of version 2.2.3.344 or later is installed.
        /// 
        ///     *   For information about how to view the version of the Cloud Assistant client, see [Install the Cloud Assistant client](~~64921~~).
        ///     *   For information about how to update the version of the Cloud Assistant client, see [Upgrade or disable upgrades for the Cloud Assistant client](~~134383~~).
        /// 
        /// *   If you specify this parameter, the `Username` parameter that is specified in a request to call this operation and the `WorkingDir` parameter that is specified in a request to call the [CreateCommand](~~64844~~) operation do not take effect. You can run the command in the default working directory of the container only by using the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// 
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot specify a script interpreter by adding a command in a format that is similar to `#!/usr/bin/python` at the beginning of a script. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The schedule on which you want to run the command. When you set the `Timed` parameter to `true`, you must specify this parameter. You can run a command at a fixed interval based on a rate expression, run the command only once at a specified time, or run the command at specific times based on a cron expression.
        /// 
        /// *   To run a command at a fixed interval, use a rate expression to specify the interval. You can specify an interval in seconds, minutes, hours, or days. This option is suitable when tasks need to be executed at a fixed interval. Specify the interval in the following format: `rate(<Execution interval value><Execution interval unit>)`. For example, specify `rate(5m)` to run the command every 5 minutes. Take note of the following limits when you specify an interval:
        /// 
        ///     *   The specified interval can range from 60 seconds to seven days and must be longer than the timeout period of the scheduled task.
        ///     *   The interval is the amount of time that elapsed between two consecutive executions. The interval is irrelevant to the amount of time that is required to run the command once. For example, you set the interval to 5 minutes, and the amount of time that is required to run the command once is 2 minutes to run the command each time. Each time the command is run, the system waits 3 minutes before the system reruns the command.
        ///     *   A task is not immediately executed after it is created. For example, you set the interval to 5 minutes and create a task to run the command. The task runs 5 minutes after it is created.
        /// 
        /// *   To run a command only once at a specified time, specify a point in time and a time zone. Specify the point in time in the following format: `at(yyyy-MM-dd HH:mm:ss <Time zone>)`, which indicates `at(Year-Month-Day Hour:Minute:Second <Time zone>)`. If you do not specify a time zone, the default time zone UTC is used. You can specify the time zone in the following formats:
        /// 
        ///     *   The name of the time zone. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not pad leading zeros to the hour value.
        ///     *   The abbreviation of the time zone. Only UTC is supported.
        /// 
        ///     For example, to run a command only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to `at(2022-06-06 13:15:30 Asia/Shanghai)`. To run a command only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to `at(2022-06-06 13:15:30 GMT-7:00)`.
        /// 
        /// *   To run a command at specific times, specify a cron expression. Specify the time in the following format: `<Cron expression> <Time zone>`, where the cron expression is in the `<seconds> <minutes> <hours> <day of the month> <month> <day of the week> <year (optional)>` format. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zone of the instance on which you want to run the command is used. For more information about cron expressions, see [Cron expressions](~~64769~~). You can specify the time zone in the following formats:
        /// 
        ///     *   The name of the time zone. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not pad leading zeros to the hour value.
        ///     *   The abbreviation of the time zone. Only UTC is supported.
        /// 
        ///     For example, to run a command at 10:15:00 every day in 2022 (Shanghai time), set the time to `0 15 10 ? * * 2022 Asia/Shanghai`. To run a command every 30 minutes from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the time to `0 0/30 10-11 * * ? 2022 GMT +8:00`. To run a command every 5 minutes from 14:00:00 to 14:55:00 every October every two years starting from 2022 (UTC), set the time to `0 0/5 14 * 10 ? 2022/2 UTC`.
        /// 
        ///     **
        /// 
        ///     **Note** The interval is at least 10 seconds and cannot be shorter than the timeout period of scheduled executions.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The IDs of the instances on which you want to run the command. You can specify up to 50 instance IDs in each request.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key-value pairs of the custom parameters that are passed in when the custom parameter feature is enabled. Number of custom parameters: 0 to 10.
        /// 
        /// *   Each key in a Map collection cannot be an empty string and can be up to 64 characters in length.
        /// *   Values in a Map collection can be empty strings.
        /// *   The size of the command after Base64 encoding, including the custom parameters and the original command content, cannot exceed 18 KB.
        /// *   The custom parameter names that are specified by the Parameters parameter must be included in the custom parameter names that you specified when you created the command. You can use empty strings to represent the parameters that are not passed in.
        /// 
        /// If you want to disable the custom parameter feature, you can leave this parameter empty.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies how to run the command. Valid values:
        /// 
        /// *   Once: immediately runs the command.
        /// *   Period: runs the command on a schedule. If you set this parameter to `Period`, you must set the `Timed` parameter to true and specify the `Frequency` parameter.
        /// *   NextRebootOnly: automatically runs the command the next time the instance starts.
        /// *   EveryReboot: automatically runs the command every time the instance starts.
        /// 
        /// Default value:
        /// 
        /// *   If you set the `Timed` parameter to false and do not specify the `Frequency` parameter, the default value of the RepeatMode parameter is `Once`.
        /// *   If you set the `Timed` parameter to true and specify the `Frequency` parameter, `Period` is used as the value of the RepeatMode parameter regardless of whether you specify the RepeatMode parameter.
        /// 
        /// Note:
        /// 
        /// *   If you set the RepeatMode parameter to `Period`, `NextRebootOnly`, or `EveryReboot`, you can call the [StopInvocation](~~64838~~) operation to stop the pending or scheduled execution of the command.
        /// *   If you set the RepeatMode parameter to `Period` or `EveryReboot`, you can call the [DescribeInvocationResults](~~64845~~) operation and set the `IncludeHistory` parameter to true to view the results of previous scheduled executions.
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the command executions. Take note of the following items when you set this parameter:
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
        /// The tags that you want to add.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InvokeCommandRequestTag> Tag { get; set; }
        public class InvokeCommandRequestTag : TeaModel {
            /// <summary>
            /// The keys of tags of the command. You can specify up to 20 tag keys for the command. The tag key cannot be an empty string.
            /// 
            /// If you specify a tag to query resources, up to 1,000 resources that have the specified tag can be displayed in the response. If you specify multiple tags to query resources, up to 1,000 resources that have all specified tags can be displayed in the response. To query more than 1,000 resources that have the specified tags, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The values of the tags of the command. You can specify up to 20 tag values for the command. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to run the command on a schedule. Valid values:
        /// 
        /// *   true: runs the command on the schedule that is specified by the `Frequency` parameter. The execution results of a command do not affect the next command execution.
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
        /// *   The timeout period cannot be less than 10 seconds.
        /// *   If a command cannot be run because the process slows down or because a specific module or the Cloud Assistant client does not exist, a timeout error occurs. When an execution times out, the command process is forcibly terminated.
        /// *   If you do not specify this parameter, the timeout period that is specified when the command is created prevails and
        /// *   is used as the timeout period for the execution. The timeout period of the command is not modified.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The username that you use to run the command on instances.
        /// 
        /// *   For Linux instances, the root username is used.
        /// *   For Windows instances, the System username is used.
        /// 
        /// You can also specify other usernames that already exist on the instances to run the command. To ensure security, we recommend that you run Cloud Assistant commands as a regular user. For more information, see [Run Cloud Assistant commands as a regular user](~~203771~~).
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The name of the password that you use to run the command on Windows instances.
        /// 
        /// If you do not want to use the default username System to run the command on Windows instances, you must specify the WindowsPasswordName and `Username` parameters. The password is stored in plaintext in the parameter repository of Operation Orchestration Service (OOS) to mitigate the risk of password leaks. Only the name of the password is passed in by using the WindowsPasswordName parameter. For more information, see [Manage encryption parameters](~~186828~~) and [Run Cloud Assistant commands as a regular user](~~203771~~).
        /// 
        /// >  If you use the root username for Linux instances or the System username for Windows instances to run the command, you do not need to specify the WindowsPasswordName parameter.
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

    }

}
