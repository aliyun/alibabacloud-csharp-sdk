// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackInstancesRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// 
        /// *   Pages start from page 1.
        /// *   Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// *   Valid values: 1 to 50.
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the region to which the stack group belongs. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group. The name must be unique within a region.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The ID of the account to which the stack belongs.
        /// 
        /// *   If the stack group is granted self-managed permissions, the stack belongs to an Alibaba Cloud account.
        /// 
        /// *   If the stack group is granted service-managed permissions, the stack belongs to a member in a resource directory.
        /// 
        /// > For more information about the account, see [Overview](~~154578~~).
        /// </summary>
        [NameInMap("StackInstanceAccountId")]
        [Validation(Required=false)]
        public string StackInstanceAccountId { get; set; }

        /// <summary>
        /// The ID of the region to which the stack belongs.
        /// </summary>
        [NameInMap("StackInstanceRegionId")]
        [Validation(Required=false)]
        public string StackInstanceRegionId { get; set; }

    }

}
