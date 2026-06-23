// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <para>The comment on the table. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the table. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: <c>Asc</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending</para>
        /// </description></item>
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
        /// <para>The page size. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent metadata entity. You can obtain this ID from the response of the ListDatabases or ListSchemas operation. For details, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>The value can be the database to which the table belongs. The format is <c>${EntityType}:${instance ID or URL-encoded connection string}:${data catalog identifier}:${database name}</c>. Use an empty string as a placeholder for a hierarchy level that does not exist.</para>
        /// </description></item>
        /// <item><description><para>The value can also be the schema to which the table belongs. The format is <c>${EntityType}:${instance ID or URL-encoded connection string}:${data catalog identifier}:${database name}:${schema name}</c>. Use an empty string as a placeholder for a hierarchy level that does not exist.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify a schema in <c>ParentMetaEntityId</c> only if the database type supports schemas, such as <c>maxcompute/holo/postgresql/sqlserver/hybriddb_for_postgresql/oracle</c>. For the maxcompute type, the three-layer model must be enabled. Otherwise, you can only specify a database.</para>
        /// </description></item>
        /// <item><description><para>For <c>maxcompute</c> and <c>dlf</c> data types, use an empty string as a placeholder for the instance ID. For the maxcompute data type, the database name is the MaxCompute project name.</para>
        /// </description></item>
        /// <item><description><para>For the <c>starrocks</c> type, the data catalog identifier is the catalog name. For the <c>dlf</c> type, the data catalog identifier is the catalog ID. Other types do not support the catalog level, so you can use an empty string as a placeholder.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>The following list shows the <c>ParentMetaEntityId</c> format for several common data source types:</para>
        /// <list type="bullet">
        /// <item><description><para><c>maxcompute-project:::project_name</c></para>
        /// </description></item>
        /// <item><description><para><c>maxcompute-schema:::project_name:schema_name</c> (Only when the three-layer model is enabled for the project)</para>
        /// </description></item>
        /// <item><description><para><c>dlf-database::catalog_id:database_name</c></para>
        /// </description></item>
        /// <item><description><para><c>hms-database:instance_id::database_name</c></para>
        /// </description></item>
        /// <item><description><para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// </description></item>
        /// <item><description><para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In these formats:</para>
        /// <list type="bullet">
        /// <item><description><para><c>instance_id</c>: The instance ID. This parameter is required if the data source is registered in instance mode.</para>
        /// </description></item>
        /// <item><description><para><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This parameter is required if the data source is registered by using a connection string.</para>
        /// </description></item>
        /// <item><description><para><c>catalog_id</c>: The ID of the DLF data catalog.</para>
        /// </description></item>
        /// <item><description><para><c>project_name</c>: The name of the MaxCompute project.</para>
        /// </description></item>
        /// <item><description><para><c>database_name</c>: The name of the database.</para>
        /// </description></item>
        /// <item><description><para><c>schema_name</c>: The name of the schema.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-project:::project_name</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: <c>CreateTime</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CreateTime</c>: creation time</para>
        /// </description></item>
        /// <item><description><para><c>ModifyTime</c>: modification time</para>
        /// </description></item>
        /// <item><description><para><c>Name</c>: name</para>
        /// </description></item>
        /// <item><description><para><c>TableType</c>: table type</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>A list of table types to query. If you omit this parameter, tables of all types are returned.</para>
        /// </summary>
        [NameInMap("TableTypes")]
        [Validation(Required=false)]
        public List<string> TableTypes { get; set; }

    }

}
