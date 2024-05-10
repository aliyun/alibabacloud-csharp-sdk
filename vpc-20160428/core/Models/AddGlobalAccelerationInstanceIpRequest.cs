// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddGlobalAccelerationInstanceIpRequest : TeaModel {
        /// <summary>
        /// The ID of the shared-bandwidth GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// The EIP ID. You can call the [DescribeEipAddresses](https://help.aliyun.com/document_detail/36018.html) operation to query EIP IDs.
        /// 
        /// >  Make sure that the billing method of the EIP is pay-as-you-go, and the EIP and the shared-bandwidth GA instance belong to the same region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpInstanceId")]
        [Validation(Required=false)]
        public string IpInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region of the shared-bandwidth GA instance.
        /// 
        /// You can call the **DescribeRegions** operation to query the most recent region list.
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
