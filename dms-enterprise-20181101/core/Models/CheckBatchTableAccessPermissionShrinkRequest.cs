// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CheckBatchTableAccessPermissionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The database ID. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of a physical database and the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of a logical database.</para>
        /// <remarks>
        /// <para> The value of DatabaseId is that of DbId.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43153</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Logical database.</description></item>
        /// <item><description>false: Physical database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// <para>The type of the permission to be verified.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QUERY</description></item>
        /// <item><description>EXPORT</description></item>
        /// <item><description>CORRECT</description></item>
        /// <item><description>LOGIN</description></item>
        /// <item><description>PERF</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUERY</para>
        /// </summary>
        [NameInMap("PermissionType")]
        [Validation(Required=false)]
        public string PermissionType { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TableNameList")]
        [Validation(Required=false)]
        public string TableNameListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> View Tenant ID by hovering over your profile icon in the DMS console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
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
