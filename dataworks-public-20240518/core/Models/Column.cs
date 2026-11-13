// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Column : TeaModel {
        /// <summary>
        /// <para>The business metadata.</para>
        /// </summary>
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public ColumnBusinessMetadata BusinessMetadata { get; set; }
        public class ColumnBusinessMetadata : TeaModel {
            /// <summary>
            /// <para>The custom attribute values, where the key is the custom attribute identifier and the value is a list of attribute values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;owner_name&quot;:[&quot;Zhang San&quot;]}</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The business description of the column. This parameter is supported only by MaxCompute, HMS (EMR clusters), and DLF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business description of column 1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Column 1</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether the column is a foreign key. This parameter is supported only by MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForeignKey")]
        [Validation(Required=false)]
        public bool? ForeignKey { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or URL-encoded JDBC URL}:${Catalog identifier}:${Database name}:${Schema name}:${Table name}:${Column name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF, use an empty string as a placeholder for the instance ID. For MaxCompute, the database name is the MaxCompute project name. If the three-level model is enabled for the project, the schema name is required. Otherwise, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks, the catalog identifier is the catalog name. For DLF, the catalog identifier is the catalog ID. Other types do not support the catalog level, so use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following are the ID formats for several common types:</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name. For MaxCompute, this is required only if the three-level model is enabled for the project. Otherwise, use an empty string as a placeholder.<br><c>table_name</c>: The table name.<br><c>column_name</c>: The column name.</para>
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
        /// <para>Specifies whether the column is a partition key.</para>
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
        /// <para>Specifies whether the column is a primary key. This parameter is supported only by MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <para>The statistical metrics of the column. The key is the metric name and the value is the statistical value in string format. Current metrics include the number of production runs in the last 30 days (prodRunCount30d) and the number of downstream tasks that depend on the column (downstreamTaskCount30d). Metrics without statistical values are not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;prodRunCount30d&quot;: &quot;96&quot;}</para>
        /// </summary>
        [NameInMap("StatisticsInfos")]
        [Validation(Required=false)]
        public Dictionary<string, string> StatisticsInfos { get; set; }

        /// <summary>
        /// <para>The ID of the table. For more information, see the <c>Table</c> object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The technical metadata.</para>
        /// </summary>
        [NameInMap("TechnicalMetadata")]
        [Validation(Required=false)]
        public ColumnTechnicalMetadata TechnicalMetadata { get; set; }
        public class ColumnTechnicalMetadata : TeaModel {
            /// <summary>
            /// <para>The technical parameters of the column. The key is the parameter name and the value is a string. Objects or arrays are represented as JSON strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;keyword&quot;}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

        }

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
