// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        /// <summary>
        /// Status code: 200 indicates success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentsResponseBodyData Data { get; set; }
        public class ListEnvironmentsResponseBodyData : TeaModel {
            /// <summary>
            /// Environment list.
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListEnvironmentsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListEnvironmentsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// Addon list.
                /// </summary>
                [NameInMap("Addons")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsAddons> Addons { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsAddons : TeaModel {
                    /// <summary>
                    /// Alias of Addon.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// Description of Addon.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// Icon of Addon.
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// Name of Addon.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// Id of the resource to be bound.
                /// </summary>
                [NameInMap("BindResourceId")]
                [Validation(Required=false)]
                public string BindResourceId { get; set; }

                /// <summary>
                /// Profile of the resource to be bound.
                /// </summary>
                [NameInMap("BindResourceProfile")]
                [Validation(Required=false)]
                public string BindResourceProfile { get; set; }

                /// <summary>
                /// Type of the resource to be bound.
                /// </summary>
                [NameInMap("BindResourceType")]
                [Validation(Required=false)]
                public string BindResourceType { get; set; }

                /// <summary>
                /// Bound Vpc IP Cidr.
                /// </summary>
                [NameInMap("BindVpcCidr")]
                [Validation(Required=false)]
                public string BindVpcCidr { get; set; }

                /// <summary>
                /// Create time.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Created User ID.
                /// </summary>
                [NameInMap("CreatedUserId")]
                [Validation(Required=false)]
                public string CreatedUserId { get; set; }

                /// <summary>
                /// Environment ID.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// Environment name.
                /// </summary>
                [NameInMap("EnvironmentName")]
                [Validation(Required=false)]
                public string EnvironmentName { get; set; }

                /// <summary>
                /// Environment type.
                /// </summary>
                [NameInMap("EnvironmentType")]
                [Validation(Required=false)]
                public string EnvironmentType { get; set; }

                /// <summary>
                /// Featyre list.
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsFeatures> Features { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsFeatures : TeaModel {
                    /// <summary>
                    /// Alias of Feature.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// Description of Feature.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// Icon address.
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// Name of Feature.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// Grafana datasource UID.
                /// </summary>
                [NameInMap("GrafanaDatasourceUid")]
                [Validation(Required=false)]
                public string GrafanaDatasourceUid { get; set; }

                /// <summary>
                /// Grafana folder title.
                /// </summary>
                [NameInMap("GrafanaFolderTitle")]
                [Validation(Required=false)]
                public string GrafanaFolderTitle { get; set; }

                /// <summary>
                /// Grafana folder UID.
                /// </summary>
                [NameInMap("GrafanaFolderUid")]
                [Validation(Required=false)]
                public string GrafanaFolderUid { get; set; }

                /// <summary>
                /// Latest Release create time.
                /// </summary>
                [NameInMap("LatestReleaseCreateTime")]
                [Validation(Required=false)]
                public string LatestReleaseCreateTime { get; set; }

                /// <summary>
                /// Prometheus ID.
                /// </summary>
                [NameInMap("PrometheusId")]
                [Validation(Required=false)]
                public long? PrometheusId { get; set; }

                /// <summary>
                /// Prometheus instance ID.
                /// </summary>
                [NameInMap("PrometheusInstanceId")]
                [Validation(Required=false)]
                public string PrometheusInstanceId { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Number of Release.
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
                /// The tag value.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsTags> Tags { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsTags : TeaModel {
                    /// <summary>
                    /// Tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// Tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// User ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
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
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
