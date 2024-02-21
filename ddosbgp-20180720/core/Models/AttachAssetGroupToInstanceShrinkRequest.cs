// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AttachAssetGroupToInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the asset to be associated.
        /// </summary>
        [NameInMap("AssetGroupList")]
        [Validation(Required=false)]
        public string AssetGroupListShrink { get; set; }

        /// <summary>
        /// The ID of the instance to query.
        /// 
        /// >  You can call the [DescribeInstanceList](~~118698~~) operation to query the IDs of all Anti-DDoS Origin instances of paid editions.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// 
        /// >  You can call the [DescribeRegions](~~118703~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source IP address of the request. The system specifies this parameter.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
