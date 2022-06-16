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
                public string ClassicEgressAddress { get; set; }
                public string CreatedTime { get; set; }
                public bool? EgressIpv6Enable { get; set; }
                public string ExpiredTime { get; set; }
                public string HttpsPolicies { get; set; }
                public string InstanceChargeType { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public int? InstanceRpsLimit { get; set; }
                public string InstanceSpec { get; set; }
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
                public string InstanceType { get; set; }
                public string InternetEgressAddress { get; set; }
                public string RegionId { get; set; }
                public string Status { get; set; }
                public bool? SupportIpv6 { get; set; }
                public string UserVpcId { get; set; }
                public string UserVswitchId { get; set; }
                public string VipTypeList { get; set; }
                public string VpcEgressAddress { get; set; }
                public bool? VpcIntranetEnable { get; set; }
                public long? VpcOwnerId { get; set; }
                public bool? VpcSlbIntranetEnable { get; set; }
                public string ZoneId { get; set; }
                public string ZoneLocalName { get; set; }
            }
        };

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
