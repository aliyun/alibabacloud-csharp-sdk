// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListResourceGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupList")]
        [Validation(Required=false)]
        public ListResourceGroupResponseBodyResourceGroupList ResourceGroupList { get; set; }
        public class ListResourceGroupResponseBodyResourceGroupList : TeaModel {
            [NameInMap("ResGroupEntity")]
            [Validation(Required=false)]
            public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntity> ResGroupEntity { get; set; }
            public class ListResourceGroupResponseBodyResourceGroupListResGroupEntity : TeaModel {
                public string AdminUserId { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public string RegionId { get; set; }
                public ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbList SlbList { get; set; }
                public class ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbList : TeaModel {
                    [NameInMap("SlbEntity")]
                    [Validation(Required=false)]
                    public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbListSlbEntity> SlbEntity { get; set; }
                    public class ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbListSlbEntity : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public int? GroupId { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("SlbId")]
                        [Validation(Required=false)]
                        public string SlbId { get; set; }

                        [NameInMap("SlbName")]
                        [Validation(Required=false)]
                        public string SlbName { get; set; }

                        [NameInMap("SlbStatus")]
                        [Validation(Required=false)]
                        public string SlbStatus { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                    }

                }
                public long? UpdateTime { get; set; }
                public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsList EcsList { get; set; }
                public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsList : TeaModel {
                    [NameInMap("EcsEntity")]
                    [Validation(Required=false)]
                    public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntity> EcsEntity { get; set; }
                    public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntity : TeaModel {
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public int? Cpu { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("EcuEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity EcuEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity : TeaModel {
                            [NameInMap("AvailableCpu")]
                            [Validation(Required=false)]
                            public int? AvailableCpu { get; set; }
                            [NameInMap("AvailableMem")]
                            [Validation(Required=false)]
                            public int? AvailableMem { get; set; }
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }
                            [NameInMap("CreateTime")]
                            [Validation(Required=false)]
                            public long? CreateTime { get; set; }
                            [NameInMap("DockerEnv")]
                            [Validation(Required=false)]
                            public bool? DockerEnv { get; set; }
                            [NameInMap("EcuId")]
                            [Validation(Required=false)]
                            public string EcuId { get; set; }
                            [NameInMap("HeartbeatTime")]
                            [Validation(Required=false)]
                            public long? HeartbeatTime { get; set; }
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }
                            [NameInMap("IpAddr")]
                            [Validation(Required=false)]
                            public string IpAddr { get; set; }
                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("Online")]
                            [Validation(Required=false)]
                            public bool? Online { get; set; }
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }
                            [NameInMap("UpdateTime")]
                            [Validation(Required=false)]
                            public long? UpdateTime { get; set; }
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public string ZoneId { get; set; }
                        };

                        [NameInMap("Eip")]
                        [Validation(Required=false)]
                        public string Eip { get; set; }

                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        [NameInMap("HostName")]
                        [Validation(Required=false)]
                        public string HostName { get; set; }

                        [NameInMap("InnerIp")]
                        [Validation(Required=false)]
                        public string InnerIp { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        [NameInMap("Mem")]
                        [Validation(Required=false)]
                        public int? Mem { get; set; }

                        [NameInMap("PrivateIp")]
                        [Validation(Required=false)]
                        public string PrivateIp { get; set; }

                        [NameInMap("PublicIp")]
                        [Validation(Required=false)]
                        public string PublicIp { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("SerialNum")]
                        [Validation(Required=false)]
                        public string SerialNum { get; set; }

                        [NameInMap("SgId")]
                        [Validation(Required=false)]
                        public string SgId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        [NameInMap("VpcEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity VpcEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity : TeaModel {
                            [NameInMap("Cidrblock")]
                            [Validation(Required=false)]
                            public string Cidrblock { get; set; }
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }
                            [NameInMap("EcsNum")]
                            [Validation(Required=false)]
                            public int? EcsNum { get; set; }
                            [NameInMap("Expired")]
                            [Validation(Required=false)]
                            public bool? Expired { get; set; }
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }
                            [NameInMap("VpcName")]
                            [Validation(Required=false)]
                            public string VpcName { get; set; }
                        };

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }
            }
        };

    }

}
