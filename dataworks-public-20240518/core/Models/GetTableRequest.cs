// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID. You can refer to the response of the ListTables operation and the <a href="https://help.aliyun.com/document_detail/2880092.html">concepts related to metadata entities.</a></para>
        /// <para>The format: <c>${EntityType}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}:${Table name}</c>. Use empty strings as placeholders for levels that do not exist.</para>
        /// <remarks>
        /// <para> For the MaxCompute and DLF types, use an empty string as the placeholder for the instance ID.</para>
        /// </remarks>
        /// <remarks>
        /// <para> The catalog identifier of the StarRocks is the catalog name, and the catalog identifier of the DLF type is the catalog ID. Other types do not support the catalog level. Use an empty string as a placeholder.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For MaxCompute, the database name refers to the MaxCompute project name. If the project has schema enabled, you must specify the schema name. Otherwise, use an empty string as the placeholder for the schema name.</para>
        /// </remarks>
        /// <para>Examples of common ID formats</para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The instance ID, required when the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered via a connection string.\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>project_name</c>: The MaxCompute project name.\
        /// <c>database_name</c>: The database name.\
        /// <c>schema_name</c>: The schema name. For the MaxCompute type, this is required only if the project has enabled schema. Otherwise, use an empty string as a placeholder.\
        /// <c>table_name</c>: The table name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456XXX::test_project::test_tbl
        /// dlf-table:123456XXX:test_catalog:test_db::test_tbl
        /// hms-table:c-abc123xxx::test_db::test_tbl
        /// holo-table:h-abc123xxx::test_db:test_schema:test_tbl</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to include metadata. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeBusinessMetadata")]
        [Validation(Required=false)]
        public bool? IncludeBusinessMetadata { get; set; }

    }

}
