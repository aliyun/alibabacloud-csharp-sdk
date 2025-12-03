// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsKafkaHudiJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Resource Access Management (RAM) role that is created for the trusted Alibaba Cloud account. For more information, see Create a RAM role for a trusted Alibaba Cloud account. The ARN of the RAM role that grants AnalyticDB for MySQL permission to access resources in the source account. Required for cross-account data ingestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("AcrossRole")]
        [Validation(Required=false)]
        public string AcrossRole { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the source Kafka belongs.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all clusters in a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DataFormatType")]
        [Validation(Required=false)]
        public string DataFormatType { get; set; }

        /// <summary>
        /// <para>Enumeration value and description. Single: The source is a single-row JSON record. Multi: source is a JSON array. Output a single JSON record.</para>
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
        /// <para>The name of the user-defined database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The full synchronization configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <para>The HUDI configuration of the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hoodie.keep.min.commits=20</para>
        /// </summary>
        [NameInMap("HudiAdvancedConfig")]
        [Validation(Required=false)]
        public string HudiAdvancedConfig { get; set; }

        /// <summary>
        /// <para>The incremental synchronization configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("IncrementalComputeUnit")]
        [Validation(Required=false)]
        public string IncrementalComputeUnit { get; set; }

        /// <summary>
        /// <para>The number of layers that are parsed for nested JSON fields. Valid values: 0: Nested JSON fields are not parsed. 1: parses one layer. 2: Two layers are parsed. 3: Three layers are parsed. 4: Four layers are parsed. By default, one layer is parsed. For more information about how nested JSON fields are parsed, see the Examples of schema fields parsed with different numbers of layers section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JsonParseLevel")]
        [Validation(Required=false)]
        public int? JsonParseLevel { get; set; }

        /// <summary>
        /// <para>The ID of the Apache Kafka instance. You can get it in the Kafka console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KafkaClusterId")]
        [Validation(Required=false)]
        public string KafkaClusterId { get; set; }

        /// <summary>
        /// <para>Kafka Topic ID. You can get it in the Kafka console.</para>
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
        /// <para>The maximum number of records to fetch in a single batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxOffsetsPerTrigger")]
        [Validation(Required=false)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// <para>The path of the destination data lakehouse in an Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-xx-zzz/yyy/</para>
        /// </summary>
        [NameInMap("OssLocation")]
        [Validation(Required=false)]
        public string OssLocation { get; set; }

        /// <summary>
        /// <para>The format of the output data.</para>
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
        /// <para>The primary key settings. Contains the uuid policy and mapping policy. The explanation is as follows. Uuid policy: &quot;Strategy&quot;: &quot;uuid&quot;. Mapping policy: &quot;Strategy&quot;: &quot;mapping&quot;, &quot;Values&quot;:[ &quot;f1&quot;, &quot;f2&quot; ], &quot;RecordVersionField&quot;,&quot;xxx&quot; The meaning of the RecordVersionField is the HUDI record version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Strategy&quot;: &quot;mapping&quot;</para>
        /// </summary>
        [NameInMap("PrimaryKeyDefinition")]
        [Validation(Required=false)]
        public string PrimaryKeyDefinition { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>地域ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>Specifies the position from which to start consuming messages. Valid values: begin_cursor/end_cursor/timestamp Each corresponds to the earliest /latest /specified time respectively.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>begincursor</para>
        /// </summary>
        [NameInMap("StartingOffsets")]
        [Validation(Required=false)]
        public string StartingOffsets { get; set; }

        /// <summary>
        /// <para>The name of the user-defined table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testTB</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The rules for generating the destination database.</para>
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
