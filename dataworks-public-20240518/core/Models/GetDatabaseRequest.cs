// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>Database entity ID. You can refer to the response of the ListDatabases operation and <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The format: <c>${EntityType}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}</c>. Use empty strings as placeholders for levels that do not exist.</para>
        /// <remarks>
        /// <para> For StarRocks, the catalog identifier is the catalog name. For DLF, the catalog identifier is the catalog ID. For other types, the catalog-level hierarchy is not supported, and an empty string can be used as a placeholder.</para>
        /// </remarks>
        /// <para>Examples of common ID formats</para>
        /// <list type="bullet">
        /// <item><description><c>dlf-database::catalog_id:database_name</c></description></item>
        /// <item><description><c>holo-database:instance_id::database_name</c></description></item>
        /// <item><description><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>catalog_id</c>: The ID of the DLF catalog.</para>
        /// </description></item>
        /// <item><description><para><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.</para>
        /// </description></item>
        /// <item><description><para><c>encoded_jdbc_url</c>: The encoded JDBC connection string, which is required when the data source is registered in connection-string mode.</para>
        /// </description></item>
        /// <item><description><para><c>database_name</c>: The database name.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql-database:rm-abc123xxx::test_db</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
