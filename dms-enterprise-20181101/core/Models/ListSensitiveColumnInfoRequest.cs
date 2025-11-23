// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnInfoRequest : TeaModel {
        /// <summary>
        /// <para>The name of the sensitive field. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> operation to query the name of the sensitive field.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141870.html">ListColumns</a> operation to query the name of the sensitive field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_column</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public int? InstanceId { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>The database name. You can also call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the name of the database.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the value of the SchemaName parameter of a physical database, or the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the value of the SchemaName parameter of a logical database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/188103.html">ListSensitiveColumns</a> operation to query the table name.</para>
        /// <remarks>
        /// <para>You can also call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table name.</para>
        /// </remarks>
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
        /// <para>To view the ID of the tenant, go to the DMS console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
