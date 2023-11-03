// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// The status code or error code.
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
            /// Resource instance ID bound to the environment, including container instance ID or VpcId.
            /// </summary>
            [NameInMap("BindResourceId")]
            [Validation(Required=false)]
            public string BindResourceId { get; set; }

            /// <summary>
            /// Profile of bound resources.
            /// </summary>
            [NameInMap("BindResourceProfile")]
            [Validation(Required=false)]
            public string BindResourceProfile { get; set; }

            /// <summary>
            /// The state of the bound resource.
            /// </summary>
            [NameInMap("BindResourceStatus")]
            [Validation(Required=false)]
            public string BindResourceStatus { get; set; }

            /// <summary>
            /// The storage duration of bound resources (days).
            /// </summary>
            [NameInMap("BindResourceStoreDuration")]
            [Validation(Required=false)]
            public string BindResourceStoreDuration { get; set; }

            /// <summary>
            /// The bound resource type.
            /// </summary>
            [NameInMap("BindResourceType")]
            [Validation(Required=false)]
            public string BindResourceType { get; set; }

            /// <summary>
            /// Bind the network segment of the vpc.
            /// </summary>
            [NameInMap("BindVpcCidr")]
            [Validation(Required=false)]
            public string BindVpcCidr { get; set; }

            /// <summary>
            /// Environment instance ID.
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

            [NameInMap("EnvironmentSubType")]
            [Validation(Required=false)]
            public string EnvironmentSubType { get; set; }

            /// <summary>
            /// Environment type:
            /// - CS: Container Service.
            /// - ECS.
            /// - Cloud: cloud service.
            /// </summary>
            [NameInMap("EnvironmentType")]
            [Validation(Required=false)]
            public string EnvironmentType { get; set; }

            /// <summary>
            /// Grafana data source name.
            /// </summary>
            [NameInMap("GrafaDataSourceName")]
            [Validation(Required=false)]
            public string GrafaDataSourceName { get; set; }

            /// <summary>
            /// Grafana data source unique ID.
            /// </summary>
            [NameInMap("GrafanaDatasourceUid")]
            [Validation(Required=false)]
            public string GrafanaDatasourceUid { get; set; }

            /// <summary>
            /// Grafana directory name.
            /// </summary>
            [NameInMap("GrafanaFolderTitle")]
            [Validation(Required=false)]
            public string GrafanaFolderTitle { get; set; }

            /// <summary>
            /// Grafana directory unique ID.
            /// </summary>
            [NameInMap("GrafanaFolderUid")]
            [Validation(Required=false)]
            public string GrafanaFolderUid { get; set; }

            /// <summary>
            /// Grafana directory URL.
            /// </summary>
            [NameInMap("GrafanaFolderUrl")]
            [Validation(Required=false)]
            public string GrafanaFolderUrl { get; set; }

            /// <summary>
            /// The bound prometheus instance ID.
            /// </summary>
            [NameInMap("PrometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// The name of the bound prometheus instance.
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
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// UserId.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
