// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <para>The comment. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether to return extended properties. If this parameter is set to <c>true</c>, extended properties are returned. If this parameter is set to <c>false</c>, extended properties are not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeExtendedProperties")]
        [Validation(Required=false)]
        public bool? IncludeExtendedProperties { get; set; }

        /// <summary>
        /// <para>The name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order</description></item>
        /// <item><description>Desc: descending order</description></item>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent metadata entity. You can refer to the response of the ListDatabases or ListSchemas operation, or see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>The parent entity can be the database to which the table belongs. The <c>ParentMetaEntityId</c> format is <c>${EntityType}:${Instance ID or URL-encoded JDBC URL}:${Data catalog identifier}:${Database name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// </description></item>
        /// <item><description><para>The parent entity can also be the database schema to which the table belongs. The <c>ParentMetaEntityId</c> format is <c>${EntityType}:${Instance ID or URL-encoded JDBC URL}:${Data catalog identifier}:${Database name}:${Schema name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The database schema can be used for <c>ParentMetaEntityId</c> only when the database type supports schemas (<c>maxcompute</c>, <c>holo</c>, <c>postgresql</c>, <c>sqlserver</c>, <c>hybriddb_for_postgresql</c>, or <c>oracle</c>). For MaxCompute, the three-level model must be enabled. Otherwise, only the database can be used.</description></item>
        /// <item><description>For MaxCompute and DLF types, use an empty string as a placeholder for the instance ID. For MaxCompute, the database name is the MaxCompute project name.</description></item>
        /// <item><description>For StarRocks, the data catalog identifier is the catalog name. For DLF, the data catalog identifier is the catalog ID. Other types do not support the catalog level, so use an empty string as a placeholder.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Examples of <c>ParentMetaEntityId</c> formats for common types:</para>
        /// <list type="bullet">
        /// <item><description><para><c>maxcompute-project:::project_name</c></para>
        /// </description></item>
        /// <item><description><para><c>maxcompute-schema:::project_name:schema_name</c> (only when the three-level model is enabled for the project)</para>
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
        /// <para>Where:  </para>
        /// <list type="bullet">
        /// <item><description><c>instance_id</c>: the instance ID, which is required when the data source is registered in instance mode.</description></item>
        /// <item><description><c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered by using a connection string.</description></item>
        /// <item><description><c>catalog_id</c>: the DLF catalog ID.</description></item>
        /// <item><description><c>project_name</c>: the MaxCompute project name.</description></item>
        /// <item><description><c>database_name</c>: the database name.</description></item>
        /// <item><description><c>schema_name</c>: the schema name.</description></item>
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
        /// <para>The field used for sorting. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: creation time</description></item>
        /// <item><description>ModifyTime: modification time</description></item>
        /// <item><description>Name: name</description></item>
        /// <item><description>TableType: table type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of table types to query. If this parameter is left empty, all table types are queried.</para>
        /// </summary>
        [NameInMap("TableTypes")]
        [Validation(Required=false)]
        public List<string> TableTypes { get; set; }

    }

}
