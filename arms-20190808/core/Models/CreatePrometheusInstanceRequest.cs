// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// Does it require all child instances to be verified successfully before creating a GlobalView instance. The default is false, which means partial success is possible.
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// The number of days for automatic archiving after storage expiration (optional values: 60, 90, 180, 365). 0 means not archive.
        /// </summary>
        [NameInMap("ArchiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// The ID of the ACK cluster. This parameter is required if you set the ClusterType parameter to aliyun-cs.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the created cluster. This parameter is required if you set the ClusterType parameter to remote-write or ecs.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The type of the cluster to which the Prometheus instance belongs. Valid values: 
        /// * remote-write: Prometheus instance for remote write.
        /// * ecs(Not supported): Prometheus instance for ECS.
        /// * cloud-monitor(Not supported): Prometheus instance for Alibaba Cloud services in China.
        /// * cloud-product(Not supported): Prometheus instance for Alibaba Cloud services outside China.
        /// * global-view: Prometheus instance for GlobalView.
        /// * aliyun-cs(Not supported): Prometheus instance for Container Service for Kubernetes (ACK).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Data storage duration (in days).
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The ID of the Grafana dedicated instance. This parameter is available if you set the ClusterType parameter to ecs.
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        /// <summary>
        /// The ID of the region. If you use a Prometheus instance to monitor an Alibaba Cloud service in China, this parameter must be set to cn-shanghai.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the custom resource group. You can configure this parameter to bind the instance to the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the security group. This parameter is required if you set the ClusterType parameter to ecs.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// JSON string for child instances of the globalView instance.
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

        /// <summary>
        /// The tags of the instance. You can configure this parameter to manage tags for the instance.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusInstanceRequestTags> Tags { get; set; }
        public class CreatePrometheusInstanceRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch. This parameter is required if you set the ClusterType parameter to ecs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of virtual private cloud (VPC). This parameter is required if you set the ClusterType parameter to ecs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
