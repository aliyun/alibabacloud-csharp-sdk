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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public long? BandwidthLimit { get; set; }

        /// <summary>
        /// The bandwidth allocation method. Valid values:
        /// 
        /// **BandwidthPackage**: allocates bandwidth from a bandwidth plan.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the local region.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query regions where you can attach network instances to a CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalRegionId")]
        [Validation(Required=false)]
        public string LocalRegionId { get; set; }

        /// <summary>
        /// The ID of the peer region.
        /// 
        /// This parameter is required.
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
