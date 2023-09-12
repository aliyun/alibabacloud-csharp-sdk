// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusInstanceResponseBodyData Data { get; set; }
        public class GetPrometheusInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Prometheus instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the monitoring object.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// *   remote-write: Prometheus instance for Remote Write
            /// *   ecs: Prometheus instances for ECS
            /// *   cloud-monitor: Prometheus instance for cloud services (Chinese mainland)
            /// *   cloud-monitor: Prometheus instance for cloud services (regions outside the Chinese mainland)
            /// *   global-view: Prometheus instance for GlobalView
            /// *   aliyun-cs: Prometheus instance for Container Service
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The ID of the Grafana workspace.
            /// </summary>
            [NameInMap("GrafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// The billing method. Valid values:
            /// 
            /// *   PREPAY: subscription
            /// *   POSTPAY: pay-as-you-go
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the resource. Set the value to PROMETHEUS.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the security group.
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
            /// The tags of the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetPrometheusInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetPrometheusInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key of the instance.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the instance.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) where the monitoring object resides.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
