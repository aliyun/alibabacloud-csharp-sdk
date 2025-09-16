// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyDataSourceDeployRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic full indexing feature.</para>
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
            /// <para>The information about the Apsara File Storage for HDFS data source.</para>
            /// </summary>
            [NameInMap("hdfs")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendHdfs Hdfs { get; set; }
            public class ModifyDataSourceDeployRequestExtendHdfs : TeaModel {
                /// <summary>
                /// <para>The path of the Apsara File Storage for HDFS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ymsh-service/src/main/java/cn/ymsh/util/jd</para>
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
            public ModifyDataSourceDeployRequestExtendOdps Odps { get; set; }
            public class ModifyDataSourceDeployRequestExtendOdps : TeaModel {
                /// <summary>
                /// <para>The partitions in the MaxCompute table.</para>
                /// </summary>
                [NameInMap("partitions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Partitions { get; set; }

            }

            /// <summary>
            /// <para>The information about the OSS data source.</para>
            /// </summary>
            [NameInMap("oss")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendOss Oss { get; set; }
            public class ModifyDataSourceDeployRequestExtendOss : TeaModel {
                /// <summary>
                /// <para>The path of the OSS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The information about the SARO data source. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.</para>
            /// </summary>
            [NameInMap("saro")]
            [Validation(Required=false)]
            public ModifyDataSourceDeployRequestExtendSaro Saro { get; set; }
            public class ModifyDataSourceDeployRequestExtendSaro : TeaModel {
                /// <summary>
                /// <para>The path of the SARO data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The version number of the SARO data source.</para>
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
        /// <para>The parameters of the process.</para>
        /// </summary>
        [NameInMap("processor")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestProcessor Processor { get; set; }
        public class ModifyDataSourceDeployRequestProcessor : TeaModel {
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
        public ModifyDataSourceDeployRequestStorage Storage { get; set; }
        public class ModifyDataSourceDeployRequestStorage : TeaModel {
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
            /// <para>test-bucket</para>
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
            /// <para>The namespace. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp-dev</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opensearch</para>
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The partition in the MaxCompute table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20220713</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The file path in the Apsara File Storage for HDFS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/ude_jobs/iflow_offline_data_access</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The name of the MaxCompute project that is used as the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubenest</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The name of the MaxCompute table that is used as the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("tableFormat")]
            [Validation(Required=false)]
            public string TableFormat { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The information about the incremental data source Swift.</para>
        /// </summary>
        [NameInMap("swift")]
        [Validation(Required=false)]
        public ModifyDataSourceDeployRequestSwift Swift { get; set; }
        public class ModifyDataSourceDeployRequestSwift : TeaModel {
            /// <summary>
            /// <para>The topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-0ju2rps6c08_api</para>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. The system only checks the validity of the data source. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1708674867</para>
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public long? GenerationId { get; set; }

    }

}
