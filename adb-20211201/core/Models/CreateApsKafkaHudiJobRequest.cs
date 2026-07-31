// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsKafkaHudiJobRequest : TeaModel {
        /// <summary>
        /// <para>The RAM role of a trusted entity that is an Alibaba Cloud account. For more information about how to create a RAM role, see Create a RAM role for a trusted Alibaba Cloud account.
        /// The Alibaba Cloud account that owns the AnalyticDB for MySQL cluster must be added as a trusted account to the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("AcrossRole")]
        [Validation(Required=false)]
        public string AcrossRole { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the source Kafka instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123************</para>
        /// </summary>
        [NameInMap("AcrossUid")]
        [Validation(Required=false)]
        public string AcrossUid { get; set; }

        /// <summary>
        /// <para>The advanced configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <para>The column information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateApsKafkaHudiJobRequestColumns> Columns { get; set; }
        public class CreateApsKafkaHudiJobRequestColumns : TeaModel {
            /// <summary>
            /// <para>The name of the destination field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("MapName")]
            [Validation(Required=false)]
            public string MapName { get; set; }

            /// <summary>
            /// <para>The type of the destination field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("MapType")]
            [Validation(Required=false)]
            public string MapType { get; set; }

            /// <summary>
            /// <para>The name of the source field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the source field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to view the cluster IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters in the destination region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The Kafka message type. Valid values: json, general_canal_json, mongo_canal_json, dataworks_json, and shareplex_json.</para>
        /// 
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("DataFormatType")]
        [Validation(Required=false)]
        public string DataFormatType { get; set; }

        /// <summary>
        /// <para>The valid values and their descriptions are as follows:
        /// Single: The source is a single-line JSON record.
        /// Multi: The source is a JSON array. A single JSON record is returned as the output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("DataOutputFormat")]
        [Validation(Required=false)]
        public string DataOutputFormat { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>The user-defined name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The configuration for full synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <para>The Hudi configuration for the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hoodie.keep.min.commits=20</para>
        /// </summary>
        [NameInMap("HudiAdvancedConfig")]
        [Validation(Required=false)]
        public string HudiAdvancedConfig { get; set; }

        /// <summary>
        /// <para>The configuration for incremental synchronization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("IncrementalComputeUnit")]
        [Validation(Required=false)]
        public string IncrementalComputeUnit { get; set; }

        /// <summary>
        /// <para>The number of nested JSON layers to parse. Valid values:
        /// 0: No parsing is performed.
        /// 1: One layer is parsed.
        /// 2: Two layers are parsed.
        /// 3: Three layers are parsed.
        /// 4: Four layers are parsed.
        /// By default, one layer is parsed. For more information about the JSON parsing policy for nested data, see JSON parsing levels and schema field inference examples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JsonParseLevel")]
        [Validation(Required=false)]
        public int? JsonParseLevel { get; set; }

        /// <summary>
        /// <para>The ID of the Kafka instance. Obtain the ID from the Kafka console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KafkaClusterId")]
        [Validation(Required=false)]
        public string KafkaClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Kafka topic. Obtain the ID from the Kafka console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KafkaTopic")]
        [Validation(Required=false)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// <para>The ID of the lakehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public long? LakehouseId { get; set; }

        /// <summary>
        /// <para>The number of entries to consume in a single batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxOffsetsPerTrigger")]
        [Validation(Required=false)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// <para>The destination lakehouse address. This must be a complete OSS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-xx-zzz/yyy/</para>
        /// </summary>
        [NameInMap("OssLocation")]
        [Validation(Required=false)]
        public string OssLocation { get; set; }

        /// <summary>
        /// <para>The output data format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HUDI</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>The partition information.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PartitionSpecs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> PartitionSpecs { get; set; }

        /// <summary>
        /// <para>The primary key settings. This parameter supports the UUID policy and the mapping policy. The policies are described as follows.
        /// UUID policy: &quot;Strategy&quot;: &quot;uuid&quot;.
        /// Mapping policy:
        /// &quot;Strategy&quot;: &quot;mapping&quot;,
        /// &quot;Values&quot;:[
        /// &quot;f1&quot;,
        /// &quot;f2&quot;
        /// ],
        /// &quot;RecordVersionField&quot;,&quot;xxx&quot;
        /// \<c>RecordVersionField\\</c> specifies the Hudi record version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Strategy&quot;: &quot;mapping&quot;</para>
        /// </summary>
        [NameInMap("PrimaryKeyDefinition")]
        [Validation(Required=false)]
        public string PrimaryKeyDefinition { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>The initial consumer offset for Kafka.
        /// Valid values:
        /// begin_cursor, end_cursor, and timestamp.
        /// These values correspond to the earliest offset, the latest offset, and a specified time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>begincursor</para>
        /// </summary>
        [NameInMap("StartingOffsets")]
        [Validation(Required=false)]
        public string StartingOffsets { get; set; }

        /// <summary>
        /// <para>The user-defined name of the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testTB</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The generation rule for the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TargetGenerateRule")]
        [Validation(Required=false)]
        public string TargetGenerateRule { get; set; }

        /// <summary>
        /// <para>The type of the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The name of the workload.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

    }

}
