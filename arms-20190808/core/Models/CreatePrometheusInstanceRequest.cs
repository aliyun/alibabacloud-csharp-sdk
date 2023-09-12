// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// 创建GlobalView时，是否要求所有子实例都校验成功时，才创建GlobalView实例。默认是false，即可以部分成功。
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// The ID of the cluster. This parameter is required if you set ClusterType to aliyun-cs��.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster. This parameter is required if you set ClusterType to remote-write, ecs, or global-view.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The type of the Prometheus instance. Valid values: remote-write: Prometheus instance for remote write. ecs: Prometheus instance for ECS. cloud-monitor�: Prometheus instance for cloud services in China. cloud-product: Prometheus instance for Alibaba Cloud services outside China. global-view: Prometheus instance for GlobalView. aliyun-cs��: Prometheus instance for Container Service.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The ID of the Grafana dedicated instance. This parameter is available if you set ClusterType to ecs.
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        /// <summary>
        /// The region ID. If you create a Prometheus instance for a cloud service in China, set this parameter to cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the custom resource group. You can specify this parameter to bind the instance to the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the security group. This parameter is required if you set ClusterType to ecs or create an ASK managed cluster.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The child instances of the Prometheus instance for GlobalView. The value is a JSON string.
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

        /// <summary>
        /// The tags of the instance. You can specify this parameter to manage tags for the instance.
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
        /// The ID of the vSwitch. This parameter is required if you set ClusterType to ecs or create an ASK managed cluster.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). This parameter is required if you set ClusterType to ecs or create a serverless Kubernetes (ASK) managed cluster.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
