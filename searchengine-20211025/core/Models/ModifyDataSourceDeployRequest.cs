// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyDataSourceDeployRequest : TeaModel {
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestExtend Extend { get; set; }
        public class ModifyDataSourceDeployRequestExtend : TeaModel {
            [NameInMap("hdfs")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendHdfs Hdfs { get; set; }
            public class ModifyDataSourceDeployRequestExtendHdfs : TeaModel {
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            [NameInMap("odps")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOdps Odps { get; set; }
            public class ModifyDataSourceDeployRequestExtendOdps : TeaModel {
                [NameInMap("partitions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Partitions { get; set; }

            }

            [NameInMap("oss")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOss Oss { get; set; }
            public class ModifyDataSourceDeployRequestExtendOss : TeaModel {
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            [NameInMap("saro")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendSaro Saro { get; set; }
            public class ModifyDataSourceDeployRequestExtendSaro : TeaModel {
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("processor")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestProcessor Processor { get; set; }
        public class ModifyDataSourceDeployRequestProcessor : TeaModel {
            [NameInMap("args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

        [NameInMap("storage")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestStorage Storage { get; set; }
        public class ModifyDataSourceDeployRequestStorage : TeaModel {
            /// <summary>
            /// AK
            /// </summary>
            [NameInMap("accessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// AS
            /// </summary>
            [NameInMap("accessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        [NameInMap("swift")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestSwift Swift { get; set; }
        public class ModifyDataSourceDeployRequestSwift : TeaModel {
            /// <summary>
            /// topic
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

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// generationId
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public long? GenerationId { get; set; }

    }

}
