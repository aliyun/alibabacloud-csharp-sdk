// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyDataSourceDeployRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the automatic full indexing feature.
        /// </summary>
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        /// <summary>
        /// The extended information.
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestExtend Extend { get; set; }
        public class ModifyDataSourceDeployRequestExtend : TeaModel {
            /// <summary>
            /// The information about the Apsara File Storage for HDFS data source.
            /// </summary>
            [NameInMap("hdfs")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendHdfs Hdfs { get; set; }
            public class ModifyDataSourceDeployRequestExtendHdfs : TeaModel {
                /// <summary>
                /// The path of the Apsara File Storage for HDFS data source.
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// The information about the MaxCompute data source.
            /// </summary>
            [NameInMap("odps")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOdps Odps { get; set; }
            public class ModifyDataSourceDeployRequestExtendOdps : TeaModel {
                /// <summary>
                /// The partitions in the MaxCompute table.
                /// </summary>
                [NameInMap("partitions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Partitions { get; set; }

            }

            /// <summary>
            /// The information about the OSS data source.
            /// </summary>
            [NameInMap("oss")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOss Oss { get; set; }
            public class ModifyDataSourceDeployRequestExtendOss : TeaModel {
                /// <summary>
                /// The path of the OSS data source.
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// The information about the SARO data source. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.
            /// </summary>
            [NameInMap("saro")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendSaro Saro { get; set; }
            public class ModifyDataSourceDeployRequestExtendSaro : TeaModel {
                /// <summary>
                /// The path of the SARO data source.
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The version number of the SARO data source.
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The parameters of the process.
        /// </summary>
        [NameInMap("processor")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestProcessor Processor { get; set; }
        public class ModifyDataSourceDeployRequestProcessor : TeaModel {
            /// <summary>
            /// The startup parameters of the process.
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// The resource information.
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

        /// <summary>
        /// The information about the data source.
        /// </summary>
        [NameInMap("storage")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestStorage Storage { get; set; }
        public class ModifyDataSourceDeployRequestStorage : TeaModel {
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
            /// The partition in the MaxCompute table.
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
        /// The information about the incremental data source Swift.
        /// </summary>
        [NameInMap("swift")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestSwift Swift { get; set; }
        public class ModifyDataSourceDeployRequestSwift : TeaModel {
            /// <summary>
            /// The topic.
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// zk
            /// </summary>
            [NameInMap("zk")]
            [Validation(Required=false)]
            public string Zk { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. The system only checks the validity of the data source. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the full index version.
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public long? GenerationId { get; set; }

    }

}
