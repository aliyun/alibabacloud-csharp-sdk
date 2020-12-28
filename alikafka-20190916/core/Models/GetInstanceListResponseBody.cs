// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<GetInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("UpgradeServiceDetailInfo")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListUpgradeServiceDetailInfo> UpgradeServiceDetailInfo { get; set; }
            public class GetInstanceListResponseBodyInstanceListUpgradeServiceDetailInfo : TeaModel {
                [NameInMap("Current2OpenSourceVersion")]
                [Validation(Required=false)]
                public string Current2OpenSourceVersion { get; set; }

            }

            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public int? DeployType { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListTags> Tags { get; set; }
            public class GetInstanceListResponseBodyInstanceListTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public int? DiskType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SslEndPoint")]
            [Validation(Required=false)]
            public string SslEndPoint { get; set; }

            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            [NameInMap("EipMax")]
            [Validation(Required=false)]
            public int? EipMax { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("MsgRetain")]
            [Validation(Required=false)]
            public int? MsgRetain { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("TopicNumLimit")]
            [Validation(Required=false)]
            public int? TopicNumLimit { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("IoMax")]
            [Validation(Required=false)]
            public int? IoMax { get; set; }

            [NameInMap("PaidType")]
            [Validation(Required=false)]
            public int? PaidType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
