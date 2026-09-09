// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsTimerRequest : TeaModel {
        /// <summary>
        /// <para>A map of source column names to target column names.</para>
        /// </summary>
        [NameInMap("columnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ColumnMapping { get; set; }

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
        /// <para>Specifies whether to migrate the table schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSchemaMigration")]
        [Validation(Required=false)]
        public bool? EnableSchemaMigration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data verification. If set to <c>true</c>, the system runs a <c>SELECT COUNT(*)</c> query on both the source and target tables and compares the row counts.</para>
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
        /// <para>Other configuration settings.</para>
        /// </summary>
        [NameInMap("others")]
        [Validation(Required=false)]
        public Dictionary<string, object> Others { get; set; }

        /// <summary>
        /// <para>A map of table names to their corresponding partition filter expressions.</para>
        /// </summary>
        [NameInMap("partitionFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> PartitionFilters { get; set; }

        /// <summary>
        /// <para>A list of IDs for the table partitions to migrate. This parameter takes effect only when the <c>type</c> parameter is set to <c>Partitions</c>.</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<long?> Partitions { get; set; }

        /// <summary>
        /// <para>The schedule type for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

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
        /// <para>The name of the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src_db</para>
        /// </summary>
        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

        /// <summary>
        /// <para>A blacklist of tables to exclude from the migration. This parameter takes effect only when the <c>type</c> parameter is set to <c>Database</c>.</para>
        /// </summary>
        [NameInMap("tableBlackList")]
        [Validation(Required=false)]
        public List<string> TableBlackList { get; set; }

        /// <summary>
        /// <para>A map of source table names to target table names.</para>
        /// </summary>
        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> TableMapping { get; set; }

        /// <summary>
        /// <para>A whitelist of tables to migrate. This parameter takes effect only when the <c>type</c> parameter is set to <c>Database</c>. If omitted, all tables in the source database are migrated.</para>
        /// </summary>
        [NameInMap("tableWhiteList")]
        [Validation(Required=false)]
        public List<string> TableWhiteList { get; set; }

        /// <summary>
        /// <para>A list of table names to migrate. This parameter takes effect only when the <c>type</c> parameter is set to <c>Tables</c>.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<string> Tables { get; set; }

        /// <summary>
        /// <para>The time to run the scheduled task. If <c>scheduleType</c> is set to <c>Daily</c>, the value is the time in <c>HH:MM</c> format. If <c>scheduleType</c> is set to <c>Hourly</c>, the value is the minute of the hour (<c>MM</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
