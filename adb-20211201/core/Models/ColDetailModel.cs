// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ColDetailModel : TeaModel {
        /// <summary>
        /// <para>The logical name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The time when the column was created. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05\&quot;T\&quot;13:17:55\&quot;Z\&quot;</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is the distribution key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistributeKey")]
        [Validation(Required=false)]
        public bool? DistributeKey { get; set; }

        /// <summary>
        /// <para>Indicates whether the column can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is the partition key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public bool? PartitionKey { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is the primary key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <para>The logical name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schemaName</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The logical name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The data type of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the column was updated. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05\&quot;T\&quot;13:17:55\&quot;Z\&quot;</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
