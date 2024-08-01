// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceRamRoleRequest : TeaModel {
        /// <summary>
        /// The IDs of instances. You can specify up to 100 instance IDs in a single request. You must specify at least one of the `InstanceIds` and `RamRoleName` parameters.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the instance RAM role. You can call the [ListRoles](https://help.aliyun.com/document_detail/28713.html) operation provided by RAM to query the instance RAM roles that you created. You must specify at least one of the `InstanceIds` and `RamRoleName` parameters.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the instance RAM role. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent list of regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
