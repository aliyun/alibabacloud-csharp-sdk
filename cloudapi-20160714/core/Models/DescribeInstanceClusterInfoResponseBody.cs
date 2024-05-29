// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterInfoResponseBody : TeaModel {
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceClusterAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute InstanceClusterAttribute { get; set; }
        public class DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute : TeaModel {
            [NameInMap("ConnectCidrBlocks")]
            [Validation(Required=false)]
            public string ConnectCidrBlocks { get; set; }

            [NameInMap("ConnectVpcId")]
            [Validation(Required=false)]
            public string ConnectVpcId { get; set; }

            [NameInMap("EgressIpv6Enable")]
            [Validation(Required=false)]
            public bool? EgressIpv6Enable { get; set; }

            [NameInMap("HttpsPolicies")]
            [Validation(Required=false)]
            public string HttpsPolicies { get; set; }

            [NameInMap("IPV4AclId")]
            [Validation(Required=false)]
            public string IPV4AclId { get; set; }

            [NameInMap("IPV4AclName")]
            [Validation(Required=false)]
            public string IPV4AclName { get; set; }

            [NameInMap("IPV4AclStatus")]
            [Validation(Required=false)]
            public string IPV4AclStatus { get; set; }

            [NameInMap("IPV4AclType")]
            [Validation(Required=false)]
            public string IPV4AclType { get; set; }

            [NameInMap("IPV6AclId")]
            [Validation(Required=false)]
            public string IPV6AclId { get; set; }

            [NameInMap("IPV6AclName")]
            [Validation(Required=false)]
            public string IPV6AclName { get; set; }

            [NameInMap("IPV6AclStatus")]
            [Validation(Required=false)]
            public string IPV6AclStatus { get; set; }

            [NameInMap("IPV6AclType")]
            [Validation(Required=false)]
            public string IPV6AclType { get; set; }

            [NameInMap("InternetEgressAddress")]
            [Validation(Required=false)]
            public string InternetEgressAddress { get; set; }

            [NameInMap("IntranetEgressAddress")]
            [Validation(Required=false)]
            public string IntranetEgressAddress { get; set; }

            [NameInMap("IntranetSegments")]
            [Validation(Required=false)]
            public string IntranetSegments { get; set; }

            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }

            [NameInMap("UserVpcId")]
            [Validation(Required=false)]
            public string UserVpcId { get; set; }

            [NameInMap("UserVswitchId")]
            [Validation(Required=false)]
            public string UserVswitchId { get; set; }

            [NameInMap("VipTypeList")]
            [Validation(Required=false)]
            public string VipTypeList { get; set; }

            [NameInMap("VpcIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcIntranetEnable { get; set; }

            [NameInMap("VpcOwnerId")]
            [Validation(Required=false)]
            public long? VpcOwnerId { get; set; }

            [NameInMap("VpcSlbIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcSlbIntranetEnable { get; set; }

        }

        [NameInMap("InstanceClusterId")]
        [Validation(Required=false)]
        public string InstanceClusterId { get; set; }

        [NameInMap("InstanceClusterName")]
        [Validation(Required=false)]
        public string InstanceClusterName { get; set; }

        [NameInMap("InstanceClusterStatus")]
        [Validation(Required=false)]
        public string InstanceClusterStatus { get; set; }

        [NameInMap("InstanceClusterType")]
        [Validation(Required=false)]
        public string InstanceClusterType { get; set; }

        [NameInMap("InstanceClusterVersion")]
        [Validation(Required=false)]
        public string InstanceClusterVersion { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public DescribeInstanceClusterInfoResponseBodyInstanceList InstanceList { get; set; }
        public class DescribeInstanceClusterInfoResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceClusterInfoResponseBodyInstanceListInstance> Instance { get; set; }
            public class DescribeInstanceClusterInfoResponseBodyInstanceListInstance : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
