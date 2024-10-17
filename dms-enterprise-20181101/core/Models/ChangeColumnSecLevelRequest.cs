// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChangeColumnSecLevelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the field. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> operation to obtain the name of the field.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141870.html">ListColumns</a> operation to obtain the name of the field.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_column</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the ID of the database.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to obtain the ID of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to obtain the ID of a logical database.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>325</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The database is a physical database.</description></item>
        /// <item><description>false: The database is a logical database.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLogic")]
        [Validation(Required=false)]
        public bool? IsLogic { get; set; }

        /// <summary>
        /// <para>The new sensitivity level of the field that you want to specify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INNER: low sensitivity level</description></item>
        /// <item><description>SENSITIVE: medium sensitivity level</description></item>
        /// <item><description>CONFIDENTIAL: high sensitivity level</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SENSITIVE</para>
        /// </summary>
        [NameInMap("NewLevel")]
        [Validation(Required=false)]
        public string NewLevel { get; set; }

        /// <summary>
        /// <para>The name of the database. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> operation to obtain the name of the database.</para>
        /// <list type="bullet">
        /// <item><description>You can also call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the name of the database.</description></item>
        /// <item><description>You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to obtain the name of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to obtain the name of a logical database.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> operation to obtain the name of the table.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to obtain the name of the table.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        /// <para>To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>43253</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
