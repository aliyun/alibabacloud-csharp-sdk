// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsJobRequest : TeaModel {
        /// <summary>
        /// <para>{Source column name: Destination column name}</para>
        /// </summary>
        [NameInMap("columnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ColumnMapping { get; set; }

        /// <summary>
        /// <para>The destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mms_test</para>
        /// </summary>
        [NameInMap("dstDbName")]
        [Validation(Required=false)]
        public string DstDbName { get; set; }

        /// <summary>
        /// <para>The destination MaxCompute schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dstSchemaName")]
        [Validation(Required=false)]
        public string DstSchemaName { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate table data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableDataMigration")]
        [Validation(Required=false)]
        public bool? EnableDataMigration { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate table schemas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSchemaMigration")]
        [Validation(Required=false)]
        public bool? EnableSchemaMigration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data verification. The current verification method is to execute SELECT COUNT(\*) on the source and destination to compare the number of rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableVerification")]
        [Validation(Required=false)]
        public bool? EnableVerification { get; set; }

        /// <summary>
        /// <para>The expected completion time of the migration. Note: A smaller eta value gives the migration task higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-04</para>
        /// </summary>
        [NameInMap("eta")]
        [Validation(Required=false)]
        public string Eta { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform an incremental migration. In an incremental migration, only new or changed partitions are migrated. Note that changed partitions are re-migrated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("increment")]
        [Validation(Required=false)]
        public bool? Increment { get; set; }

        /// <summary>
        /// <para>The name of the migration job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>migrate_db_1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Other configuration information.</para>
        /// </summary>
        [NameInMap("others")]
        [Validation(Required=false)]
        public Dictionary<string, object> Others { get; set; }

        /// <summary>
        /// <para>{Table name: Partition filter expression}</para>
        /// </summary>
        [NameInMap("partitionFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> PartitionFilters { get; set; }

        /// <summary>
        /// <para>The list of partition IDs.</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<long?> Partitions { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate only metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("schemaOnly")]
        [Validation(Required=false)]
        public bool? SchemaOnly { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000014</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("sourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The name of the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src_db</para>
        /// </summary>
        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

        /// <summary>
        /// <para>The name of the source schema. This is the schema in a Layer 3 namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("srcSchemaName")]
        [Validation(Required=false)]
        public string SrcSchemaName { get; set; }

        /// <summary>
        /// <para>The blacklist of tables.</para>
        /// </summary>
        [NameInMap("tableBlackList")]
        [Validation(Required=false)]
        public List<string> TableBlackList { get; set; }

        /// <summary>
        /// <para>{Source table: Destination table}</para>
        /// </summary>
        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> TableMapping { get; set; }

        /// <summary>
        /// <para>The whitelist of tables. Note: If you configure both a whitelist and a blacklist, only the blacklist takes effect.</para>
        /// </summary>
        [NameInMap("tableWhiteList")]
        [Validation(Required=false)]
        public List<string> TableWhiteList { get; set; }

        /// <summary>
        /// <para>The list of table names.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<string> Tables { get; set; }

        /// <summary>
        /// <para>The type of the migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIGQUERY</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
