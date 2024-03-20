// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexesResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The index list.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListIndexesResponseBodyResult> Result { get; set; }
        public class ListIndexesResponseBodyResult : TeaModel {
            /// <summary>
            /// schema JSON
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The data source.
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// 数据源相关信息
            /// </summary>
            [NameInMap("dataSourceInfo")]
            [Validation(Required=false)]
            public ListIndexesResponseBodyResultDataSourceInfo DataSourceInfo { get; set; }
            public class ListIndexesResponseBodyResultDataSourceInfo : TeaModel {
                /// <summary>
                /// 是否开启自动全量
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                /// <summary>
                /// odps 数据源配置
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoConfig Config { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoConfig : TeaModel {
                    /// <summary>
                    /// odps数据源ak
                    /// </summary>
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// odps数据源ak secret
                    /// </summary>
                    [NameInMap("accessSecret")]
                    [Validation(Required=false)]
                    public string AccessSecret { get; set; }

                    /// <summary>
                    /// oss命名空间
                    /// </summary>
                    [NameInMap("bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// odps相关
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// saro相关
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// oss数据源相关
                    /// </summary>
                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    /// <summary>
                    /// 数据分片
                    /// </summary>
                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    /// <summary>
                    /// hdfs相关
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// odps数据源项目名称
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// saro、odps相关
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// 离线部署
                /// </summary>
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// 数据源名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 数据更新资源数
                /// </summary>
                [NameInMap("processPartitionCount")]
                [Validation(Required=false)]
                public int? ProcessPartitionCount { get; set; }

                /// <summary>
                /// saro数据源配置
                /// </summary>
                [NameInMap("saroConfig")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoSaroConfig SaroConfig { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoSaroConfig : TeaModel {
                    /// <summary>
                    /// saro数据源的namespace
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// saro数据表名称
                    /// </summary>
                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// 数据源类型 (odps, swift, saro, oss, unKnow)
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the data center where the data source is deployed.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// 全量切换时间
            /// </summary>
            [NameInMap("fullUpdateTime")]
            [Validation(Required=false)]
            public string FullUpdateTime { get; set; }

            /// <summary>
            /// 全量版本  即：索引版本
            /// </summary>
            [NameInMap("fullVersion")]
            [Validation(Required=false)]
            public long? FullVersion { get; set; }

            /// <summary>
            /// 增量更新时间
            /// </summary>
            [NameInMap("incUpdateTime")]
            [Validation(Required=false)]
            public string IncUpdateTime { get; set; }

            /// <summary>
            /// 索引大小
            /// </summary>
            [NameInMap("indexSize")]
            [Validation(Required=false)]
            public long? IndexSize { get; set; }

            /// <summary>
            /// NEW, PUBLISH
            /// </summary>
            [NameInMap("indexStatus")]
            [Validation(Required=false)]
            public string IndexStatus { get; set; }

            /// <summary>
            /// The name of the index.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 数据分片
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            /// <summary>
            /// The list of version information.
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyResultVersions> Versions { get; set; }
            public class ListIndexesResponseBodyResultVersions : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The list of file names.
                /// </summary>
                [NameInMap("files")]
                [Validation(Required=false)]
                public List<ListIndexesResponseBodyResultVersionsFiles> Files { get; set; }
                public class ListIndexesResponseBodyResultVersionsFiles : TeaModel {
                    /// <summary>
                    /// The name of the directory for the index.
                    /// </summary>
                    [NameInMap("fullPathName")]
                    [Validation(Required=false)]
                    public string FullPathName { get; set; }

                    /// <summary>
                    /// Indicates whether a directory exists.
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public bool? IsDir { get; set; }

                    /// <summary>
                    /// Indicates whether it is a template.
                    /// </summary>
                    [NameInMap("isTemplate")]
                    [Validation(Required=false)]
                    public bool? IsTemplate { get; set; }

                    /// <summary>
                    /// The name of the file.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The name of the version.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The state of the version. Valid values: drafting, used, unused and trash. drafting indicates that the version is a draft, used indicates that the version is used online, unused indicates that the version is not used, and trash indicates that the version is being deleted.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the version was updated.
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The ID of the version. The value of this parameter is null for the edit version.
                /// </summary>
                [NameInMap("versionId")]
                [Validation(Required=false)]
                public int? VersionId { get; set; }

            }

        }

    }

}
