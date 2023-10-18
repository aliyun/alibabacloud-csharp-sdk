// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyCommonBandwidthPackageIpBandwidthRequest : TeaModel {
        /// <summary>
        /// The maximum bandwidth for the EIP. This value cannot be larger than the maximum bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The ID of the Internet Shared Bandwidth instance.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The ID of the EIP that is associated with the Internet Shared Bandwidth instance.
        /// </summary>
        [NameInMap("EipId")]
        [Validation(Required=false)]
        public string EipId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the Internet Shared Bandwidth instance. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
