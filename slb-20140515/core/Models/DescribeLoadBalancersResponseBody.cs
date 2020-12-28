// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
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

        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public long? CreateTimeStamp { get; set; }

            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ModificationProtectionReason")]
            [Validation(Required=false)]
            public string ModificationProtectionReason { get; set; }

            [NameInMap("ModificationProtectionStatus")]
            [Validation(Required=false)]
            public string ModificationProtectionStatus { get; set; }

            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("SlaveZoneId")]
            [Validation(Required=false)]
            public string SlaveZoneId { get; set; }

            [NameInMap("RegionIdAlias")]
            [Validation(Required=false)]
            public string RegionIdAlias { get; set; }

            [NameInMap("MasterZoneId")]
            [Validation(Required=false)]
            public string MasterZoneId { get; set; }

        }

    }

}
