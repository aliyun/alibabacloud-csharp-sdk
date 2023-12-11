// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBVersionInfosRequest : TeaModel {
        /// <summary>
        /// The resource type of the instance. Valid values:
        /// 
        /// *   **StorageElastic**: elastic storage mode.
        /// *   **Serverless**: Serverless mode.
        /// </summary>
        [NameInMap("DBInstanceMode")]
        [Validation(Required=false)]
        public string DBInstanceMode { get; set; }

        /// <summary>
        /// The minor version number that does not include the prefix.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// >  You can call the [DescribeRegions](~~86912~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. For information about how to obtain the ID of a resource group, see [View basic information of a resource group](~~151181~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
