// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRouterInterfacesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RouterInterfaceSet")]
        [Validation(Required=false)]
        public DescribeRouterInterfacesResponseBodyRouterInterfaceSet RouterInterfaceSet { get; set; }
        public class DescribeRouterInterfacesResponseBodyRouterInterfaceSet : TeaModel {
            [NameInMap("RouterInterfaceType")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType> RouterInterfaceType { get; set; }
            public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType : TeaModel {
                public string HealthCheckTargetIp { get; set; }
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string Spec { get; set; }
                public string OppositeInterfaceId { get; set; }
                public string RouterInterfaceId { get; set; }
                public string ChargeType { get; set; }
                public string OppositeRouterType { get; set; }
                public string OppositeInterfaceOwnerId { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string OppositeRouterId { get; set; }
                public string OppositeInterfaceSpec { get; set; }
                public string RouterId { get; set; }
                public string OppositeInterfaceBusinessStatus { get; set; }
                public string ConnectedTime { get; set; }
                public string OppositeInterfaceStatus { get; set; }
                public string HealthCheckSourceIp { get; set; }
                public string EndTime { get; set; }
                public string OppositeRegionId { get; set; }
                public string OppositeAccessPointId { get; set; }
                public string BusinessStatus { get; set; }
                public string Role { get; set; }
                public string RouterType { get; set; }
                public string AccessPointId { get; set; }
            }
        };

    }

}
