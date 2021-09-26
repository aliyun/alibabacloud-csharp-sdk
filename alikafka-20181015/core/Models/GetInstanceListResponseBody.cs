// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                public string VpcId { get; set; }
                public string VSwitchId { get; set; }
                public long? ExpiredTime { get; set; }
                public int? DeployType { get; set; }
                public long? CreateTime { get; set; }
                public string SslEndPoint { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public int? ServiceStatus { get; set; }
                public string EndPoint { get; set; }
                public string RegionId { get; set; }
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    [NameInMap("UpgradeServiceDetailInfoVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfoUpgradeServiceDetailInfoVO> UpgradeServiceDetailInfoVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfoUpgradeServiceDetailInfoVO : TeaModel {
                        [NameInMap("Current2OpenSourceVersion")]
                        [Validation(Required=false)]
                        public string Current2OpenSourceVersion { get; set; }

                    }

                }
            }
        };

    }

}
