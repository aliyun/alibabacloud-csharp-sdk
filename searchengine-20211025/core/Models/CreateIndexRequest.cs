// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateIndexRequest : TeaModel {
        /// <summary>
        /// The maximum number of full indexes that can be concurrently built.
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// The index schema.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// The information about the data source. This parameter is required for an OpenSearch Vector Search Edition instance of the new version.
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public CreateIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class CreateIndexRequestDataSourceInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable automatic full indexing.
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
                /// The name of the OSS bucket.
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The endpoint of the MaxCompute or Object Storage Service (OSS) data source.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The namespace name.
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The path of the OSS object.
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// The partition in the MaxCompute table. This parameter is required if type is set to odps.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// The path of the Apsara File Storage for HDFS data source.
                /// </summary>
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
                /// The table name.
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The start timestamp from which incremental data is retrieved.
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// The data center in which the data source is deployed.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The maximum number of full indexes that can be concurrently processed.
            /// </summary>
            [NameInMap("processParallelNum")]
            [Validation(Required=false)]
            public int? ProcessParallelNum { get; set; }

            /// <summary>
            /// The number of resources used for data update.
            /// </summary>
            [NameInMap("processPartitionCount")]
            [Validation(Required=false)]
            public int? ProcessPartitionCount { get; set; }

            /// <summary>
            /// The configurations of the SARO data source.
            /// </summary>
            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public CreateIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class CreateIndexRequestDataSourceInfoSaroConfig : TeaModel {
                /// <summary>
                /// The namespace of the SARO data source.
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The name of the SARO table.
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   odps
            /// *   swift
            /// *   saro
            /// *   oss
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The data center in which the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The extended content of the field configuration. key specifies the vector field and the field that requires embedding.
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        /// <summary>
        /// The maximum number of full indexes that can be concurrently merged.
        /// </summary>
        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        /// <summary>
        /// The index name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of data shards.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. The system only checks the validity of the data source. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
