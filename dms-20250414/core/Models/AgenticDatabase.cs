// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabase : TeaModel {
        /// <summary>
        /// <para>The name of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod_mysql_order</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

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
        /// <para>The UUID of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-OfjcNc2z***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The business attributes of the database, returned as key-value pairs. Currently, this may include <b>ENV_TYPE</b>, which indicates the environment type of the database.</para>
        /// </summary>
        [NameInMap("DatabaseBizAttrs")]
        [Validation(Required=false)]
        public Dictionary<string, object> DatabaseBizAttrs { get; set; }

        /// <summary>
        /// <para>The unique identifier of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The database type inherited from the catalog. The value is the uppercase name of the database type, such as MYSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata of the database engine. This field is returned only for databases under a JDBC catalog.</para>
        /// </summary>
        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public AgenticDatabaseEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The name of the database. For databases that distinguish schemas, such as PostgreSQL, this is the schema name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_db</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended properties of the database, returned as key-value pairs. This field is returned only for databases under a DataLake catalog.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the database. For databases that distinguish schemas, such as PostgreSQL, the format is database name.schema name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_db</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The region ID of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The search name of the database. SearchAgenticDatabase matches search keywords against this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_db</para>
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// <para>The status of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: normal</description></item>
        /// <item><description><b>-1</b>: deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The storage location. This field is returned only for databases under a DataLake catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/datalake/order_db/</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
