// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public List<DescribeNatGatewaysResponseBodyNatGateways> NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("ForwardTableIds")]
            [Validation(Required=false)]
            public List<string> ForwardTableIds { get; set; }

            [NameInMap("IpLists")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysIpLists> IpLists { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysIpLists : TeaModel {
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                [NameInMap("SnatEntryEnabled")]
                [Validation(Required=false)]
                public string SnatEntryEnabled { get; set; }

                [NameInMap("UsingStatus")]
                [Validation(Required=false)]
                public string UsingStatus { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            [NameInMap("SnatTableIds")]
            [Validation(Required=false)]
            public List<string> SnatTableIds { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
