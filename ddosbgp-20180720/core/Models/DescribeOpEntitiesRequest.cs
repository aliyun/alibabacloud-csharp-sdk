// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end time. Operation logs that were generated before this time are queried.**** The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the instance to query.
        /// 
        /// > You can call the [DescribeInstanceList](https://help.aliyun.com/document_detail/118698.html) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The sorting method of operation logs. Set the value to **opdate**, which indicates sorting based on the operation time.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The sort order of operation logs. Valid values:
        /// 
        /// *   **ASC**: the ascending order.
        /// *   **DESC**: the descending order.
        /// 
        /// Default value: **DESC**.
        /// </summary>
        [NameInMap("OrderDir")]
        [Validation(Required=false)]
        public string OrderDir { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 50.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The start time. Operation logs that were generated after this time are queried.**** The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
