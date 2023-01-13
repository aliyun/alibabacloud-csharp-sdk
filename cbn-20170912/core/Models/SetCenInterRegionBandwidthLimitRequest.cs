// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class SetCenInterRegionBandwidthLimitRequest : TeaModel {
        /// <summary>
        /// The maximum bandwidth value of the inter-region connection. Unit: Mbit/s.
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public long? BandwidthLimit { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the local region.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query regions where you can attach network instances to a CEN instance.
        /// </summary>
        [NameInMap("LocalRegionId")]
        [Validation(Required=false)]
        public string LocalRegionId { get; set; }

        /// <summary>
        /// The ID of the peer region.
        /// </summary>
        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
