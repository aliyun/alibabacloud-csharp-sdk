// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTablesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The comment. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order in which the tables are sorted. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: 10. Maximum value: 100.</para>
        /// 
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
        /// <item><description>The parent metadata entity is a database schema: The format of <c>ParentMetaEntityId</c> is <c>${EntityType}:${Instance ID or encoded URL}:${Catalog Identifier}:${Database Name}:${Schema Name}</c>. Use an empty string (\<c>&quot;&quot;\\</c>) as a placeholder for any non-existent level.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The schema level in <c>ParentMetaEntityId</c> is supported only for database services, such as <c>MaxCompute (with schema enabled), Hologres, PostgreSQL, SQL Server, HybridDB for PostgreSQL, and Oracle</c>.</para>
        /// </description></item>
        /// <item><description><para>For the MaxCompute and DLF types, use an empty string as the placeholder for the instance ID. For MaxCompute, the database name is the same as the project name.</para>
        /// </description></item>
        /// <item><description><para>For StarRocks, the catalog identifier is the catalog name. For DLF, it is the catalog ID. Other types do not support the catalog level and you can use an empty string as a placeholder.</para>
        /// </description></item>
        /// </list>
        /// <para>Examples of common ParentMetaEntityId formats</para>
        /// <list type="bullet">
        /// <item><description><c>maxcompute-project:::project_name</c></description></item>
        /// <item><description><c>maxcompute-schema:::project_name:schema_name</c> (for MaxCompute projects with schema enabled)</description></item>
        /// <item><description><c>dlf-database::catalog_id:database_name</c></description></item>
        /// <item><description><c>hms-database:instance_id::database_name</c></description></item>
        /// <item><description><c>holo-schema:instance_id::database_name:schema_name</c></description></item>
        /// <item><description><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.</para>
        /// </description></item>
        /// <item><description><para><c>encoded_jdbc_url</c>: The URLEncoded JDBC connection string, which is requiredwhen the data source is registered using a connection string.</para>
        /// </description></item>
        /// <item><description><para><c>catalog_id</c>: The DLF catalog ID.</para>
        /// </description></item>
        /// <item><description><para><c>project_name</c>: The MaxCompute project name.</para>
        /// </description></item>
        /// <item><description><para><c>database_name</c>: The database name.</para>
        /// </description></item>
        /// <item><description><para><c>schema_name</c>: The schema name.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The sort field. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime</description></item>
        /// <item><description>ModifyTime</description></item>
        /// <item><description>Name</description></item>
        /// <item><description>TableType</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of table types to query. If it\&quot;s left empty, all types will be queried.</para>
        /// </summary>
        [NameInMap("TableTypes")]
        [Validation(Required=false)]
        public string TableTypesShrink { get; set; }

    }

}
