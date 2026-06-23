// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Column : TeaModel {
        /// <summary>
        /// <para>Business metadata.</para>
        /// </summary>
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public ColumnBusinessMetadata BusinessMetadata { get; set; }
        public class ColumnBusinessMetadata : TeaModel {
            /// <summary>
            /// <para>Custom attribute values. The key is the custom attribute identifier, and the value is a list of attribute values.</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The business description of the field. Supported only for MaxCompute, HMS (EMR cluster), and DLF types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>字段1的业务描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>字段1</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a foreign key. Only MaxCompute supports this property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForeignKey")]
        [Validation(Required=false)]
        public bool? ForeignKey { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${instance ID or URL-encoded connection string}:${data catalog identifier}:${database name}:${schema name}:${table name}:${field name}</c>. Use an empty string for any level that does not exist.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF types, use an empty string for the instance ID. For MaxCompute, the database name is the MaxCompute project name. If the project uses the three-layer model, provide the schema name. Otherwise, use an empty string for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks, the data catalog identifier is the catalog name. For DLF, it is the catalog ID. Other types do not support the catalog level, so use an empty string.</para>
        /// </remarks>
        /// <para>Examples of common ID formats:</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>Where:<br>
        /// <c>instance_id</c>: The instance ID, required when the data source is registered in instance mode.<br>
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, required when the data source is registered using a connection string.<br>
        /// <c>catalog_id</c>: The DLF catalog ID.<br>
        /// <c>project_name</c>: The MaxCompute project name.<br>
        /// <c>database_name</c>: The database name.<br>
        /// <c>schema_name</c>: The schema name. For MaxCompute, provide this only if the project uses the three-layer model. Otherwise, use an empty string.<br>
        /// <c>table_name</c>: The table name.<br>
        /// <c>column_name</c>: The field name.<br><br><br><br><br><br><br><br></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-column:::project_name:[schema_name]:table_name:column_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>column_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a partition key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public bool? PartitionKey { get; set; }

        /// <summary>
        /// <para>The position.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a primary key. Only MaxCompute supports this property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <para>The table ID. For details, see the <c>Table</c> object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bigint</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
