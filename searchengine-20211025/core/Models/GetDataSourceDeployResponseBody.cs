// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDataSourceDeployResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDataSourceDeployResponseBodyResult Result { get; set; }
        public class GetDataSourceDeployResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic full indexing is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// <para>The extended content of the field configuration. The key can be \<c>vector\\</c> for vector fields or \<c>embedding\\</c> for fields that require embedding.</para>
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultExtend Extend { get; set; }
            public class GetDataSourceDeployResponseBodyResultExtend : TeaModel {
                /// <summary>
                /// <para>The HDFS information.</para>
                /// </summary>
                [NameInMap("hdfs")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendHdfs Hdfs { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendHdfs : TeaModel {
                    /// <summary>
                    /// <para>The path of the HDFS data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dist-dmj-job/src/main/java</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The information about the MaxCompute data source.</para>
                /// </summary>
                [NameInMap("odps")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendOdps Odps { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendOdps : TeaModel {
                    /// <summary>
                    /// <para>The partition information of the data source.</para>
                    /// </summary>
                    [NameInMap("partitions")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Partitions { get; set; }

                }

                /// <summary>
                /// <para>The OSS information.</para>
                /// </summary>
                [NameInMap("oss")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendOss Oss { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendOss : TeaModel {
                    /// <summary>
                    /// <para>The path of the OSS data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://opensearch</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The information about the SARO data source.</para>
                /// </summary>
                [NameInMap("saro")]
                [Validation(Required=false)]
                public GetDataSourceDeployResponseBodyResultExtendSaro Saro { get; set; }
                public class GetDataSourceDeployResponseBodyResultExtendSaro : TeaModel {
                    /// <summary>
                    /// <para>The path of the HDFS data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dist-dmj-job/src/main/java</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The processor parameters.</para>
            /// </summary>
            [NameInMap("processor")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultProcessor Processor { get; set; }
            public class GetDataSourceDeployResponseBodyResultProcessor : TeaModel {
                /// <summary>
                /// <para>The startup parameters for the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;processInfos&quot;: [],
                ///     &quot;groupId&quot;: &quot;opensearch&quot;,
                ///     &quot;containerConfigs&quot;: [],
                ///     &quot;priority&quot;: {
                ///         &quot;minor_priority&quot;: 0,
                ///         &quot;major_priority&quot;: 64
                ///     }
                /// }</para>
                /// </summary>
                [NameInMap("args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <para>The resource information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{
                ///     &quot;_bs_role&quot;: &quot;processor.*.inc&quot;,
                ///     &quot;priority&quot;: {
                ///         &quot;major_priority&quot;: 32,
                ///         &quot;minor_priority&quot;: 0
                ///     },
                ///     &quot;slotResources&quot;: [{
                ///         &quot;slotResources&quot;: [{
                ///             &quot;amount&quot;: 200,
                ///             &quot;name&quot;: &quot;cpu&quot;
                ///         }, {
                ///             &quot;amount&quot;: 8192,
                ///             &quot;name&quot;: &quot;mem&quot;
                ///         }, {
                ///             &quot;amount&quot;: 0,
                ///             &quot;name&quot;: &quot;T4&quot;
                ///         }, {
                ///             &quot;amount&quot;: 10,
                ///             &quot;type&quot;: &quot;SCALAR&quot;,
                ///             &quot;name&quot;: &quot;disk_ratio_9999&quot;
                ///         }, {
                ///             &quot;amount&quot;: 20480,
                ///             &quot;type&quot;: &quot;SCALAR&quot;,
                ///             &quot;name&quot;: &quot;disk_size_9999&quot;
                ///         }]
                ///     }]
                /// }]</para>
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The data source information.</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultStorage Storage { get; set; }
            public class GetDataSourceDeployResponseBodyResultStorage : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L***p</para>
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5**9a6</para>
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// <para>The OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-oss-bucket</para>
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
                /// <para>Information related to SARO.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lazada-campaign-flink</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Information related to the OSS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opensearch/test.json</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The partition of the MaxCompute data source. For example: ds=20180102</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20220926</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>Information related to HDFS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/beiming_xobject/dwd_xobjectsandbox__list_create_action_by_new/</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wireless_1688_personal_rec</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The name of the table in the SARO or MaxCompute data source.</para>
                /// 
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
            /// <para>The information about incremental data from Swift.</para>
            /// </summary>
            [NameInMap("swift")]
            [Validation(Required=false)]
            public GetDataSourceDeployResponseBodyResultSwift Swift { get; set; }
            public class GetDataSourceDeployResponseBodyResultSwift : TeaModel {
                /// <summary>
                /// <para>The topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-pl32rf0****_test_api</para>
                /// </summary>
                [NameInMap("topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The ZooKeeper service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-zk</para>
                /// </summary>
                [NameInMap("zk")]
                [Validation(Required=false)]
                public string Zk { get; set; }

            }

        }

    }

}
