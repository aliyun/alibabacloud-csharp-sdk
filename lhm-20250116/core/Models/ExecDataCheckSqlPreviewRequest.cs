// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecDataCheckSqlPreviewRequest : TeaModel {
        /// <summary>
        /// <para>The columns to check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id,name</para>
        /// </summary>
        [NameInMap("checkColumn")]
        [Validation(Required=false)]
        public string CheckColumn { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>230</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The ID of the check engine. Used in Spark scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>230</para>
        /// </summary>
        [NameInMap("engineId")]
        [Validation(Required=false)]
        public string EngineId { get; set; }

        /// <summary>
        /// <para>The name of the table to check, in the format <c>schema.table</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db.test_table</para>
        /// </summary>
        [NameInMap("fullTableName")]
        [Validation(Required=false)]
        public string FullTableName { get; set; }

        /// <summary>
        /// <para>The partition condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>date_part=20240719</para>
        /// </summary>
        [NameInMap("partitionCondition")]
        [Validation(Required=false)]
        public string PartitionCondition { get; set; }

        /// <summary>
        /// <para>The ID of the check task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The WHERE condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id &gt; 100</para>
        /// </summary>
        [NameInMap("whereClause")]
        [Validation(Required=false)]
        public string WhereClause { get; set; }

    }

}
