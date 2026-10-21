// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticCatalog : TeaModel {
        /// <summary>
        /// <para>The business attributes of the catalog, returned as key-value pairs. The following keys may be included:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIAS</b>: the alias of the data source</description></item>
        /// <item><description><b>HOST</b>: the endpoint of the data source</description></item>
        /// <item><description><b>PORT</b>: the connection port of the data source</description></item>
        /// <item><description><b>ENV_TYPE</b>: the environment type of the data source</description></item>
        /// <item><description><b>VERSION</b>: the database version of the data source</description></item>
        /// <item><description><b>SYNC_ALIAS</b>: whether automatic synchronization of instance aliases is enabled</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CatalogBizAttrs")]
        [Validation(Required=false)]
        public Dictionary<string, object> CatalogBizAttrs { get; set; }

        /// <summary>
        /// <para>The type of the catalog. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JDBC</b>: relational database catalog</description></item>
        /// <item><description><b>DataLake</b>: data lake catalog</description></item>
        /// <item><description><b>Dataset</b>: knowledge base catalog</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JDBC</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-OfjcNc2z***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The unique identifier of the data source associated with the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-HZ-Xk2Pq9Lm***</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// <para>The database type of the data source associated with the catalog. The value is the uppercase name of the database type, such as MYSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The description of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order production database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod_mysql_order</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended properties of the catalog, returned as key-value pairs.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The region ID of the data source associated with the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the catalog. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Normal. This value is set when the data source is created.</description></item>
        /// <item><description><b>-1</b>: Deleted. This value is set when the data source is deleted.</description></item>
        /// </list>
        /// <para>Disabling a data source does not change the status of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The storage location. This property is returned only for catalogs of the DataLake type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/datalake/</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
