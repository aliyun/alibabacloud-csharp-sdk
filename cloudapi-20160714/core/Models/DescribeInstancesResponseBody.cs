// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("InstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstanceAttribute> InstanceAttribute { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstanceAttribute : TeaModel {
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("ClassicEgressAddress")]
                [Validation(Required=false)]
                public string ClassicEgressAddress { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("EgressIpv6Enable")]
                [Validation(Required=false)]
                public bool? EgressIpv6Enable { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("HttpsPolicies")]
                [Validation(Required=false)]
                public string HttpsPolicies { get; set; }

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

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceRpsLimit")]
                [Validation(Required=false)]
                public int? InstanceRpsLimit { get; set; }

                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                [NameInMap("InstanceSpecAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributes InstanceSpecAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributes : TeaModel {
                    [NameInMap("SpecAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributesSpecAttribute> SpecAttribute { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributesSpecAttribute : TeaModel {
                        [NameInMap("LocalName")]
                        [Validation(Required=false)]
                        public string LocalName { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetEgressAddress")]
                [Validation(Required=false)]
                public string InternetEgressAddress { get; set; }

                [NameInMap("IntranetSegments")]
                [Validation(Required=false)]
                public string IntranetSegments { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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

                [NameInMap("VpcEgressAddress")]
                [Validation(Required=false)]
                public string VpcEgressAddress { get; set; }

                [NameInMap("VpcIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcIntranetEnable { get; set; }

                [NameInMap("VpcOwnerId")]
                [Validation(Required=false)]
                public long? VpcOwnerId { get; set; }

                [NameInMap("VpcSlbIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcSlbIntranetEnable { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneLocalName")]
                [Validation(Required=false)]
                public string ZoneLocalName { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
