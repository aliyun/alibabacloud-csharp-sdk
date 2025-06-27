// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetColumnRequest : TeaModel {
        /// <summary>
        /// <para>The ID. You can refer to the response of the ListColumns operation and the <a href="https://help.aliyun.com/document_detail/2880092.html">description of concepts related to metadata entities.</a></para>
        /// <para>The format: <c>${EntityType}:${Instance ID or escaped URL}:${Catalog name}:${Database name}</c>. Use empty strings as placeholders for levels that do not exist.</para>
        /// <remarks>
        /// <para> For the MaxCompute and DLF types, the instance ID level must be left empty. For the MaxCompute type, the instance ID level is represented by an empty string. The database name is the name of the MaxCompute project with schema enabled.</para>
        /// </remarks>
        /// <remarks>
        /// <para> The catalog identifier of the StarRocks is the catalog name, and the catalog identifier of the DLF type is the catalog ID. Other types do not support catalog levels and can use empty strings as placeholders.</para>
        /// </remarks>
        /// <para>Examples of common ID formats</para>
        /// <para><c>maxcompute-column:::project_name:[schema_name]:table_name:column_name</c></para>
        /// <para><c>dlf-column::catalog_id:database_name::table_name:column_name</c></para>
        /// <para><c>hms-column:instance_id::database_name::table_name:column_name</c></para>
        /// <para><c>holo-column:instance_id::database_name:schema_name:table_name:column_name</c></para>
        /// <para><c>mysql-column:(instance_id|encoded_jdbc_url)::database_name::table_name:column_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: the ID of the instance, which is required when the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered via a connection string.\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>project_name</c>: The MaxCompute project name.\
        /// <c>database_name</c>: The database name.\
        /// <c>schema_name</c>: The schema name. For the MaxCompute type, this is required only if the project has enabled schema; otherwise, use an empty string as a placeholder.\
        /// <c>table_name</c>: The table name.\
        /// <c>column_name</c>: The field name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-column:11075xxxx::test_project:test_schema:test_table:test_column</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
