// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("EcsOrder")]
        [Validation(Required=false)]
        public CreateClusterRequestEcsOrder EcsOrder { get; set; }
        public class CreateClusterRequestEcsOrder : TeaModel {
            [NameInMap("Compute")]
            [Validation(Required=true)]
            public CreateClusterRequestEcsOrderCompute Compute { get; set; }
            public class CreateClusterRequestEcsOrderCompute : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Login")]
            [Validation(Required=true)]
            public CreateClusterRequestEcsOrderLogin Login { get; set; }
            public class CreateClusterRequestEcsOrderLogin : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Manager")]
            [Validation(Required=true)]
            public CreateClusterRequestEcsOrderManager Manager { get; set; }
            public class CreateClusterRequestEcsOrderManager : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

        }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("Application")]
        [Validation(Required=false)]
        public List<CreateClusterRequestApplication> Application { get; set; }
        public class CreateClusterRequestApplication : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        [NameInMap("HaEnable")]
        [Validation(Required=false)]
        public bool? HaEnable { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RemoteDirectory")]
        [Validation(Required=false)]
        public string RemoteDirectory { get; set; }

        [NameInMap("SccClusterId")]
        [Validation(Required=false)]
        public string SccClusterId { get; set; }

        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

        [NameInMap("VolumeMountpoint")]
        [Validation(Required=false)]
        public string VolumeMountpoint { get; set; }

        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

        [NameInMap("VolumeType")]
        [Validation(Required=false)]
        public string VolumeType { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
