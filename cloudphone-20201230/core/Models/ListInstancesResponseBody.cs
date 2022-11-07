// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstances Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstancesInstance : TeaModel {
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                [NameInMap("OsNameEn")]
                [Validation(Required=false)]
                public string OsNameEn { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class ListInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcAttributes")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                [NameInMap("WebRtcToken")]
                [Validation(Required=false)]
                public string WebRtcToken { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

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
