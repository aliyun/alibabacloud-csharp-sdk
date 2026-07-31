// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class FieldSchemaModel : TeaModel {
        /// <summary>
        /// <para>Indicates whether the column is auto-incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        /// <summary>
        /// <para>The original name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ColumnRawName</para>
        /// </summary>
        [NameInMap("ColumnRawName")]
        [Validation(Required=false)]
        public string ColumnRawName { get; set; }

        /// <summary>
        /// <para>The description of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Indicates whether FLOAT data is compressed to SHORT data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompressFloatUseShort")]
        [Validation(Required=false)]
        public bool? CompressFloatUseShort { get; set; }

        /// <summary>
        /// <para>The compression method of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compression</para>
        /// </summary>
        [NameInMap("Compression")]
        [Validation(Required=false)]
        public string Compression { get; set; }

        /// <summary>
        /// <para>The time when the column was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The data type of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>long</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The logical name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>databaseName</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The default value of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The delimiter of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delimiter</para>
        /// </summary>
        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// <para>The encryption method of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>encode</para>
        /// </summary>
        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is the partition key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPartitionKey")]
        [Validation(Required=false)]
        public bool? IsPartitionKey { get; set; }

        /// <summary>
        /// <para>The mapping name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mappedName</para>
        /// </summary>
        [NameInMap("MappedName")]
        [Validation(Required=false)]
        public string MappedName { get; set; }

        /// <summary>
        /// <para>The name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the column can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// <para>The update condition of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>onUpdate</para>
        /// </summary>
        [NameInMap("OnUpdate")]
        [Validation(Required=false)]
        public string OnUpdate { get; set; }

        /// <summary>
        /// <para>The location of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("OrdinalPosition")]
        [Validation(Required=false)]
        public long? OrdinalPosition { get; set; }

        /// <summary>
        /// <para>The physical name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PhysicalColumnName</para>
        /// </summary>
        [NameInMap("PhysicalColumnName")]
        [Validation(Required=false)]
        public string PhysicalColumnName { get; set; }

        /// <summary>
        /// <para>The location of the primary key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("PkPosition")]
        [Validation(Required=false)]
        public long? PkPosition { get; set; }

        /// <summary>
        /// <para>The precision of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Precision")]
        [Validation(Required=false)]
        public long? Precision { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is the primary key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Primarykey")]
        [Validation(Required=false)]
        public bool? Primarykey { get; set; }

        /// <summary>
        /// <para>The scale of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public long? Scale { get; set; }

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
        /// <para>The token of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tokenizer</para>
        /// </summary>
        [NameInMap("Tokenizer")]
        [Validation(Required=false)]
        public string Tokenizer { get; set; }

        /// <summary>
        /// <para>The type of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>long</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the index was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The value type of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>valueType</para>
        /// </summary>
        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
