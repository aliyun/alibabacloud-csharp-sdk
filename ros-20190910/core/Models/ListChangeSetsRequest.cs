// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChangeSetsRequest : TeaModel {
        /// <summary>
        /// The ID of the change set. If detailed information about the change set is not required, you can use this parameter to replace the GetChangeSet operation.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// The name of change set N. Maximum value of N: 5. You can use an asterisk (\\*) as a wildcard for fuzzy search.
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public List<string> ChangeSetName { get; set; }

        /// <summary>
        /// The execution status of change set N. Maximum value of N: 5. Valid values:
        /// 
        /// *   UNAVAILABLE
        /// *   AVAILABLE
        /// *   EXECUTE_IN_PROGRESS
        /// *   EXECUTE_COMPLETE
        /// *   EXECUTE_FAILED
        /// *   OBSOLETE
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public List<string> ExecutionStatus { get; set; }

        /// <summary>
        /// The page number.\\
        /// Pages start from page 1.\\
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.\\
        /// Valid values: 1 to 50.\\
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID of the change set. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The status of change set N. Maximum value of N: 5. Valid values:
        /// 
        /// *   CREATE_PENDING
        /// *   CREATE_IN_PROGRESS
        /// *   CREATE_COMPLETE
        /// *   CREATE_FAILED
        /// *   DELETE_FAILED
        /// *   DELETE_COMPLETE
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
