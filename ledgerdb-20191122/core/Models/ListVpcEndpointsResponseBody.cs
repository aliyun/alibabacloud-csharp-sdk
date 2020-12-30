// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcEndpoints")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyVpcEndpoints> VpcEndpoints { get; set; }
        public class ListVpcEndpointsResponseBodyVpcEndpoints : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("VpcEndpointId")]
            [Validation(Required=false)]
            public string VpcEndpointId { get; set; }

            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("LedgerId")]
            [Validation(Required=false)]
            public string LedgerId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
