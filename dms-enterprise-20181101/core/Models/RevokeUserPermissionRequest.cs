// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RevokeUserPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The database ID. The database can be a physical database or a logical database.</para>
        /// <list type="bullet">
        /// <item><description>To query the ID of a physical database, call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
        /// <item><description>To query the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1860****</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// <para>The type of the object on which you want to revoke permissions from a user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: instances.</description></item>
        /// <item><description><b>DATABASE</b>: physical databases.</description></item>
        /// <item><description><b>LOGIC_DATABASE</b>: logical databases.</description></item>
        /// <item><description><b>TABLE</b>: physical tables.</description></item>
        /// <item><description><b>LOGIC_TABLE</b>: logical tables.</description></item>
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
        /// <para>The database instance ID. You must specify this parameter if you revoke a permission from the database instance. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the ID of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The database is a logical database.</description></item>
        /// <item><description><b>false</b>: The database is a physical database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the database is a logical database, set this parameter to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>If the database is a physical database, set this parameter to <b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// <para>The type of the permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>QUERY</b>: query permissions.</description></item>
        /// <item><description><b>EXPORT</b>: export permissions.</description></item>
        /// <item><description><b>CORRECT</b>: change permissions.</description></item>
        /// <item><description><b>LOGIN</b>: logon permissions.</description></item>
        /// <item><description><b>PERF</b>: query permissions on the performance details of an instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CORRECT</para>
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// <para>The table ID. You must specify this parameter if you revoke a permission from the table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13****</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The permission ID. You can call the <a href="https://help.aliyun.com/document_detail/146957.html">ListUserPermission</a> operation to query the permission ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>774****</para>
        /// </summary>
        [NameInMap("UserAccessId")]
        [Validation(Required=false)]
        public string UserAccessId { get; set; }

        /// <summary>
        /// <para>The user ID. You can call the <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> or <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> operation to query the ID of the user.</para>
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
