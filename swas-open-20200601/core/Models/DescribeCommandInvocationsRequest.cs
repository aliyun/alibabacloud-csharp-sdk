// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsRequest : TeaModel {
        /// <summary>
        /// The command ID. You can call the [DescribeCommands](https://help.aliyun.com/document_detail/64843.html) operation to query all available command IDs.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The command name. If both CommandName and InstanceId are specified, CommandName does not take effect.
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// The command type. Valid values:
        /// 
        /// *   RunBatScript: batch command, applicable to Windows instances
        /// *   RunPowerShellScript: PowerShell command, applicable to Windows instances
        /// *   RunShellScript: shell command, applicable to Linux instances
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The overall execution state of the command. The value of this parameter depends on the execution status of the command on all the involved instances. Valid values:
        /// 
        /// *   Pending: The command is being verified or sent. When the execution state on at least one instance is Pending, the overall execution state is Pending.
        /// 
        /// *   Running: The command is being run on the instances. When the execution state on at least one instance is Running, the overall execution state is Running.
        /// 
        /// *   Success: When the execution state on at least one instance is Success and the execution state on other instances is Stopped or Success, the overall execution state is Success.
        /// 
        ///     *   Command that is set to run immediately: The command execution is complete, and the exit code is 0.
        /// 
        /// *   Failed: When the execution state on all instances is Stopped or Failed, the overall execution state is Failed. When the execution state on an instance is one of the following values, Failed is returned as the overall execution state:
        /// 
        ///     *   Invalid: The command is invalid.
        ///     *   Aborted: The command fails to be sent.
        ///     *   Failed: The command execution is complete, and the exit code is not 0.
        ///     *   Timeout: The command execution times out.
        ///     *   Error: An error occurs when the command is being run.
        /// 
        /// *   Stopping: The command task is being stopped. When the execution state on at least one instance is Stopping, the overall execution state is Stopping.
        /// 
        /// *   Stopped: The command task is stopped. When the execution state on all instances is Stopped, the overall execution state is Stopped. When the execution state on an instance is one of the following values, Stopped is returned as the overall execution state:
        /// 
        ///     *   Cancelled: The command task is canceled.
        ///     *   Terminated: The command task is terminated.
        /// 
        /// *   PartialFailed: The command execution succeeds on some instances and fails on other instances. When the execution state on some instances is Success and the execution state on other instances is Failed or Stopped, the overall execution state is PartialFailed.
        /// 
        /// >  The value of the `InvokeStatus` response parameter is similar to the value of InvocationStatus. We recommend that you ignore InvokeStatus and check the value of InvocationStatus.
        /// </summary>
        [NameInMap("InvocationStatus")]
        [Validation(Required=false)]
        public string InvocationStatus { get; set; }

        /// <summary>
        /// The execution ID of the command.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The page number. Pages start from 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
