// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the field. You can call the <a href="https://help.aliyun.com/document_detail/141870.html">ListColumns</a> operation to query the name of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_column</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the ID of the database.</para>
        /// <remarks>
        /// <para> You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of the physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of a logical database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1860</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The database is a logical database.</description></item>
        /// <item><description>false: The database is a physical database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the name of the database.</para>
        /// <remarks>
        /// <para> You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the name of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the name of a logical database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SENSITIVE: medium sensitivity level</description></item>
        /// <item><description>CONFIDENTIAL: high sensitivity level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SENSITIVE</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the ID of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
