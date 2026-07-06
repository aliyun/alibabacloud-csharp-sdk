// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetColumnRequest : TeaModel {
        /// <summary>
        /// <para>The ID. You can obtain this value from the response of the ListColumns operation. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${InstanceID or encoded URL}:${DataCatalogIdentifier}:${DatabaseName}:${SchemaName}:${TableName}:${ColumnName}</c>. Use an empty string as a placeholder for levels that do not exist.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF types, use an empty string as a placeholder for the instance ID. For MaxCompute, the database name is the MaxCompute project name. Projects with the three-layer model enabled must include the schema name. For projects without the three-layer model, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks, the data catalog identifier is the catalog name. For DLF, the data catalog identifier is the catalog ID. Other types do not support the catalog level. Use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following are ID format examples for common types:</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>Other parameters:<br><c>instance_id</c>: The instance ID. This parameter is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This parameter is required when the data source is registered by using a connection string.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name. For MaxCompute, this parameter is required only when the three-layer model is enabled for the project. If the three-layer model is not enabled, use an empty string as a placeholder.<br><c>table_name</c>: The table name.<br><c>column_name</c>: The column name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-column:::project_name:[schema_name]:table_name:column_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
