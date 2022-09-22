// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeMigrationPlansResponseBody : TeaModel {
        [NameInMap("MigrationPlanSet")]
        [Validation(Required=false)]
        public DescribeMigrationPlansResponseBodyMigrationPlanSet MigrationPlanSet { get; set; }
        public class DescribeMigrationPlansResponseBodyMigrationPlanSet : TeaModel {
            [NameInMap("MigrationPlan")]
            [Validation(Required=false)]
            public List<DescribeMigrationPlansResponseBodyMigrationPlanSetMigrationPlan> MigrationPlan { get; set; }
            public class DescribeMigrationPlansResponseBodyMigrationPlanSetMigrationPlan : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EnableAutoCreateVSwitch")]
                [Validation(Required=false)]
                public bool? EnableAutoCreateVSwitch { get; set; }

                [NameInMap("EnableNetworkConnectivity")]
                [Validation(Required=false)]
                public bool? EnableNetworkConnectivity { get; set; }

                [NameInMap("FinishInstanceCount")]
                [Validation(Required=false)]
                public int? FinishInstanceCount { get; set; }

                [NameInMap("MigrationPlanId")]
                [Validation(Required=false)]
                public string MigrationPlanId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RemainPrivateIp")]
                [Validation(Required=false)]
                public bool? RemainPrivateIp { get; set; }

                [NameInMap("RemainPublicMacAsPriority")]
                [Validation(Required=false)]
                public bool? RemainPublicMacAsPriority { get; set; }

                [NameInMap("SecurityGroupNos")]
                [Validation(Required=false)]
                public DescribeMigrationPlansResponseBodyMigrationPlanSetMigrationPlanSecurityGroupNos SecurityGroupNos { get; set; }
                public class DescribeMigrationPlansResponseBodyMigrationPlanSetMigrationPlanSecurityGroupNos : TeaModel {
                    [NameInMap("SecurityGroupNo")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupNo { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetVSwitchId")]
                [Validation(Required=false)]
                public string TargetVSwitchId { get; set; }

                [NameInMap("TargetVpcId")]
                [Validation(Required=false)]
                public string TargetVpcId { get; set; }

                [NameInMap("TargetZoneId")]
                [Validation(Required=false)]
                public string TargetZoneId { get; set; }

                [NameInMap("TotalInstanceCount")]
                [Validation(Required=false)]
                public int? TotalInstanceCount { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
