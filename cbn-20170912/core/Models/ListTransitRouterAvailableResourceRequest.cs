// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterAvailableResourceRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the Enterprise Edition transit router.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
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

        /// <summary>
        /// Specifies whether to query only the zones in which the multicast feature is supported. Valid values:
        /// 
        /// *   **true**
        /// 
        ///     After you call **ListTransitRouterAvailableResource**, if no zone is returned, it indicates that the Enterprise Edition transit router does not support the multicast feature.
        /// 
        /// *   **false** (default)
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

    }

}
