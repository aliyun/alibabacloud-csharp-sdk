// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsKafkaHudiJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The RAM role whose trusted entity is an Alibaba Cloud account. For more information about how to create a RAM role, see Create a RAM role for a trusted Alibaba Cloud account.
        /// In the RAM role, the Alibaba Cloud account to which AnalyticDB for MySQL belongs must be configured as a trusted account for the Alibaba Cloud account to which the Kafka instance belongs.</para>
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
        /// <para>The advanced configurations.</para>
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
        public string ColumnsShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (3.0) clusters in the specified region.</para>
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
        /// <para>The data output format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Single: The source is a single-line JSON record.</description></item>
        /// <item><description>Multi: The source is a JSON array. A single JSON record must be output.</description></item>
        /// </list>
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
        /// <para>The custom database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The full synchronization configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <para>The destination Hudi configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hoodie.keep.min.commits=20</para>
        /// </summary>
        [NameInMap("HudiAdvancedConfig")]
        [Validation(Required=false)]
        public string HudiAdvancedConfig { get; set; }

        /// <summary>
        /// <para>The incremental synchronization configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("IncrementalComputeUnit")]
        [Validation(Required=false)]
        public string IncrementalComputeUnit { get; set; }

        /// <summary>
        /// <para>The nesting parse level for JSON. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No parsing.</description></item>
        /// <item><description>1: Parse one level.</description></item>
        /// <item><description>2: Parse two levels.</description></item>
        /// <item><description>3: Parse three levels.</description></item>
        /// <item><description>4: Parse four levels.
        /// Default value: 1. For more information about the JSON nesting parse strategy, see JSON parse levels and schema field inference examples.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JsonParseLevel")]
        [Validation(Required=false)]
        public int? JsonParseLevel { get; set; }

        /// <summary>
        /// <para>Instance ID of the Kafka instance. You can obtain instance ID in the Kafka console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KafkaClusterId")]
        [Validation(Required=false)]
        public string KafkaClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Kafka topic. You can obtain the ID in the Kafka console.</para>
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
        /// <para>The maximum number of messages to consume per trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxOffsetsPerTrigger")]
        [Validation(Required=false)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// <para>The destination lakehouse address, which is a complete OSS path.</para>
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
        public string PartitionSpecsShrink { get; set; }

        /// <summary>
        /// <para>The primary key settings, including the UUID strategy and the mapping strategy. Details:
        /// UUID strategy: &quot;Strategy&quot;: &quot;uuid&quot;.
        /// Mapping strategy:
        /// &quot;Strategy&quot;: &quot;mapping&quot;,
        /// &quot;Values&quot;:[
        ///  &quot;f1&quot;,
        ///  &quot;f2&quot;
        /// ],
        /// &quot;RecordVersionField&quot;,&quot;xxx&quot;
        /// RecordVersionField specifies the Hudi record version.</para>
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
        /// <para>The starting consumption offset for Kafka. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>begin_cursor: The earliest offset.</description></item>
        /// <item><description>end_cursor: The latest offset.</description></item>
        /// <item><description>timestamp: A specified time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>begincursor</para>
        /// </summary>
        [NameInMap("StartingOffsets")]
        [Validation(Required=false)]
        public string StartingOffsets { get; set; }

        /// <summary>
        /// <para>The custom table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testTB</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The destination generation rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TargetGenerateRule")]
        [Validation(Required=false)]
        public string TargetGenerateRule { get; set; }

        /// <summary>
        /// <para>The destination type.</para>
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
