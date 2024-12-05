// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDataSourceDeployResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDataSourceDeployResponseBodyResult Result { get; set; }
        public class GetDataSourceDeployResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dist-dmj-job/src/main/java</para>
                    /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss://opensearch</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("saro")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendSaro Saro { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendSaro : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dist-dmj-job/src/main/java</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The parameters of the process.</para>
            /// </summary>
            [NameInMap("processor")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultProcessor Processor { get; set; }
            public class GetDataSourceDeployResponseBodyResultProcessor : TeaModel {
                /// <summary>
                /// <para>The startup parameters of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <para>The resource information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The information about the data source.</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultStorage Storage { get; set; }
            public class GetDataSourceDeployResponseBodyResultStorage : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak</para>
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>as</para>
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antsys-miniapp-chongwen-static</para>
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
                /// <para>The endpoint of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>lazada-campaign-flink</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://opensearch</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The partition in the MaxCompute table. Example: ds=20180102.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20220926</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/beiming_xobject/dwd_xobjectsandbox__list_create_action_by_new/</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wireless_1688_personal_rec</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>behavior</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The information about the incremental data source Swift.</para>
            /// </summary>
            [NameInMap("swift")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultSwift Swift { get; set; }
            public class GetDataSourceDeployResponseBodyResultSwift : TeaModel {
                /// <summary>
                /// <para>The topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic</para>
                /// </summary>
                [NameInMap("topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>zk</para>
                /// 
                /// <b>Example:</b>
                /// <para>zk</para>
                /// </summary>
                [NameInMap("zk")]
                [Validation(Required=false)]
                public string Zk { get; set; }

            }

        }

    }

}
