// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent metadata entity ID. You can refer to the responses of the ListDatabases or ListSchemas operation and <a href="https://help.aliyun.com/document_detail/2880092.html">Description of concepts related to metadata entities.</a></para>
        /// <list type="bullet">
        /// <item><description>The parent metadata entity is a database: The format of <c>ParentMetaEntityId</c> is <c>${EntityType}:${Instance ID or encoded URL}:${Catalog Identifier}:${Database Name}</c>. Use an empty string (\<c>&quot;&quot;\\</c>) as a placeholder for any non-existent level.</description></item>
        /// <item><description>The parent metadata entity is a database schema:. The format of <c>ParentMetaEntityId</c> is <c>${EntityType}:${Instance ID or encoded URL}:${Catalog Identifier}:${Database Name}:${Schema Name}</c>. Use an empty string (\<c>&quot;&quot;\\</c>) as a placeholder for any non-existent level.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The schema level in <c>ParentMetaEntityId</c> is supported only for database types that support schemas, such as MaxCompute (with schema enabled), Hologres, PostgreSQL, SQL Server, HybridDB for PostgreSQL, and Oracle.``</para>
        /// </remarks>
        /// <remarks>
        /// <para> For MaxCompute and DLF types, use empty strings as the instance ID. For MaxCompute, the database name is the same as the project name.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For the StarRocks type, the catalog identifier is the catalog name. For the DLF type, it refers to the catalog ID. Other types do not support a catalog-level hierarchy and the catalog identifier must be replaced with an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>Examples of common ParentMetaEntityId formats</para>
        /// <para><c>maxcompute-project:::project_name</c></para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (for MaxCompute projects with schema enabled)</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>hms-database:instance_id::database_name</c></para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The instance ID, required when the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The JDBC connection string that has been URL encoded, required for the data source registered via a connection string.\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>project_name</c>: The MaxCompute project name.\
        /// <c>database_name</c>: The database name.\
        /// <c>schema_name</c>: The schema name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-schema:123456XXX::test_project_with_schema:default
        /// maxcompute-project:123456XXX::test_project_without_schema
        /// dlf-database:123456XXX:test_catalog:test_db
        /// hms-database:c-abc123xxx::test_db
        /// holo-schema:h-abc123xxx::test_db:test_schema
        /// mysql-database:jdbc%3Amysql%3A%2F%2F127.0.0.1%3A3306%2Ftest_db::test_db</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("TableTypes")]
        [Validation(Required=false)]
        public List<string> TableTypes { get; set; }

    }

}
