// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class MetaCategoryTableEntity : TeaModel {
        /// <summary>
        /// <para>For PostgreSQL-compatible databases, specify the database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC-1D123DF554A45AAB</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The name that is used to search for the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@yyy.zzz">xxx@yyy.zzz</a></para>
        /// </summary>
        [NameInMap("DatabaseSearchName")]
        [Validation(Required=false)]
        public string DatabaseSearchName { get; set; }

        /// <summary>
        /// <para>The database ID. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of a logical database.</para>
        /// <remarks>
        /// <para>The value of DatabaseId is that of DbId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values include but are not limited to:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>DRDS</b></description></item>
        /// <item><description><b>OceanBase</b></description></item>
        /// <item><description><b>Mongo</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga_platform_alb</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public int? InstanceId { get; set; }

        /// <summary>
        /// <para>Database name (for PostgreSQL-compatible databases, specify the schema name). You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the name of the database.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the SchemaName of a physical database or call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the SchemaName of a logical database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The schema name of the table, which is required only for SQL Server instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbo</para>
        /// </summary>
        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
