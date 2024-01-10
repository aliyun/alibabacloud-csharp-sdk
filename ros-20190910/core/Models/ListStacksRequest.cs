// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStacksRequest : TeaModel {
        /// <summary>
        /// The end of the time range during which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the parent stack.
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.\
        /// For more information about resource groups, see the "Resource Group" section of the [What is Resource Management?](~~94475~~) topic.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to return nested stacks. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// 
        /// > If you specify ParentStackId, you must set ShowNestedStack to true.
        /// </summary>
        [NameInMap("ShowNestedStack")]
        [Validation(Required=false)]
        public bool? ShowNestedStack { get; set; }

        /// <summary>
        /// The stack ID. You can specify this parameter to query only the stack ID. If you want to query the detailed information about the stack, call the GetStack operation.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The IDs of the stacks.
        /// </summary>
        [NameInMap("StackIds")]
        [Validation(Required=false)]
        public List<string> StackIds { get; set; }

        /// <summary>
        /// The names of the stacks.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public List<string> StackName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the stack.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// The tags of the stack.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListStacksRequestTag> Tag { get; set; }
        public class ListStacksRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.\
            /// Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.\
            /// Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
