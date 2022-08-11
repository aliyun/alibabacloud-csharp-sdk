// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("docker_version")]
        [Validation(Required=false)]
        public string DockerVersion { get; set; }

        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        public string ExternalLoadbalancerId { get; set; }

        [NameInMap("init_version")]
        [Validation(Required=false)]
        public string InitVersion { get; set; }

        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        [NameInMap("meta_data")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("network_mode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        [NameInMap("private_zone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        public string SubnetCidr { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

        [NameInMap("vpc_id")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("worker_ram_role_name")]
        [Validation(Required=false)]
        public string WorkerRamRoleName { get; set; }

        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
