// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SetOwnersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user whom you want to specify as an owner. Separate multiple IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> or <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> operation to query the ID of the user.</para>
        /// <remarks>
        /// <para> The value of the OwnerIds parameter is that of the UserId parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51****</para>
        /// </summary>
        [NameInMap("OwnerIds")]
        [Validation(Required=false)]
        public string OwnerIds { get; set; }

        /// <summary>
        /// <para>The type of the owner. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: an owner of an instance.</description></item>
        /// <item><description>DATABASE: an owner of a physical database.</description></item>
        /// <item><description>LOGIC_DATABASE: an owner of a logical database.</description></item>
        /// <item><description>TABLE: an owner of a physical table.</description></item>
        /// <item><description>LOGIC_TABLE: an owner of a logical table.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The ID of the resource. The ID of the resource varies with the owner type. The owner types and resource IDs have the following mappings:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: the ID of an instance. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> operation to query the ID of the instance.</description></item>
        /// <item><description>DATABASE: the ID of a physical database. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of the physical database.</description></item>
        /// <item><description>LOGIC_DATABASE: the ID of a logical database. You can call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of the logical database.</description></item>
        /// <item><description>TABLE: the ID of a physical table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the ID of the physical table.</description></item>
        /// <item><description>LOGIC_DATABASE: the ID of a logical table. You can call the <a href="https://help.aliyun.com/document_detail/141875.html">ListLogicTables</a> operation to query the ID of the logical table.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

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

    }

}
