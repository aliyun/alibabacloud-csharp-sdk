// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyDataSourceDeployRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic full indexing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestExtend Extend { get; set; }
        public class ModifyDataSourceDeployRequestExtend : TeaModel {
            /// <summary>
            /// <para>The HDFS information.</para>
            /// </summary>
            [NameInMap("hdfs")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendHdfs Hdfs { get; set; }
            public class ModifyDataSourceDeployRequestExtendHdfs : TeaModel {
                /// <summary>
                /// <para>The HDFS data source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ymsh-service/src/main/java/cn/ymsh/util/jd</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The ODPS data source information.</para>
            /// </summary>
            [NameInMap("odps")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOdps Odps { get; set; }
            public class ModifyDataSourceDeployRequestExtendOdps : TeaModel {
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
            public ModifyDataSourceDeployRequestExtendOss Oss { get; set; }
            public class ModifyDataSourceDeployRequestExtendOss : TeaModel {
                /// <summary>
                /// <para>The OSS data source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The Saro data source information.</para>
            /// </summary>
            [NameInMap("saro")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendSaro Saro { get; set; }
            public class ModifyDataSourceDeployRequestExtendSaro : TeaModel {
                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The process parameters.</para>
        /// </summary>
        [NameInMap("processor")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestProcessor Processor { get; set; }
        public class ModifyDataSourceDeployRequestProcessor : TeaModel {
            /// <summary>
            /// <para>The process startup parameters.</para>
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
        public ModifyDataSourceDeployRequestStorage Storage { get; set; }
        public class ModifyDataSourceDeployRequestStorage : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L***p</para>
            /// </summary>
            [NameInMap("accessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5**9a6</para>
            /// </summary>
            [NameInMap("accessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The data catalog name of the DLF data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-catalog</para>
            /// </summary>
            [NameInMap("catalog")]
            [Validation(Required=false)]
            public string Catalog { get; set; }

            /// <summary>
            /// <para>The database of the DLF data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-database</para>
            /// </summary>
            [NameInMap("database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>odps endpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The namespace. This parameter is related to Saro.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp-dev</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The path. This parameter is related to the OSS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opensearch</para>
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The partition information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20220713</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The path. This parameter is related to HDFS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/ude_jobs/iflow_offline_data_access</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The project name of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubenest</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The table name. This parameter is related to Saro or ODPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <para>The table format of the DLF data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paimon
            /// lance
            /// object</para>
            /// </summary>
            [NameInMap("tableFormat")]
            [Validation(Required=false)]
            public string TableFormat { get; set; }

            /// <summary>
            /// <para>The tag of the DLF data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The incremental Swift information.</para>
        /// </summary>
        [NameInMap("swift")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestSwift Swift { get; set; }
        public class ModifyDataSourceDeployRequestSwift : TeaModel {
            /// <summary>
            /// <para>topic</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_test_api</para>
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

        /// <summary>
        /// <para>Specifies whether to perform a dry run (only validates whether the data source is valid). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run.</description></item>
        /// <item><description>false: does not perform a dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1708674867</para>
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public long? GenerationId { get; set; }

    }

}
