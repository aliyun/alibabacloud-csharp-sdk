// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAccelerateIpsResponseBody : TeaModel {
        [NameInMap("AccelerateIps")]
        [Validation(Required=false)]
        public List<ListBasicAccelerateIpsResponseBodyAccelerateIps> AccelerateIps { get; set; }
        public class ListBasicAccelerateIpsResponseBodyAccelerateIps : TeaModel {
            [NameInMap("AccelerateIpAddress")]
            [Validation(Required=false)]
            public string AccelerateIpAddress { get; set; }

            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public ListBasicAccelerateIpsResponseBodyAccelerateIpsEndpoint Endpoint { get; set; }
            public class ListBasicAccelerateIpsResponseBodyAccelerateIpsEndpoint : TeaModel {
                [NameInMap("EndPointId")]
                [Validation(Required=false)]
                public string EndPointId { get; set; }

                [NameInMap("EndpointAddress")]
                [Validation(Required=false)]
                public string EndpointAddress { get; set; }

                [NameInMap("EndpointGroupId")]
                [Validation(Required=false)]
                public string EndpointGroupId { get; set; }

                [NameInMap("EndpointSubAddress")]
                [Validation(Required=false)]
                public string EndpointSubAddress { get; set; }

                [NameInMap("EndpointSubAddressType")]
                [Validation(Required=false)]
                public string EndpointSubAddressType { get; set; }

                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                [NameInMap("EndpointZoneId")]
                [Validation(Required=false)]
                public string EndpointZoneId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
