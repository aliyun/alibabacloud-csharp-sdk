// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// The cluster ID. This parameter is required if you set the ClusterType parameter to aliyun-cs��.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster. This parameter is required if you set the ClusterType parameter to remote-write, ecs, or global-view.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The type of the Prometheus instance. The following types are provided: remote-write (Prometheus instance for Remote Write) ecs (Prometheus instance for ECS) cloud-monitor� (Prometheus instance for Alibaba Cloud services in China) cloud-product (Prometheus instance for Alibaba Cloud services outside China) global-view (Prometheus instance for GlobalView) aliyun-cs�� (Prometheus instances for Container Service)
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The ID of the Grafana dedicated instance. This parameter is available if you set the ClusterType parameter to ecs.
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        [NameInMap("ParamJson")]
        [Validation(Required=false)]
        public string ParamJson { get; set; }

        /// <summary>
        /// The region ID. If you create a Prometheus instance for cloud services in China, set the value to cn-shanghai.
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
        /// The security group. This parameter is required if you set the clusterType parameter to ecs or create an ASK managed cluster.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The child instances of the global aggregation instance. The value is a JSON string.
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
        /// The vSwitch. This parameter is required if you set the clusterType parameter to ecs or create an ASK managed cluster.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC). This parameter is required if you set the clusterType parameter to ecs or create a serverless Kubernetes (ASK) managed cluster.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
