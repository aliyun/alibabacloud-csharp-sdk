// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class GetIpamPoolAllocationResponseBody : TeaModel {
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("IpamPoolAllocationDescription")]
        [Validation(Required=false)]
        public string IpamPoolAllocationDescription { get; set; }

        [NameInMap("IpamPoolAllocationId")]
        [Validation(Required=false)]
        public string IpamPoolAllocationId { get; set; }

        [NameInMap("IpamPoolAllocationName")]
        [Validation(Required=false)]
        public string IpamPoolAllocationName { get; set; }

        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
