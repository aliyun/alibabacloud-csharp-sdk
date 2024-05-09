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
        /// Deploy
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

            [NameInMap("processor")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultProcessor Processor { get; set; }
            public class GetDataSourceDeployResponseBodyResultProcessor : TeaModel {
                [NameInMap("args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                [NameInMap("resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            [NameInMap("storage")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultStorage Storage { get; set; }
            public class GetDataSourceDeployResponseBodyResultStorage : TeaModel {
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

                /// <summary>
                /// oss bucket
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// odps endpoint
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
            public GetDataSourceDeployResponseBodyResultSwift Swift { get; set; }
            public class GetDataSourceDeployResponseBodyResultSwift : TeaModel {
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

        }

    }

}
