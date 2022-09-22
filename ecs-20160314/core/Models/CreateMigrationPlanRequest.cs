// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateMigrationPlanRequest : TeaModel {
        [NameInMap("CustomMigrationTimes")]
        [Validation(Required=false)]
        public List<CreateMigrationPlanRequestCustomMigrationTimes> CustomMigrationTimes { get; set; }
        public class CreateMigrationPlanRequestCustomMigrationTimes : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MigrationTime")]
            [Validation(Required=false)]
            public string MigrationTime { get; set; }

        }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EnableAutoCreateVSwitch")]
        [Validation(Required=false)]
        public bool? EnableAutoCreateVSwitch { get; set; }

        [NameInMap("EnsureNetworkConnectivity")]
        [Validation(Required=false)]
        public bool? EnsureNetworkConnectivity { get; set; }

        [NameInMap("GlobalMigrationTime")]
        [Validation(Required=false)]
        public string GlobalMigrationTime { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RemainPrivateIp")]
        [Validation(Required=false)]
        public bool? RemainPrivateIp { get; set; }

        [NameInMap("RemainPublicMacAsPriority")]
        [Validation(Required=false)]
        public bool? RemainPublicMacAsPriority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TargetSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> TargetSecurityGroupIds { get; set; }

        [NameInMap("TargetVSwitchId")]
        [Validation(Required=false)]
        public string TargetVSwitchId { get; set; }

        [NameInMap("TargetVpcId")]
        [Validation(Required=false)]
        public string TargetVpcId { get; set; }

        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
