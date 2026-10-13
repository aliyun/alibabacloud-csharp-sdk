// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsTimerRequest : TeaModel {
        /// <summary>
        /// <para>The mapping between source and destination column names in the {source column name: destination column name} format.</para>
        /// </summary>
        [NameInMap("columnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ColumnMapping { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate the table data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableDataMigration")]
        [Validation(Required=false)]
        public bool? EnableDataMigration { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate the table schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSchemaMigration")]
        [Validation(Required=false)]
        public bool? EnableSchemaMigration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable verification. Currently, the verification method executes SELECT COUNT on the source and destination to compare the number of rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableVerification")]
        [Validation(Required=false)]
        public bool? EnableVerification { get; set; }

        /// <summary>
        /// <para>The name of the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>planA</para>
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
        /// <para>The partition filter expression. Configure the partition filter expression for the specified table.</para>
        /// </summary>
        [NameInMap("partitionFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> PartitionFilters { get; set; }

        /// <summary>
        /// <para>The list of partition IDs for the tables to be migrated. Specify this parameter when type is set to Partitions.</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<long?> Partitions { get; set; }

        /// <summary>
        /// <para>The schedule type of the scheduled task. Valid values: Daily (runs daily) and Hourly (runs hourly).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000014</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

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
        /// <para>The list of tables to exclude from migration. Specify this parameter when type is set to Database.</para>
        /// </summary>
        [NameInMap("tableBlackList")]
        [Validation(Required=false)]
        public List<string> TableBlackList { get; set; }

        /// <summary>
        /// <para>The mapping between the source table name and the destination table name.</para>
        /// </summary>
        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> TableMapping { get; set; }

        /// <summary>
        /// <para>The list of tables to migrate. Specify this parameter when type is set to Database. If this parameter is not specified, all tables in the corresponding database are migrated.</para>
        /// </summary>
        [NameInMap("tableWhiteList")]
        [Validation(Required=false)]
        public List<string> TableWhiteList { get; set; }

        /// <summary>
        /// <para>The list of names of the tables to be migrated. Specify this parameter when type is set to Tables.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<string> Tables { get; set; }

        /// <summary>
        /// <para>The schedule time of the scheduled task. When scheduleType is set to Daily, the value is in the HH:MM format. When scheduleType is set to Hourly, the value is in the MM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
