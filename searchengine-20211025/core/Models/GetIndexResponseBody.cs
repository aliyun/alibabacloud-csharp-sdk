// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The index information.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexResponseBodyResult Result { get; set; }
        public class GetIndexResponseBodyResult : TeaModel {
            /// <summary>
            /// The cluster information.
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public Dictionary<string, ResultClusterValue> Cluster { get; set; }

            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// The configuration that takes effect next time.
            /// </summary>
            [NameInMap("configWhenBuild")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> ConfigWhenBuild { get; set; }

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
            /// The information about the data source.
            /// </summary>
            [NameInMap("dataSourceInfo")]
            [Validation(Required=false)]
            public GetIndexResponseBodyResultDataSourceInfo DataSourceInfo { get; set; }
            public class GetIndexResponseBodyResultDataSourceInfo : TeaModel {
                /// <summary>
                /// Indicates whether the automatic full indexing feature is enabled.
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                /// <summary>
                /// The configuration of MaxCompute data sources.
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public GetIndexResponseBodyResultDataSourceInfoConfig Config { get; set; }
                public class GetIndexResponseBodyResultDataSourceInfoConfig : TeaModel {
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
                public GetIndexResponseBodyResultDataSourceInfoSaroConfig SaroConfig { get; set; }
                public class GetIndexResponseBodyResultDataSourceInfoSaroConfig : TeaModel {
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
                /// The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The description of the index version.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The deployment name of the index.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("extend")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Extend { get; set; }

            /// <summary>
            /// The time when full data in the index was last updated.
            /// </summary>
            [NameInMap("fullUpdateTime")]
            [Validation(Required=false)]
            public string FullUpdateTime { get; set; }

            /// <summary>
            /// The data version.
            /// </summary>
            [NameInMap("fullVersion")]
            [Validation(Required=false)]
            public long? FullVersion { get; set; }

            /// <summary>
            /// The time when incremental data in the index was last updated.
            /// </summary>
            [NameInMap("incUpdateTime")]
            [Validation(Required=false)]
            public string IncUpdateTime { get; set; }

            /// <summary>
            /// The index size.
            /// </summary>
            [NameInMap("indexSize")]
            [Validation(Required=false)]
            public long? IndexSize { get; set; }

            /// <summary>
            /// The status of the index version. Valid values:
            /// 
            /// *   NEW: The index version is created.
            /// *   PUBLISH: The index version is normal.
            /// *   IN_USE: The index version is in use.
            /// *   NOT_USE: The index version is not used.
            /// *   STOP_USE: The index version is being stopped.
            /// *   RESTORE_USE: The index version is being restored.
            /// *   FAIL: The index version failed to be created.
            /// </summary>
            [NameInMap("indexStatus")]
            [Validation(Required=false)]
            public string IndexStatus { get; set; }

            /// <summary>
            /// The index name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of shards.
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            /// <summary>
            /// The information about the versions.
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<GetIndexResponseBodyResultVersions> Versions { get; set; }
            public class GetIndexResponseBodyResultVersions : TeaModel {
                /// <summary>
                /// The description of the version.
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The information about the files.
                /// </summary>
                [NameInMap("files")]
                [Validation(Required=false)]
                public List<GetIndexResponseBodyResultVersionsFiles> Files { get; set; }
                public class GetIndexResponseBodyResultVersionsFiles : TeaModel {
                    /// <summary>
                    /// The full path of the file.
                    /// </summary>
                    [NameInMap("fullPathName")]
                    [Validation(Required=false)]
                    public string FullPathName { get; set; }

                    /// <summary>
                    /// Indicates whether the file is a directory.
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public bool? IsDir { get; set; }

                    /// <summary>
                    /// Indicates whether the file is a template.
                    /// </summary>
                    [NameInMap("isTemplate")]
                    [Validation(Required=false)]
                    public bool? IsTemplate { get; set; }

                    /// <summary>
                    /// The file name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The version name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the index version. Valid values:
                /// 
                /// *   NEW: The index version is created.
                /// *   PUBLISH: The index version is normal.
                /// *   IN_USE: The index version is in use.
                /// *   NOT_USE: The index version is not used.
                /// *   STOP_USE: The index version is being stopped.
                /// *   RESTORE_USE: The index version is being restored.
                /// *   FAIL: The index version failed to be created.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the index version was updated.
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The version ID.
                /// </summary>
                [NameInMap("versionId")]
                [Validation(Required=false)]
                public int? VersionId { get; set; }

            }

        }

    }

}
