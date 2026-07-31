// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TableSummaryModel : TeaModel {
        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBySource")]
        [Validation(Required=false)]
        public string CreatedBySource { get; set; }

        [NameInMap("CreatedByUser")]
        [Validation(Required=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>descrtiption</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MvDetailModel")]
        [Validation(Required=false)]
        public OpenStructMvDetailModel MvDetailModel { get; set; }

        /// <summary>
        /// <para>Owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>SQL for creating the table or view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create table(a varchar)</para>
        /// </summary>
        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

        /// <summary>
        /// <para>Logical database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schemaName</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>Logical table name or logical view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>Table size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TableSize")]
        [Validation(Required=false)]
        public long? TableSize { get; set; }

        /// <summary>
        /// <para>Table or view type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHYSICAL_SCHEMA_NAME</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <para>Update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
