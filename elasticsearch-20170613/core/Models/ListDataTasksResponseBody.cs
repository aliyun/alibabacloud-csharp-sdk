// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataTasksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataTasksResponseBodyResult> Result { get; set; }
        public class ListDataTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the site monitoring task was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The information of the target cluster.
            /// </summary>
            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSinkCluster SinkCluster { get; set; }
            public class ListDataTasksResponseBodyResultSinkCluster : TeaModel {
                /// <summary>
                /// The type of the target cluster. Default value: elasticsearch.
                /// </summary>
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// The public network access address of the target cluster.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The target index.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The type of the destination index.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the VPC to which the cluster belongs.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The instance ID or Server Load Balancer (SLB) ID of the current cluster.
                /// </summary>
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

                /// <summary>
                /// The access port number of the cluster.
                /// </summary>
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public string VpcInstancePort { get; set; }

            }

            /// <summary>
            /// The information about the source cluster.
            /// </summary>
            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSourceCluster SourceCluster { get; set; }
            public class ListDataTasksResponseBodyResultSourceCluster : TeaModel {
                /// <summary>
                /// The type of the source cluster. Default value: elasticsearch.
                /// </summary>
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// The index whose data you want to migrate.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The Mapping configuration of the cluster.
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// The routing field to index the table. It is set to the primary key by default.
                /// </summary>
                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }

                /// <summary>
                /// The Settings of the cluster.
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// The type of the destination index.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The status of the task.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
