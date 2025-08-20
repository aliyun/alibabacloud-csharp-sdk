// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsKafkaHudiJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("AcrossRole")]
        [Validation(Required=false)]
        public string AcrossRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123************</para>
        /// </summary>
        [NameInMap("AcrossUid")]
        [Validation(Required=false)]
        public string AcrossUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateApsKafkaHudiJobRequestColumns> Columns { get; set; }
        public class CreateApsKafkaHudiJobRequestColumns : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("MapName")]
            [Validation(Required=false)]
            public string MapName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("MapType")]
            [Validation(Required=false)]
            public string MapType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("DataOutputFormat")]
        [Validation(Required=false)]
        public string DataOutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hoodie.keep.min.commits=20</para>
        /// </summary>
        [NameInMap("HudiAdvancedConfig")]
        [Validation(Required=false)]
        public string HudiAdvancedConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ACU</para>
        /// </summary>
        [NameInMap("IncrementalComputeUnit")]
        [Validation(Required=false)]
        public string IncrementalComputeUnit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JsonParseLevel")]
        [Validation(Required=false)]
        public int? JsonParseLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KafkaClusterId")]
        [Validation(Required=false)]
        public string KafkaClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KafkaTopic")]
        [Validation(Required=false)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public long? LakehouseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxOffsetsPerTrigger")]
        [Validation(Required=false)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://test-xx-zzz/yyy/</para>
        /// </summary>
        [NameInMap("OssLocation")]
        [Validation(Required=false)]
        public string OssLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HUDI</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PartitionSpecs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> PartitionSpecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Strategy&quot;: &quot;mapping&quot;</para>
        /// </summary>
        [NameInMap("PrimaryKeyDefinition")]
        [Validation(Required=false)]
        public string PrimaryKeyDefinition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aps</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>begincursor</para>
        /// </summary>
        [NameInMap("StartingOffsets")]
        [Validation(Required=false)]
        public string StartingOffsets { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testTB</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TargetGenerateRule")]
        [Validation(Required=false)]
        public string TargetGenerateRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
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
