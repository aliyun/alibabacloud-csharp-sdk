// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentsResponseBodyData Data { get; set; }
        public class ListEnvironmentsResponseBodyData : TeaModel {
            /// <summary>
            /// The queried environments.
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListEnvironmentsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListEnvironmentsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// The add-ons.
                /// </summary>
                [NameInMap("Addons")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsAddons> Addons { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsAddons : TeaModel {
                    /// <summary>
                    /// The alias of the add-on.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The description of the add-on.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The URL of the icon.
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// The name of the add-on.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The ID of the resource bound to the environment instance. The resource can be a Kubernetes cluster or a VPC.
                /// </summary>
                [NameInMap("BindResourceId")]
                [Validation(Required=false)]
                public string BindResourceId { get; set; }

                /// <summary>
                /// The profile that is bound to the resource.
                /// </summary>
                [NameInMap("BindResourceProfile")]
                [Validation(Required=false)]
                public string BindResourceProfile { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("BindResourceType")]
                [Validation(Required=false)]
                public string BindResourceType { get; set; }

                /// <summary>
                /// The CIDR block that is bound to the VPC.
                /// </summary>
                [NameInMap("BindVpcCidr")]
                [Validation(Required=false)]
                public string BindVpcCidr { get; set; }

                /// <summary>
                /// The time when the environment instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("CreatedUserId")]
                [Validation(Required=false)]
                public string CreatedUserId { get; set; }

                /// <summary>
                /// The ID of the environment instance.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// The name of the environment instance.
                /// </summary>
                [NameInMap("EnvironmentName")]
                [Validation(Required=false)]
                public string EnvironmentName { get; set; }

                /// <summary>
                /// The type of the environment instance. Valid values:
                /// 
                /// *   CS: Container Service
                /// *   ECS: Elastic Compute Service
                /// *   Cloud: cloud service
                /// </summary>
                [NameInMap("EnvironmentType")]
                [Validation(Required=false)]
                public string EnvironmentType { get; set; }

                /// <summary>
                /// The parameters of the feature.
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsFeatures> Features { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsFeatures : TeaModel {
                    /// <summary>
                    /// The alias of the feature.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The description of the feature.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The URL of the icon.
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// The name of the feature.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The payable resource plan.
                /// 
                /// *   If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro.
                /// *   Otherwise, leave the parameter empty.
                /// </summary>
                [NameInMap("FeePackage")]
                [Validation(Required=false)]
                public string FeePackage { get; set; }

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
                /// The time when the last add-on was created.
                /// </summary>
                [NameInMap("LatestReleaseCreateTime")]
                [Validation(Required=false)]
                public string LatestReleaseCreateTime { get; set; }

                /// <summary>
                /// Indicates whether agents or exporters are managed. Valid values:
                /// 
                /// *   none: No. By default, no managed agents or exporters are provided for ACK clusters.
                /// *   agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.
                /// *   agent-exproter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.
                /// </summary>
                [NameInMap("ManagedType")]
                [Validation(Required=false)]
                public string ManagedType { get; set; }

                /// <summary>
                /// The Prometheus ID.
                /// </summary>
                [NameInMap("PrometheusId")]
                [Validation(Required=false)]
                public long? PrometheusId { get; set; }

                /// <summary>
                /// The ID of the Prometheus instance.
                /// </summary>
                [NameInMap("PrometheusInstanceId")]
                [Validation(Required=false)]
                public string PrometheusInstanceId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of installed add-ons.
                /// </summary>
                [NameInMap("ReleaseCount")]
                [Validation(Required=false)]
                public int? ReleaseCount { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tags of the environment resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsTags> Tags { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
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

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
