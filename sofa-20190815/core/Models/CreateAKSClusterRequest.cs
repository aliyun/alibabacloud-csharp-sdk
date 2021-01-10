// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSClusterRequest : TeaModel {
        [NameInMap("AlsProjectHowCreate")]
        [Validation(Required=false)]
        public string AlsProjectHowCreate { get; set; }

        [NameInMap("AlsProjectName")]
        [Validation(Required=false)]
        public string AlsProjectName { get; set; }

        [NameInMap("ClusterPackageSuitVersionName")]
        [Validation(Required=false)]
        public string ClusterPackageSuitVersionName { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        [NameInMap("EnableMonitoring")]
        [Validation(Required=false)]
        public bool? EnableMonitoring { get; set; }

        [NameInMap("EnableSofaMesh")]
        [Validation(Required=false)]
        public bool? EnableSofaMesh { get; set; }

        [NameInMap("ExistingSecuredGroupIds")]
        [Validation(Required=false)]
        public string ExistingSecuredGroupIds { get; set; }

        [NameInMap("ExistingVpcId")]
        [Validation(Required=false)]
        public string ExistingVpcId { get; set; }

        [NameInMap("MaxPodAmountPerNode")]
        [Validation(Required=false)]
        public long? MaxPodAmountPerNode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("PodIpRange")]
        [Validation(Required=false)]
        public string PodIpRange { get; set; }

        [NameInMap("ServiceIpRange")]
        [Validation(Required=false)]
        public string ServiceIpRange { get; set; }

        [NameInMap("UserLoginName")]
        [Validation(Required=false)]
        public string UserLoginName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("NodeSpecs")]
        [Validation(Required=false)]
        public List<CreateAKSClusterRequestNodeSpecs> NodeSpecs { get; set; }
        public class CreateAKSClusterRequestNodeSpecs : TeaModel {
            [NameInMap("ComputerSpecId")]
            [Validation(Required=false)]
            public string ComputerSpecId { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("VswicthId")]
            [Validation(Required=false)]
            public string VswicthId { get; set; }

            [NameInMap("NamePrefix")]
            [Validation(Required=false)]
            public string NamePrefix { get; set; }

            [NameInMap("SystemDiskSpecId")]
            [Validation(Required=false)]
            public string SystemDiskSpecId { get; set; }

            [NameInMap("DataDiskSpecId")]
            [Validation(Required=false)]
            public string DataDiskSpecId { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            [NameInMap("Cell")]
            [Validation(Required=false)]
            public string Cell { get; set; }

            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ZoneToVswitchIds")]
        [Validation(Required=false)]
        public List<CreateAKSClusterRequestZoneToVswitchIds> ZoneToVswitchIds { get; set; }
        public class CreateAKSClusterRequestZoneToVswitchIds : TeaModel {
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
