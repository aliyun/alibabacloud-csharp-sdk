// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChangeColumnSecurityLevelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the field. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> or <a href="https://help.aliyun.com/document_detail/141870.html">ListColumns</a> operation to query the column name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_column</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The database ID. The database can be a physical database or a logical database.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a physical database: You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the physical database ID.</description></item>
        /// <item><description>To obtain the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>325**</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The database is a logical database</description></item>
        /// <item><description><b>false</b>: The database is a physical database.</description></item>
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
        /// <para>The new security level of the column. The valid values are the same as the sensitivity levels of the classification template that is associated with the instance. You can call the <a href="https://help.aliyun.com/document_detail/2539519.html">ListSensitivityLevel</a> operation to obtain the sensitivity levels of the classification template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S2</para>
        /// </summary>
        [NameInMap("NewSensitivityLevel")]
        [Validation(Required=false)]
        public string NewSensitivityLevel { get; set; }

        /// <summary>
        /// <para>The database name. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the database name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the name of a physical database and call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the name of a logical database.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> or <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table name.</para>
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
        /// <para>To view the tenant ID, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
