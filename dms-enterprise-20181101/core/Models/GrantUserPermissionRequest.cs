// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GrantUserPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of a logical database.</para>
        /// <remarks>
        /// <para> The value of the DatabaseId parameter is that of the DbId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1***</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// <para>The permissions on a specific type of object that you want to grant to the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: permissions on instances</description></item>
        /// <item><description>DATABASE: permissions on physical databases</description></item>
        /// <item><description>LOGIC_DATABASE: permissions on logical databases</description></item>
        /// <item><description>TABLE: permissions on physical tables</description></item>
        /// <item><description>LOGIC_TABLE: permissions on logical tables</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATABASE</para>
        /// </summary>
        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// <para>The time when the permissions expire.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-12 00:00:00</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You must specify this parameter if you grant permissions on an instance to the user. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. You must specify this parameter if you grant permissions on a database to the user. Valid values:</para>
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
        /// <para>The permission type. Separate multiple permission types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>QUERY</b>: the query permissions</description></item>
        /// <item><description><b>EXPORT</b>: the export permissions</description></item>
        /// <item><description><b>CORRECT</b>: the change permissions</description></item>
        /// <item><description><b>LOGIN</b>: the logon permissions</description></item>
        /// <item><description><b>PERF</b>: the query permissions on the performance details of the instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUERY</para>
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// <para>The ID of the table. You must specify this parameter if you grant permissions on a table to the user. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132***</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The name of the table. You must specify this parameter if you grant permissions on a table to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
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
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the user. You can call the <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> or <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> operation to query the ID of the user.</para>
        /// <remarks>
        /// <para> The user ID is different from the ID of your Alibaba Cloud account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
