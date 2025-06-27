// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>Database entity ID. You can refer to the response of the ListDatabases operation and <a href="https://help.aliyun.com/document_detail/2880092.html">the description of metadata entity concepts.</a></para>
        /// <para>The format is <c>${EntityType}:${Instance ID or encoded URL}:${Catalog identifier}:${Database name}</c>. Use empty strings as placeholders for non-existent levels.</para>
        /// <remarks>
        /// <para> For StarRocks, the catalog identifier is the catalog name. For DLF, the catalog identifier is the catalog ID. For other types, catalog hierarchy is not supported, and an empty string can be used as a placeholder.</para>
        /// </remarks>
        /// <para>Examples of common ID formats</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>holo-database:instance_id::database_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para> Parameter descriptions\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>instance_id</c>: The instance ID, required for a data source registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The JDBC connection string that has been URL encoded. This parameter is required for the data source registered via a connection string.\
        /// <c>database_name</c>: The database name.</para>
        /// </remarks>
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
