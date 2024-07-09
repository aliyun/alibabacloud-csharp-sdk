// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// The type of the command. Valid values:
        /// 
        /// *   RunBatScript
        /// *   RunPowerShellScript
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// The encoding method of the command content and output. Valid values:
        /// 
        /// *   PlainText
        /// *   Base64
        /// 
        /// Default value: Base64.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The ID of the cloud desktop. If you specify a cloud desktop, all the execution records of Cloud Assistant commands on the cloud desktop are queried.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The IDs of the cloud desktops.
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// The ID of the end user.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// Specifies whether to return command outputs in the response. Valid values:
        /// 
        /// *   true: returns command outputs.
        /// *   false: does not return command outputs.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// The ID of the execution.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The overall execution status of a command. The overall execution status is determined by the execution status of the command on one or more cloud desktops. Valid values:
        /// 
        /// *   Running: The execution is in progress on one or more cloud desktops.
        /// *   Finished: The execution is finished on all cloud desktops, or the execution is manually stopped on some cloud desktops and the execution is finished on others.
        /// *   Failed: The execution failed on all cloud desktops.
        /// *   PartialFailed: The execution failed on some cloud desktops.
        /// *   Stopped: The execution is stopped.
        /// 
        /// Default value: Running.
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// *   Valid values: 1 to 50.
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The query token. Set the value to the NextToken value that is returned from the last call to the previous DescribeInvocations operation.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
