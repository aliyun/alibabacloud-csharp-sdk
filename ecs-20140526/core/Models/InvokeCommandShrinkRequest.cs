// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The command ID. You can call the [DescribeCommands](~~64843~~) operation to query all available command IDs.
        /// 
        /// >  Common Cloud Assistant commands can be run based on their names. For more information, see [View and run common Cloud Assistant commands](~~429635~~).
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The ID of the container. Only 64-bit hexadecimal strings are supported. You can use container IDs that are prefixed with `docker://`, `containerd://`, or `cri-o://` to specify container runtimes.
        /// 
        /// Take note of the following items:
        /// 
        /// *   If you specify this parameter, Cloud Assistant runs scripts in the specified container of the instance.
        /// 
        /// *   If you specify this parameter, make sure that the version of Cloud Assistant Agent installed on Linux instances is 2.2.3.344 or later.
        /// 
        ///     *   For information about how to query the version of Cloud Assistant Agent, see [Install Cloud Assistant Agent](~~64921~~).
        ///     *   For information about how to upgrade Cloud Assistant Agent, see [Upgrade or disable upgrades for Cloud Assistant Agent](~~134383~~).
        /// 
        /// *   If you specify this parameter, `Username` that is specified in a request to call this operation and `WorkingDir` that is specified in a request to call the [CreateCommand](~~64844~~) operation do not take effect. You can run the command only in the default working directory of the container by using the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// 
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot add a command in the format similar to `#!/usr/bin/python` at the beginning of a script to specify a script interpreter. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
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
        /// 
        /// *   If you specify this parameter, make sure that the version of Cloud Assistant Agent installed on Linux instances is 2.2.3.344 or later.
        /// 
        ///     *   For information about how to query the version of Cloud Assistant Agent, see [Install Cloud Assistant Agent](~~64921~~).
        ///     *   For information about how to upgrade Cloud Assistant Agent, see [Upgrade or disable upgrades for Cloud Assistant Agent](~~134383~~).
        /// 
        /// *   If this parameter is specified, the `Username` parameters specified in this interface and the `WorkingDir` parameters specified in [CreateCommand](~~64844~~) do not take effect. You can run the command only in the default working directory of the container by using the default user of the container. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// 
        /// *   If you specify this parameter, only shell scripts can be run in Linux containers. You cannot add a command in the format similar to `#!/usr/bin/python` at the beginning of a script to specify a script interpreter. For more information, see [Use Cloud Assistant to run commands in containers](~~456641~~).
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The schedule on which the command is run. You can configure a command to run at a fixed interval based on a rate expression, run only once at a specified time, or run at designated times based on a cron expression.
        /// 
        /// *   To run the command at a fixed interval, use a rate expression to specify the interval. You can specify the interval in seconds, minutes, hours, or days. This option is suitable for scenarios in which the command needs to be run at a fixed interval. Specify the interval in the following format: `rate(<Execution interval value><Execution interval unit>)`. For example, specify `rate(5m)` to run the command every 5 minutes. When you specify an interval, take note of the following limits:
        /// 
        ///     *   The interval can be anywhere from 60 seconds to 7 days, and must be longer than the timeout period for executions of the command.
        ///     *   The interval is the amount of time that elapses between two consecutive executions. The interval is irrelevant to the amount of time that is required to run the command once. For example, you set the interval to 5 minutes and the command requires 2 minutes to run once. Each time the command is run, the system waits 3 minutes before it runs the command again.
        ///     *   A task is not run immediately after it is created. For example, you configure the command to run at an interval of 5 minutes. The command begins to run 5 minutes after it is created.
        /// 
        /// *   To run a command only once at a specific time, specify a point in time and a time zone. Specify the point in time in the `at(yyyy-MM-dd HH:mm:ss <Time zone>)` format, which indicates `at(Year-Month-Day Hour:Minute:Second <Time zone>)`. If you do not specify a time zone, the Coordinated Universal Time (UTC) time zone is used by default. You can specify a time zone in the following forms:
        /// 
        ///     *   The time zone name. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not add leading zeros to the hour value.
        ///     *   The time zone abbreviation. Only UTC is supported.
        /// 
        ///     For example, to configure a command to run only once at 13:15:30 on June 6, 2022 (Shanghai time), set the time to `at(2022-06-06 13:15:30 Asia/Shanghai)`. To configure a command to run only once at 13:15:30 on June 6, 2022 (UTC-7), set the time to `at(2022-06-06 13:15:30 GMT-7:00)`.
        /// 
        /// *   To run a command at designated times, use a cron expression to define the schedule. Specify a schedule in the `<Cron expression> <Time zone>` format. The cron expression is in the `<seconds> <minutes> <hours> <day of the month> <month> <day of the week> <year (optional)>` format. The system calculates the execution times of the command based on the specified cron expression and time zone and runs the command as scheduled. If you do not specify a time zone, the system time zone of the instance on which you want to run the command is used by default. For information about cron expressions, see [Cron expressions](~~64769~~). You can specify the time zone in the following forms:
        /// 
        ///     *   The time zone name. Examples: `Asia/Shanghai` and `America/Los_Angeles`.
        ///     *   The time offset from GMT. Examples: `GMT+8:00` (UTC+8) and `GMT-7:00` (UTC-7). If you use the GMT format, do not add leading zeros to the hour value.
        ///     *   The time zone abbreviation. Only UTC is supported. For example, to configure a command to run at 10:15:00 every day in 2022 (Shanghai time), set the schedule to `0 15 10 ? * * 2022 Asia/Shanghai`. To configure a command to run every half an hour from 10:00:00 to 11:30:00 every day in 2022 (UTC+8), set the schedule to `0 0/30 10-11 * * ? 2022 GMT+8:00`. To configure a command to run every 5 minutes from 14:00:00 to 14:55:00 every October every two years from 2022 in UTC, set the schedule to `0 0/5 14 * 10 ? 2022/2 UTC`.
        /// 
        ///     **
        /// 
        ///     **Note** The minimum interval must be 10 seconds or more and cannot be shorter than the timeout period of scheduled executions.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The IDs of the instances on which you want to run the command. You can specify up to 50 instance IDs in each request. Valid values of N: 1 to 50.
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
        /// The key-value pairs of custom parameters to be passed in when the custom parameter feature is enabled. Number of custom parameters: 0 to 10.
        /// 
        /// *   Keys in a Map collection can be up to 64 characters in length, and cannot be empty strings.
        /// *   Values in a Map collection can be empty strings.
        /// *   The size of the Base64-encoded custom parameters and original command content cannot exceed 18 KB.
        /// *   The custom parameter names specified in the value of Parameters must be included in the custom parameters specified when you created the command. You can use empty strings to represent the parameters that are not passed in.
        /// 
        /// If you want to disable the custom parameter feature, you can leave this parameter empty.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// The region ID of the command. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies how to run the command. Valid values:
        /// 
        /// *   Once: runs the command immediately.
        /// *   Period: runs the command on a schedule. If you set this parameter to `Period`, you must specify `Frequency`.
        /// *   NextRebootOnly: runs the command the next time the instance is started.
        /// *   EveryReboot: runs the command every time the instance is started.
        /// 
        /// Default values:
        /// 
        /// *   If you do not specify `Frequency`, the default value is `Once`.
        /// *   If you specify `Frequency`, `Period` is used as the value of RepeatMode regardless of whether RepeatMode is set to Period.
        /// 
        /// Take note of the following items:
        /// 
        /// *   You can call the [StopInvocation](~~64838~~) operation to stop the pending or scheduled executions of the command.
        /// *   If you set this parameter to `Period` or `EveryReboot`, you can call the [DescribeInvocationResults](~~64845~~) operation with `IncludeHistory` set to true to query the results of historical scheduled executions.
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the command executions. When you set this parameter, take note of the following items:
        /// 
        /// *   The instances specified by InstanceId.N must belong to the specified resource group.
        /// *   After the command is run, you can call the [DescribeInvocations](~~64840~~) or [DescribeInvocationResults](~~64845~~) operation with ResourceGroupId set to query the execution results in the specified resource group.
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
        /// The tags that are used to filter instances. You can specify this parameter to run the command on multiple instances that have the specified tags added without the need to specify the InstanceId parameter.
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<InvokeCommandShrinkRequestResourceTag> ResourceTag { get; set; }
        public class InvokeCommandShrinkRequestResourceTag : TeaModel {
            /// <summary>
            /// The key of tag N that is used to filter instances.
            /// 
            /// Take note of the following items:
            /// 
            /// *   You can specify this parameter or the InstanceId parameter, but not both.
            /// *   Valid values of N: 1 to 10. The tag key cannot be an empty string.
            /// *   The number of instances with the tag added cannot exceed the value specified by InstanceId.N. If the number of instances exceeds the limit, we recommend that you also specify a batch tag such as batch: b1 to filter the instances in separate batches.
            /// *   The tag key can be up to 64 characters in length. It cannot start with acs: or aliyun, or contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is used to filter instances.
            /// 
            /// Take note of the following items:
            /// 
            /// *   Valid values of N: 1 to 10.
            /// *   The tag value can be an empty string.
            /// *   The tag key can be up to 128 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InvokeCommandShrinkRequestTag> Tag { get; set; }
        public class InvokeCommandShrinkRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the command task. Valid values of N: 1 to 20. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the command task. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// >  This parameter is no longer used and does not take effect.
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// The timeout period for the execution of the command. Unit: seconds.
        /// 
        /// *   The timeout period cannot be less than 10 seconds.
        /// *   A timeout error occurs if the command cannot be run because the process slows down or because a specific module or Cloud Assistant Agent does not exist. When an execution times out, the command process is forcefully terminated.
        /// *   If you do not specify this parameter, the timeout period that is specified when the command is created is used.
        /// *   This timeout period is applicable only to this execution. The timeout period of the command is not modified.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The username to use to run the command on instances. The username can be up to 255 characters in length.
        /// 
        /// *   For Linux instances, the root username is used by default.
        /// *   For Windows instances, the System username is used by default.
        /// 
        /// You can also specify other usernames that already exist on the instances to run the command. For security purposes, we recommend that you run Cloud Assistant commands as a regular user. For more information, see [Run Cloud Assistant commands as a regular user](~~203771~~).
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The name of the password to use to run the command on Windows instances. The name can be up to 255 characters in length.
        /// 
        /// If you do not want to use the default System user to run the command on Windows instances, specify both WindowsPasswordName and `Username`. The password is stored in plaintext in CloudOps Orchestration Service (OOS) Parameter Store to mitigate the risk of password leaks. Only the name of the password is passed in by using the WindowsPasswordName parameter. For more information, see [Manage encryption parameters](~~186828~~) and [Run Cloud Assistant commands as a regular user](~~203771~~).
        /// 
        /// >  If you use the root username for Linux instances or the System username for Windows instances to run the command, you do not need to specify the WindowsPasswordName parameter.
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

    }

}
