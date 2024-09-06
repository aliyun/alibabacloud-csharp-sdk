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
        /// The returned message.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusInstanceResponseBodyData Data { get; set; }
        public class GetPrometheusInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The permission type. Valid values: readWrite, readOnly, and httpReadOnly
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// The number of days for which data is automatically archived after the storage duration expires. Valid values: 60, 90, 180, and 365. 0 indicates that the data is not archived.
            /// </summary>
            [NameInMap("ArchiveDuration")]
            [Validation(Required=false)]
            public int? ArchiveDuration { get; set; }

            /// <summary>
            /// Read the whitelist policy for password-free addresses.
            /// </summary>
            [NameInMap("AuthFreeReadPolicy")]
            [Validation(Required=false)]
            public string AuthFreeReadPolicy { get; set; }

            /// <summary>
            /// Write exempt password address whitelist policy.
            /// </summary>
            [NameInMap("AuthFreeWritePolicy")]
            [Validation(Required=false)]
            public string AuthFreeWritePolicy { get; set; }

            /// <summary>
            /// The authorization token.
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
            /// The name of the monitoring object.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// *   remote-write: general-purpose Prometheus instance
            /// *   ecs: Prometheus instances for ECS
            /// *   cloud-monitor: Prometheus instance for Alibaba Cloud services in the Chinese mainland
            /// *   cloud-product: Prometheus instance for Alibaba Cloud services outside the Chinese mainland
            /// *   global-view: global aggregation instance
            /// *   aliyun-cs: Prometheus instance for Container Service
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The data storage status at the backend.
            /// </summary>
            [NameInMap("DbInstanceStatus")]
            [Validation(Required=false)]
            public string DbInstanceStatus { get; set; }

            /// <summary>
            /// Whether to enable password-free reading.
            /// </summary>
            [NameInMap("EnableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// Whether to enable write access without password.
            /// </summary>
            [NameInMap("EnableAuthFreeWrite")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeWrite { get; set; }

            /// <summary>
            /// Indicates whether access token authentication is enabled.
            /// </summary>
            [NameInMap("EnableAuthToken")]
            [Validation(Required=false)]
            public string EnableAuthToken { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            /// <summary>
            /// The ID of the Grafana workspace.
            /// </summary>
            [NameInMap("GrafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// The public URL for the HTTP API.
            /// </summary>
            [NameInMap("HttpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// The internal URL for the HTTP API.
            /// </summary>
            [NameInMap("HttpApiIntraUrl")]
            [Validation(Required=false)]
            public string HttpApiIntraUrl { get; set; }

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
            /// The product to which the Prometheus instance belongs. Valid values: arms and cms.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The public URL for Pushgateway.
            /// </summary>
            [NameInMap("PushGatewayInterUrl")]
            [Validation(Required=false)]
            public string PushGatewayInterUrl { get; set; }

            /// <summary>
            /// The internal URL for Pushgateway.
            /// </summary>
            [NameInMap("PushGatewayIntraUrl")]
            [Validation(Required=false)]
            public string PushGatewayIntraUrl { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The public URL for remote read.
            /// </summary>
            [NameInMap("RemoteReadInterUrl")]
            [Validation(Required=false)]
            public string RemoteReadInterUrl { get; set; }

            /// <summary>
            /// The internal URL for remote read.
            /// </summary>
            [NameInMap("RemoteReadIntraUrl")]
            [Validation(Required=false)]
            public string RemoteReadIntraUrl { get; set; }

            /// <summary>
            /// The public URL for remote write.
            /// </summary>
            [NameInMap("RemoteWriteInterUrl")]
            [Validation(Required=false)]
            public string RemoteWriteInterUrl { get; set; }

            /// <summary>
            /// The internal URL for remote write.
            /// </summary>
            [NameInMap("RemoteWriteIntraUrl")]
            [Validation(Required=false)]
            public string RemoteWriteIntraUrl { get; set; }

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
            /// The ID of the security group. This parameter is returned only for Prometheus instances for ECS.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The data storage duration. Unit: days.
            /// </summary>
            [NameInMap("StorageDuration")]
            [Validation(Required=false)]
            public int? StorageDuration { get; set; }

            /// <summary>
            /// The child instances of the Prometheus instance for GlobalView. The value is a JSON string.
            /// </summary>
            [NameInMap("SubClustersJson")]
            [Validation(Required=false)]
            public string SubClustersJson { get; set; }

            /// <summary>
            /// Supported authentication types.
            /// </summary>
            [NameInMap("SupportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// The tags of the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetPrometheusInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetPrometheusInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
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
            /// The vSwitch ID. This parameter is returned only for Prometheus instances for ECS.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The VPC ID. This parameter is returned only for Prometheus instances for ECS.
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
