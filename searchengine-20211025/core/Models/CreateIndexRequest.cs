// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateIndexRequest : TeaModel {
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// The content of the index.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// Optional. The data source, which can be MaxCompute, Message Service (MNS), Realtime Compute for Apache Flink, or StreamCompute.
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// The information about the data source, which is required for the new version of OpenSearch Vector Search Edition.
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public CreateIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class CreateIndexRequestDataSourceInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable the automatic full indexing feature.
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// The information about the MaxCompute data source.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateIndexRequestDataSourceInfoConfig Config { get; set; }
            public class CreateIndexRequestDataSourceInfoConfig : TeaModel {
                /// <summary>
                /// The AccessKey ID of the MaxCompute data source.
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// The AccessKey secret of the MaxCompute data source.
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// oss bucket
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The endpoint of the MaxCompute or Object Storage Service (OSS) data source.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// The data partition. This parameter is required if type is set to odps.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The name of the MaxCompute project that is used as the data source.
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// The data center where the data source is deployed.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The name of the index.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processParallelNum")]
            [Validation(Required=false)]
            public int? ProcessParallelNum { get; set; }

            /// <summary>
            /// The number of resources used for data update.
            /// </summary>
            [NameInMap("processPartitionCount")]
            [Validation(Required=false)]
            public int? ProcessPartitionCount { get; set; }

            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public CreateIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class CreateIndexRequestDataSourceInfoSaroConfig : TeaModel {
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The type of the data source. Valid values: odps, swift, saro, and oss.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The data center in which the data source resides.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The extended configurations of the field. Keys such as vector and embedding are included. Vector indicates the vector field. Embedding indicates the field that requires embedding.
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        /// <summary>
        /// The name of the index.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The data partition.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
