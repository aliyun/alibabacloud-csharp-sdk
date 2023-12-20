// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData Data { get; set; }
        public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData : TeaModel {
            /// <summary>
            /// The queried Prometheus instances.
            /// </summary>
            [NameInMap("PrometheusInstances")]
            [Validation(Required=false)]
            public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances> PrometheusInstances { get; set; }
            public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances : TeaModel {
                /// <summary>
                /// Auth Token string.
                /// </summary>
                [NameInMap("AuthToken")]
                [Validation(Required=false)]
                public string AuthToken { get; set; }

                /// <summary>
                /// The ID of the Prometheus instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the Prometheus instance.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The type of the cluster. Valid values: remote-write: Prometheus instance for remote write.
                /// 
                /// *   ecs: Prometheus instances for ECS.
                /// *   cloud-monitor: Prometheus instance for Alibaba Cloud services in the Chinese mainland.
                /// *   cloud-product: Prometheus instance for Alibaba Cloud services outside China.
                /// *   global-view: Prometheus instance for GlobalView.
                /// *   aliyun-cs: Prometheus instance for Container Service.
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
                /// HTTP Api internet url.
                /// </summary>
                [NameInMap("HttpApiInterUrl")]
                [Validation(Required=false)]
                public string HttpApiInterUrl { get; set; }

                /// <summary>
                /// HTTP Api intranet url.
                /// </summary>
                [NameInMap("HttpApiIntraUrl")]
                [Validation(Required=false)]
                public string HttpApiIntraUrl { get; set; }

                /// <summary>
                /// The billing method. Valid values:
                /// 
                /// *   PREPAY: subscription.
                /// *   POSTPAY: pay-as-you-go.
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// Push Gateway internet url.
                /// </summary>
                [NameInMap("PushGatewayInterUrl")]
                [Validation(Required=false)]
                public string PushGatewayInterUrl { get; set; }

                /// <summary>
                /// Push Gateway intranet url.
                /// </summary>
                [NameInMap("PushGatewayIntraUrl")]
                [Validation(Required=false)]
                public string PushGatewayIntraUrl { get; set; }

                /// <summary>
                /// The region ID of the Prometheus instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Remote Read internet url.
                /// </summary>
                [NameInMap("RemoteReadInterUrl")]
                [Validation(Required=false)]
                public string RemoteReadInterUrl { get; set; }

                /// <summary>
                /// Remote Read intranet url.
                /// </summary>
                [NameInMap("RemoteReadIntraUrl")]
                [Validation(Required=false)]
                public string RemoteReadIntraUrl { get; set; }

                /// <summary>
                /// Remote Write internet url.
                /// </summary>
                [NameInMap("RemoteWriteInterUrl")]
                [Validation(Required=false)]
                public string RemoteWriteInterUrl { get; set; }

                /// <summary>
                /// Remote Write intranet url.
                /// </summary>
                [NameInMap("RemoteWriteIntraUrl")]
                [Validation(Required=false)]
                public string RemoteWriteIntraUrl { get; set; }

                /// <summary>
                /// The ID of the resource group to which the Prometheus instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Resource type.
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
                /// The child instances of the Prometheus instance for GlobalView instance. The value is a JSON string.
                /// </summary>
                [NameInMap("SubClustersJson")]
                [Validation(Required=false)]
                public string SubClustersJson { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags> Tags { get; set; }
                public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags : TeaModel {
                    /// <summary>
                    /// The key of the tag.
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// The ID of the user.
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
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
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
