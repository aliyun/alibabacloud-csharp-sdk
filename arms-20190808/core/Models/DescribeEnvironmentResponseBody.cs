// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvironmentResponseBodyData Data { get; set; }
        public class DescribeEnvironmentResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the resource associated with the environment, such as the ACK cluster ID or VPC ID.
            /// </summary>
            [NameInMap("BindResourceId")]
            [Validation(Required=false)]
            public string BindResourceId { get; set; }

            /// <summary>
            /// The profile of the resource.
            /// </summary>
            [NameInMap("BindResourceProfile")]
            [Validation(Required=false)]
            public string BindResourceProfile { get; set; }

            /// <summary>
            /// The status of the resource.
            /// </summary>
            [NameInMap("BindResourceStatus")]
            [Validation(Required=false)]
            public string BindResourceStatus { get; set; }

            /// <summary>
            /// The retention period of the resource. Unit: days.
            /// </summary>
            [NameInMap("BindResourceStoreDuration")]
            [Validation(Required=false)]
            public string BindResourceStoreDuration { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("BindResourceType")]
            [Validation(Required=false)]
            public string BindResourceType { get; set; }

            /// <summary>
            /// The VPC CIDR block.
            /// </summary>
            [NameInMap("BindVpcCidr")]
            [Validation(Required=false)]
            public string BindVpcCidr { get; set; }

            [NameInMap("DbInstanceStatus")]
            [Validation(Required=false)]
            public string DbInstanceStatus { get; set; }

            /// <summary>
            /// The ID of the environment instance.
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// The environment name.
            /// </summary>
            [NameInMap("EnvironmentName")]
            [Validation(Required=false)]
            public string EnvironmentName { get; set; }

            /// <summary>
            /// Environment subtypes:
            /// - CS: Currently supports ACK.
            /// - ECS: ECS is currently supported.
            /// - Cloud: Currently supports Cloud.
            /// </summary>
            [NameInMap("EnvironmentSubType")]
            [Validation(Required=false)]
            public string EnvironmentSubType { get; set; }

            /// <summary>
            /// The type of the environment. Valid values:
            /// 
            /// *   CS: Container Service for Kubernetes (ACK)
            /// *   ECS: Elastic Compute Service
            /// *   Cloud: cloud service
            /// </summary>
            [NameInMap("EnvironmentType")]
            [Validation(Required=false)]
            public string EnvironmentType { get; set; }

            /// <summary>
            /// The name of the Grafana data source.
            /// </summary>
            [NameInMap("GrafaDataSourceName")]
            [Validation(Required=false)]
            public string GrafaDataSourceName { get; set; }

            /// <summary>
            /// The unique ID of the Grafana data source.
            /// </summary>
            [NameInMap("GrafanaDatasourceUid")]
            [Validation(Required=false)]
            public string GrafanaDatasourceUid { get; set; }

            /// <summary>
            /// The name of the Grafana directory.
            /// </summary>
            [NameInMap("GrafanaFolderTitle")]
            [Validation(Required=false)]
            public string GrafanaFolderTitle { get; set; }

            /// <summary>
            /// The unique ID of the Grafana directory.
            /// </summary>
            [NameInMap("GrafanaFolderUid")]
            [Validation(Required=false)]
            public string GrafanaFolderUid { get; set; }

            /// <summary>
            /// The URL of the Grafana directory.
            /// </summary>
            [NameInMap("GrafanaFolderUrl")]
            [Validation(Required=false)]
            public string GrafanaFolderUrl { get; set; }

            /// <summary>
            /// managed type:
            /// - none: unmanaged. The default value for ACK clusters.
            /// - agent: managed agent (including KSM). The default values for ASK, ACS, and AckOne clusters.
            /// - agent-exporter: managed agent and exporters. The default value for the cloud service type.
            /// </summary>
            [NameInMap("ManagedType")]
            [Validation(Required=false)]
            public string ManagedType { get; set; }

            /// <summary>
            /// The ID of the Prometheus instance.
            /// </summary>
            [NameInMap("PrometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// The name of the Prometheus instance.
            /// </summary>
            [NameInMap("PrometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEnvironmentResponseBodyDataTags> Tags { get; set; }
            public class DescribeEnvironmentResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The VPC ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
