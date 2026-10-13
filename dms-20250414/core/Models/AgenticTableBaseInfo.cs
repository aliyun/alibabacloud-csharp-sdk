// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableBaseInfo : TeaModel {
        /// <summary>
        /// <para>The type of the catalog to which the table belongs. Valid values:</para>
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
        /// <para>The fully qualified name of the database to which the table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_db</para>
        /// </summary>
        [NameInMap("DatabaseQualifiedName")]
        [Validation(Required=false)]
        public string DatabaseQualifiedName { get; set; }

        /// <summary>
        /// <para>The UUID of the database to which the table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The description of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order table</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The engine metadata of the table.</para>
        /// </summary>
        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public AgenticTableEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the table. You can use this name as the TableQualifiedName parameter for GetAgenticTableColumn and GetAgenticTableIndex. For SQL Server, the format is schema name.table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The table type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: regular table</description></item>
        /// <item><description><b>VIEW</b>: view</description></item>
        /// <item><description><b>FOREIGN</b>: foreign table</description></item>
        /// <item><description><b>SYNONYM</b>: synonym, supported only for Oracle data sources</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

    }

}
