// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateDataTasksResponseBody : TeaModel {
        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the source cluster.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<CreateDataTasksResponseBodyResult> Result { get; set; }
        public class CreateDataTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// The access password of the target cluster.
            /// </summary>
            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public CreateDataTasksResponseBodyResultSinkCluster SinkCluster { get; set; }
            public class CreateDataTasksResponseBodyResultSinkCluster : TeaModel {
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// The settings configuration.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The type of the target index.
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// The name of the target index.
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The username of the destination cluster.
                /// </summary>
                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }

                /// <summary>
                /// Mapping configuration.
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// The routing field. The primary key field is used by default.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the Virtual Private Cloud to which the cluster belongs. If the cluster access address is a public domain name, you can not specify the private endpoint.
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// The access port number of the cluster.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The type of the target cluster.
                /// </summary>
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

                /// <summary>
                /// The instance ID of the cluster under the Virtual Private Cloud, or the ID of the SLB instance.
                /// </summary>
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public string VpcInstancePort { get; set; }

            }

            /// <summary>
            /// The access password of the source cluster.
            /// </summary>
            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public CreateDataTasksResponseBodyResultSourceCluster SourceCluster { get; set; }
            public class CreateDataTasksResponseBodyResultSourceCluster : TeaModel {
                /// <summary>
                /// The information about the target cluster.
                /// </summary>
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// The username of the source cluster.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The type of the specified index.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// Specifies the indexes to be migrated.
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The public domain name of the cluster.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the Virtual Private Cloud where the source cluster resides. If the cluster access address is a public domain name, you can not specify the private endpoint.
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// The instance ID of the cluster under the Virtual Private Cloud, or the ID of the SLB instance.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The access port number of the source cluster.
                /// </summary>
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

                /// <summary>
                /// The type of the source cluster. Default value: Elasticsearch.
                /// </summary>
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public int? VpcInstancePort { get; set; }

            }

        }

    }

}
