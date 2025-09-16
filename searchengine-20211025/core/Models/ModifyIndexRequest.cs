// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of full indexes that can be concurrently built.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// <para>The cluster information.</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Cluster { get; set; }

        /// <summary>
        /// <para>The name of the configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-35t3r02iq03@ha-cn-35t3r02iq03_test_api@hz_pre_vpc_domain_1@test_api@index_config_v1</para>
        /// </summary>
        [NameInMap("clusterConfigName")]
        [Validation(Required=false)]
        public string ClusterConfigName { get; set; }

        /// <summary>
        /// <para>The information about the offline configuration.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, ConfigValue> Config { get; set; }

        /// <summary>
        /// <para>The file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;summarys\&quot;:{\&quot;summary_fields\&quot;:[\&quot;id\&quot;]},\&quot;indexs\&quot;:[{\&quot;index_name\&quot;:\&quot;index_id\&quot;,\&quot;index_type\&quot;:\&quot;PRIMARYKEY64\&quot;,\&quot;index_fields\&quot;:\&quot;id\&quot;,\&quot;has_primary_key_attribute\&quot;:true,\&quot;is_primary_key_sorted\&quot;:false}],\&quot;attributes\&quot;:[\&quot;id\&quot;],\&quot;fields\&quot;:[{\&quot;field_name\&quot;:\&quot;id\&quot;,\&quot;field_type\&quot;:\&quot;UINT16\&quot;}],\&quot;table_name\&quot;:\&quot;index_2\&quot;}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-35t3n1yuj0d_index_1</para>
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>The information about the data source, which is required for the new version of OpenSearch Vector Search Edition.</para>
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public ModifyIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class ModifyIndexRequestDataSourceInfo : TeaModel {
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
            /// <para>The reindexing method. Valid values: api: API data source. indexRecover: data recovery by using indexing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("buildMode")]
            [Validation(Required=false)]
            public string BuildMode { get; set; }

            /// <summary>
            /// <para>The configurations of the MaxCompute data source.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoConfig Config { get; set; }
            public class ModifyIndexRequestDataSourceInfoConfig : TeaModel {
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

                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The namespace. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-namespace</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opensearch/oss.json</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The partition in the MaxCompute table. Example: ds=20180102.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20230114</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The file path in the Apsara File Storage for HDFS file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-hdfs-path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project that is used as the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbt_algo_pai</para>
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
            /// <para>The start timestamp from which incremental data is retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709715164</para>
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// <para>The offline deployment name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the index version from which data is restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-35t3n1yuj0d_index_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ossDataPath")]
            [Validation(Required=false)]
            public string OssDataPath { get; set; }

            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The maximum number of full indexes that can be concurrently processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("processParallelNum")]
            [Validation(Required=false)]
            public int? ProcessParallelNum { get; set; }

            /// <summary>
            /// <para>The number of resources used for data update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("processPartitionCount")]
            [Validation(Required=false)]
            public int? ProcessPartitionCount { get; set; }

            /// <summary>
            /// <para>The configurations of the SARO data source.</para>
            /// </summary>
            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class ModifyIndexRequestDataSourceInfoSaroConfig : TeaModel {
                /// <summary>
                /// <para>The namespace to which the SARO data source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink-test-fjx-default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The name of the SARO table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device_event_shy_summary_</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the data center in which the data source is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        /// <summary>
        /// <para>The maximum number of full indexes that can be concurrently merged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        /// <summary>
        /// <para>The number of shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// <para>The push mode of the configuration. By default, only the configuration is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUSH_ONLY</para>
        /// </summary>
        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the validity of input parameters. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks only the validity of input parameters.</description></item>
        /// <item><description><b>false</b>: checks the validity of input parameters and creates an attribution configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
