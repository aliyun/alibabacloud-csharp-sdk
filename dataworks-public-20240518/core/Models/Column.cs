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
            /// <para>A business-level description of the field (supported only by MaxCompute, HMS (EMR clusters) and DLF.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The comment.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether the column is a foreign key (only supported by MaxCompute).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForeignKey")]
        [Validation(Required=false)]
        public bool? ForeignKey { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Description of concepts related to metadata entities</a>.</para>
        /// <para>The format is: <c>${EntityType}:${Instance ID or encoded URL}:${Catalog Identifier}:${Database name}:${Schema name}:${Table Name}:${Column name}</c>. Use empty strings as placeholders for non-existent hierarchy levels.</para>
        /// <remarks>
        /// <para> For the MaxCompute and DLF types, use an empty string as the placeholder for the instance ID. For MaxCompute, the database name refers to the MaxCompute project name. If the project has schema enabled, you must specify the schema name. Otherwise, use an empty string as the placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For StarRocks, the catalog identifier is the catalog name. For DLF, it is the catalog ID. Other types do not support the catalog level and you can use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>Examples of ID formats for common types are as follows:</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The instance ID, required when the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered via a connection string.\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>project_name</c>: The MaxCompute project name.\
        /// <c>database_name</c>: The database name.\
        /// <c>schema_name</c>: The schema name. For the MaxCompute type, this is required only if the project has enabled schema; otherwise, use an empty string as a placeholder.\
        /// <c>table_name</c>: The table name.\
        /// <c>column_name</c>: The field name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-column:123456::test_project:default:test_tbl:col1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether the column is a partition key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public bool? PartitionKey { get; set; }

        /// <summary>
        /// <para>The position of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        /// <summary>
        /// <para>Specifies whether the column is a primary key (only supported by MaxCompute).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <para>The table ID. You can refer to the <c>Table</c> object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456::test_project:default:test_tbl</para>
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
