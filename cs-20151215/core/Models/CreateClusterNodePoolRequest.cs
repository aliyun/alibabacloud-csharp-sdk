// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }

            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }

            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("management")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
