// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDataSourceDeployResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDataSourceDeployResponseBodyResult Result { get; set; }
        public class GetDataSourceDeployResponseBodyResult : TeaModel {
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            [NameInMap("extend")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultExtend Extend { get; set; }
            public class GetDataSourceDeployResponseBodyResultExtend : TeaModel {
                [NameInMap("hdfs")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendHdfs Hdfs { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendHdfs : TeaModel {
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("odps")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendOdps Odps { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendOdps : TeaModel {
                    [NameInMap("partitions")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Partitions { get; set; }

                }

                [NameInMap("oss")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendOss Oss { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendOss : TeaModel {
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("saro")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendSaro Saro { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendSaro : TeaModel {
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

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
            public GetDataSourceDeployResponseBodyResultProcessor Processor { get; set; }
            public class GetDataSourceDeployResponseBodyResultProcessor : TeaModel {
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
            public GetDataSourceDeployResponseBodyResultStorage Storage { get; set; }
            public class GetDataSourceDeployResponseBodyResultStorage : TeaModel {
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

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

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
            public GetDataSourceDeployResponseBodyResultSwift Swift { get; set; }
            public class GetDataSourceDeployResponseBodyResultSwift : TeaModel {
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

        }

    }

}
