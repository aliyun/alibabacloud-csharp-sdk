// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeMigrationInstancesResponseBody : TeaModel {
        [NameInMap("MigrationInstanceSet")]
        [Validation(Required=false)]
        public DescribeMigrationInstancesResponseBodyMigrationInstanceSet MigrationInstanceSet { get; set; }
        public class DescribeMigrationInstancesResponseBodyMigrationInstanceSet : TeaModel {
            [NameInMap("MigrationInstance")]
            [Validation(Required=false)]
            public List<DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstance> MigrationInstance { get; set; }
            public class DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstance : TeaModel {
                [NameInMap("BusinessMigrationType")]
                [Validation(Required=false)]
                public string BusinessMigrationType { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("ChangePublicIp")]
                [Validation(Required=false)]
                public bool? ChangePublicIp { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("HasLocalDisk")]
                [Validation(Required=false)]
                public bool? HasLocalDisk { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("InternetIpAfterTransition")]
                [Validation(Required=false)]
                public string InternetIpAfterTransition { get; set; }

                [NameInMap("IntranetIp")]
                [Validation(Required=false)]
                public string IntranetIp { get; set; }

                [NameInMap("IntranetIpAfterTransition")]
                [Validation(Required=false)]
                public string IntranetIpAfterTransition { get; set; }

                [NameInMap("LoadProgress")]
                [Validation(Required=false)]
                public string LoadProgress { get; set; }

                [NameInMap("MacAddressAfterTransition")]
                [Validation(Required=false)]
                public string MacAddressAfterTransition { get; set; }

                [NameInMap("MergeProgress")]
                [Validation(Required=false)]
                public string MergeProgress { get; set; }

                [NameInMap("MigrationPlanId")]
                [Validation(Required=false)]
                public string MigrationPlanId { get; set; }

                [NameInMap("MigrationStatus")]
                [Validation(Required=false)]
                public string MigrationStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NetworkConnectivityStatus")]
                [Validation(Required=false)]
                public bool? NetworkConnectivityStatus { get; set; }

                [NameInMap("NetworkMigrationType")]
                [Validation(Required=false)]
                public int? NetworkMigrationType { get; set; }

                [NameInMap("NonStandardInstanceType")]
                [Validation(Required=false)]
                public bool? NonStandardInstanceType { get; set; }

                [NameInMap("PrivateMacAddress")]
                [Validation(Required=false)]
                public string PrivateMacAddress { get; set; }

                [NameInMap("PublicMacAddress")]
                [Validation(Required=false)]
                public string PublicMacAddress { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityGroupIdSets")]
                [Validation(Required=false)]
                public DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceSecurityGroupIdSets SecurityGroupIdSets { get; set; }
                public class DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceSecurityGroupIdSets : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                [NameInMap("SecurityGroupIdSetsAfterTransition")]
                [Validation(Required=false)]
                public DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceSecurityGroupIdSetsAfterTransition SecurityGroupIdSetsAfterTransition { get; set; }
                public class DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceSecurityGroupIdSetsAfterTransition : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceTags Tags { get; set; }
                public class DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceTagsTag> Tag { get; set; }
                    public class DescribeMigrationInstancesResponseBodyMigrationInstanceSetMigrationInstanceTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("TargetVSwitchId")]
                [Validation(Required=false)]
                public string TargetVSwitchId { get; set; }

                [NameInMap("TargetVpcId")]
                [Validation(Required=false)]
                public string TargetVpcId { get; set; }

                [NameInMap("TargetZoneId")]
                [Validation(Required=false)]
                public string TargetZoneId { get; set; }

                [NameInMap("TransitionTime")]
                [Validation(Required=false)]
                public string TransitionTime { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
