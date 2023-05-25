// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// The command ID. You can call the [DescribeCommands](~~64843~~) operation to query all available command IDs.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The command name.
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// The command type. If this parameter and `InstanceId` are both specified, this parameter does not take effect.
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// The encoding mode of the `CommandContent` and `Output` response parameters. Valid values:
        /// 
        /// *   PlainText: returns the original command content and command outputs.
        /// *   Base64: returns the Base64-encoded command content and command outputs.
        /// 
        /// Default value: Base64.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Specifies whether to return the command outputs in the response.
        /// 
        /// *   true: The command outputs are returned. When this parameter is set to true, you must specify `InvokeId`, `InstanceId`, or both.
        /// *   false: The command outputs are not returned.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// The ID of instance N. When you specify this parameter, the system queries all the execution records of all the commands that run on the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The command task ID.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The overall execution state of the command. The value of this parameter depends on the execution states on all involved instances. Valid values:
        /// 
        /// *   Running:
        /// 
        ///     *   Scheduled execution: Before you manually stop the execution of the command, the overall execution state is always Running.
        ///     *   One-time execution: If the execution is in progress on one or more instances, the overall execution state is Running.
        /// 
        /// *   Finished:
        /// 
        ///     *   Scheduled execution: The overall execution state can never be Finished.
        ///     *   One-time execution: The execution is complete on all instances, or the execution is manually stopped on some instances and is complete on other instances.
        /// 
        /// *   Failed:
        /// 
        ///     *   Scheduled execution: The overall execution state can never be Failed.
        ///     *   One-time execution: The execution fails on all instances.
        /// 
        /// *   PartialFailed:
        /// 
        ///     *   Scheduled execution: The overall execution state can never be PartialFailed.
        ///     *   One-time execution: The execution fails on some instances.
        /// 
        /// *   Stopped: The execution is stopped.
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// 
        /// Page numbers start from 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return per page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The execution mode of the command. Valid values:
        /// 
        /// *   Once: immediately runs the command.
        /// *   Period: The command is run on a schedule.
        /// *   NextRebootOnly: The command is automatically run the next time the instance starts.
        /// *   EveryReboot: The command is automatically run every time the instance starts.
        /// 
        /// This parameter is empty by default, which indicates that commands run in all modes are queried.
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// The ID of the resource group. After you set this parameter, command execution results in the specified resource group are queried.
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
        /// The tags that are added to the command.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationsRequestTag> Tag { get; set; }
        public class DescribeInvocationsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the command. You can specify up to 20 tag keys for the command. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the command. You can specify up to 20 tag values for the command. The tag value can be an empty string. It can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to query commands that are to be automatically run. Valid values:
        /// 
        /// *   true: queries commands that meet the following requirements: The commands are run by calling the `RunCommand` or `InvokeCommand` operation with `RepeatMode` set to `Period`, `NextRebootOnly`, or `EveryReboot`. The executions of the commands are not canceled and not complete or are not stopped and not complete.
        /// 
        /// *   false: queries commands that meet the following requirements:
        /// 
        ///     *   The commands are run by calling the `RunCommand` or `InvokeCommand` operation with `RepeatMode` set to `Once`.
        ///     *   The executions of the commands are canceled, stopped, or complete.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

    }

}
