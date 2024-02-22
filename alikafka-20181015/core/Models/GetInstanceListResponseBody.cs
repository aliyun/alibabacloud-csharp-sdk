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

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                [NameInMap("UpgradeServiceDetailInfo")]
                [Validation(Required=false)]
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

                /// <summary>
                /// VSwitch ID。
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// VPC ID。
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
