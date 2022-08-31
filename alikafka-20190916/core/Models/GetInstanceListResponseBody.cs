// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                public string AllConfig { get; set; }
                public long? CreateTime { get; set; }
                public int? DeployType { get; set; }
                public int? DiskSize { get; set; }
                public int? DiskType { get; set; }
                public string DomainEndpoint { get; set; }
                public int? EipMax { get; set; }
                public string EndPoint { get; set; }
                public long? ExpiredTime { get; set; }
                public string InstanceId { get; set; }
                public int? IoMax { get; set; }
                public string KmsKeyId { get; set; }
                public int? MsgRetain { get; set; }
                public string Name { get; set; }
                public int? PaidType { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string SaslDomainEndpoint { get; set; }
                public string SecurityGroup { get; set; }
                public int? ServiceStatus { get; set; }
                public string SpecType { get; set; }
                public string SslDomainEndpoint { get; set; }
                public string SslEndPoint { get; set; }
                public GetInstanceListResponseBodyInstanceListInstanceVOTags Tags { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO> TagVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public int? TopicNumLimit { get; set; }
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    [NameInMap("Current2OpenSourceVersion")]
                    [Validation(Required=false)]
                    public string Current2OpenSourceVersion { get; set; }

                }
                public int? UsedGroupCount { get; set; }
                public int? UsedPartitionCount { get; set; }
                public int? UsedTopicCount { get; set; }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
