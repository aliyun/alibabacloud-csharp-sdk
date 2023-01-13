// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenPrivateZoneRoutesRequest : TeaModel {
        /// <summary>
        /// The ID of the region where PrivateZone is accessed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("AccessRegionId")]
        [Validation(Required=false)]
        public string AccessRegionId { get; set; }

        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the region where PrivateZone is deployed.
        /// </summary>
        [NameInMap("HostRegionId")]
        [Validation(Required=false)]
        public string HostRegionId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**. Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
