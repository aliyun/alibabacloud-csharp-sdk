// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsRequest : TeaModel {
        /// <summary>
        /// The execution results.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The information about the tag.
        /// </summary>
        [NameInMap("IncludeHistory")]
        [Validation(Required=false)]
        public bool? IncludeHistory { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the command execution.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the command.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The ID of the container.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the user who ran the command on the instance.
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
        /// The error code returned when the command cannot be sent or run. Valid values:
        /// 
        /// *   If this parameter is empty, the command is run normally.
        /// *   InstanceNotExists: The specified instance does not exist is released.
        /// *   InstanceReleased: The instance was released while the command was being run on the instance.
        /// *   InstanceNotRunning: The instance is not in the Running state while the command is being run.
        /// *   CommandNotApplicable: The command is not applicable to the specified instance.
        /// *   AccountNotExists: The specified account does not exist.
        /// *   DirectoryNotExists: The specified directory does not exist.
        /// *   BadCronExpression: The cron expression used to specify the execution time is invalid.
        /// *   ClientNotRunning: The Cloud Assistant client is not running.
        /// *   ClientNotResponse: The Cloud Assistant client is not responding.
        /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
        /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
        /// *   DeliveryTimeout: The request to send the command timed out.
        /// *   ExecutionTimeout: The command execution timed out.
        /// *   ExecutionException: An exception occurred while the command was being run.
        /// *   ExecutionInterrupted: The execution was interrupted.
        /// *   ExitCodeNonzero: The command execution is complete, but the exit code is not 0.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The execution state of the command.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
