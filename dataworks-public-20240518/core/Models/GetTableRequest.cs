// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID. You can refer to the response of the ListTables operation and <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts of metadata entities</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or URL-encoded JDBC URL}:${Catalog ID}:${Database name}:${Schema name}:${Table name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF, use an empty string as a placeholder for the instance ID.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks, the catalog identifier is the catalog name. For DLF, the catalog identifier is the catalog ID. Other types do not support the catalog level, so you can use an empty string as a placeholder.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For MaxCompute, the database name is the MaxCompute project name. For projects with the three-level model enabled, you must provide the schema name. For projects with the three-level model disabled, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <para>The following are the ID formats for several common types:</para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: the instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_id</c>: the DLF catalog ID.<br><c>project_name</c>: the MaxCompute project name.<br><c>database_name</c>: the database name.<br><c>schema_name</c>: the schema name. For MaxCompute, this is required only when the three-level model is enabled for the project. If it is disabled, use an empty string as a placeholder.<br><c>table_name</c>: the table name.</para>
        /// </remarks>
        /// <para>Recommended process to obtain this parameter: First, call ListCrawlers to obtain the MetaEntityId of the metadata crawler. For types that include the catalog level, such as DLF and StarRocks, call ListCatalogs to obtain the catalog ID. Then, call ListDatabases to obtain the database ID. If necessary, call ListSchemas to obtain the schema ID. Finally, call ListTables to obtain the target table ID, and use the returned table ID as the Id parameter for this API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to include business metadata. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeBusinessMetadata")]
        [Validation(Required=false)]
        public bool? IncludeBusinessMetadata { get; set; }

        /// <summary>
        /// <para>Specifies whether to return extended properties. If you set this parameter to <c>true</c>, extended properties are returned. If you set this parameter to <c>false</c>, extended properties are not returned.</para>
        /// </summary>
        [NameInMap("IncludeExtendedProperties")]
        [Validation(Required=false)]
        public bool? IncludeExtendedProperties { get; set; }

    }

}
