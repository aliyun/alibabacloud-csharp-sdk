// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexRequest : TeaModel {
        /// <summary>
        /// The maximum number of full indexes that can be concurrently built.
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// The cluster information.
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Cluster { get; set; }

        /// <summary>
        /// The name of the configuration file.
        /// </summary>
        [NameInMap("clusterConfigName")]
        [Validation(Required=false)]
        public string ClusterConfigName { get; set; }

        /// <summary>
        /// The information about the offline configuration.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, ConfigValue> Config { get; set; }

        /// <summary>
        /// The file content.
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
        /// The information about the data source, which is required for the new version of OpenSearch Vector Search Edition.
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public ModifyIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class ModifyIndexRequestDataSourceInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable the automatic full indexing feature.
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// The reindexing method. Valid values: api: API data source. indexRecover: data recovery by using indexing.
            /// </summary>
            [NameInMap("buildMode")]
            [Validation(Required=false)]
            public string BuildMode { get; set; }

            /// <summary>
            /// The configurations of the MaxCompute data source.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoConfig Config { get; set; }
            public class ModifyIndexRequestDataSourceInfoConfig : TeaModel {
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
                /// The endpoint of the MaxCompute data source.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The namespace. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The Object Storage Service (OSS) path.
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// The partition in the MaxCompute table. Example: ds=20180102.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// The file path in the Apsara File Storage for HDFS file system.
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
                /// The name of the MaxCompute table that is used as the data source.
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
            /// The offline deployment name of the data source.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The ID of the index version from which data is restored.
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

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
            public ModifyIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class ModifyIndexRequestDataSourceInfoSaroConfig : TeaModel {
                /// <summary>
                /// The namespace to which the SARO data source belongs.
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
            /// The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The description of the data source.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the data center in which the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

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
        /// The number of shards.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// The push mode of the configuration. By default, only the configuration is pushed.
        /// </summary>
        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

        /// <summary>
        /// Specifies whether to check the validity of input parameters. Default value: false.
        /// 
        /// Valid values:
        /// 
        /// *   **true**: checks only the validity of input parameters.
        /// *   **false**: checks the validity of input parameters and creates an attribution configuration.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
