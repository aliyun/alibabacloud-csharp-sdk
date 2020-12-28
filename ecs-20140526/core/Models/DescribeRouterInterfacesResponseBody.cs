// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRouterInterfacesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RouterInterfaceSet")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSet> RouterInterfaceSet { get; set; }
        public class DescribeRouterInterfacesResponseBodyRouterInterfaceSet : TeaModel {
            [NameInMap("HealthCheckTargetIp")]
            [Validation(Required=false)]
            public string HealthCheckTargetIp { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("OppositeInterfaceId")]
            [Validation(Required=false)]
            public string OppositeInterfaceId { get; set; }

            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("OppositeRouterType")]
            [Validation(Required=false)]
            public string OppositeRouterType { get; set; }

            [NameInMap("OppositeInterfaceOwnerId")]
            [Validation(Required=false)]
            public string OppositeInterfaceOwnerId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OppositeRouterId")]
            [Validation(Required=false)]
            public string OppositeRouterId { get; set; }

            [NameInMap("OppositeInterfaceSpec")]
            [Validation(Required=false)]
            public string OppositeInterfaceSpec { get; set; }

            [NameInMap("RouterId")]
            [Validation(Required=false)]
            public string RouterId { get; set; }

            [NameInMap("OppositeInterfaceBusinessStatus")]
            [Validation(Required=false)]
            public string OppositeInterfaceBusinessStatus { get; set; }

            [NameInMap("ConnectedTime")]
            [Validation(Required=false)]
            public string ConnectedTime { get; set; }

            [NameInMap("HealthCheckSourceIp")]
            [Validation(Required=false)]
            public string HealthCheckSourceIp { get; set; }

            [NameInMap("OppositeInterfaceStatus")]
            [Validation(Required=false)]
            public string OppositeInterfaceStatus { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("OppositeRegionId")]
            [Validation(Required=false)]
            public string OppositeRegionId { get; set; }

            [NameInMap("OppositeAccessPointId")]
            [Validation(Required=false)]
            public string OppositeAccessPointId { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("RouterType")]
            [Validation(Required=false)]
            public string RouterType { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

        }

    }

}
