// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsRequest : TeaModel {
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
        /// The region ID of the stack group. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify this parameter, the stack groups in all the resource groups are queried.
        /// 
        /// > To obtain the resource group ID, go to the **Resource Group** page in the **Resource Management** console. For more information, see [View the basic information about a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The state of the stack group. If you do not specify this parameter, the stack groups in all states in the specified region are queried.
        /// 
        /// Valid values:
        /// 
        /// *   ACTIVE
        /// *   DELETED
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags that are added to the stack group.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListStackGroupsRequestTags> Tags { get; set; }
        public class ListStackGroupsRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the stack group.
            /// 
            /// > Tags is optional. If you specify Tags, you must specify Tags.N.Key.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the stack group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
