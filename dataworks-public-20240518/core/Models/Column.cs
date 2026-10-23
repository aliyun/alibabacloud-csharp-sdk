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
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The business description of the column. This is supported only by MaxCompute, HMS (EMR cluster), and DLF types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business description of Column 1</para>
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
        /// <para>Indicates whether the column is a foreign key. This is supported only by the MaxCompute type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForeignKey")]
        [Validation(Required=false)]
        public bool? ForeignKey { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or URL-encoded URL}:${Data catalog identifier}:${Database name}:${Schema name}:${Table name}:${Column name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF types, use an empty string as a placeholder for the instance ID. For the MaxCompute type, the database name is the MaxCompute project name. Projects with the three-tier model enabled must provide the schema name. For projects without the three-tier model enabled, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For the StarRocks type, the data catalog identifier is the catalog name. For the DLF type, the data catalog identifier is the catalog ID. Other types do not support the catalog level, and an empty string can be used as a placeholder.</para>
        /// </remarks>
        /// <para>The ID formats for several common types are as follows:</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name. For the MaxCompute type, this is required only if the three-tier model is enabled for the project. Otherwise, use an empty string as a placeholder.<br><c>table_name</c>: The table name.<br><c>column_name</c>: The column name.</para>
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
        /// <para>Indicates whether the column is a partition key.</para>
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
        /// <para>Indicates whether the column is a primary key. This is supported only by the MaxCompute type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <para>The statistical metrics of the column, where the key is the metric name and the value is the statistical value in string format. Current metrics include the number of production runs in the last 30 days (prodRunCount30d) and the number of downstream dependent tasks (downstreamTaskCount30d). Metrics without statistical values are not returned.</para>
        /// </summary>
        [NameInMap("StatisticsInfos")]
        [Validation(Required=false)]
        public Dictionary<string, string> StatisticsInfos { get; set; }

        /// <summary>
        /// <para>The table ID. For more information, see the <c>Table</c> object.</para>
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
            /// <para>The technical parameters of the column, where the key is the parameter name and the value is a string. Objects or arrays are represented as JSON strings.</para>
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
