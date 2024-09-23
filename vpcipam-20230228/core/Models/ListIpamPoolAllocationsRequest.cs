// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamPoolAllocationsRequest : TeaModel {
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        [NameInMap("IpamPoolAllocationIds")]
        [Validation(Required=false)]
        public List<string> IpamPoolAllocationIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
