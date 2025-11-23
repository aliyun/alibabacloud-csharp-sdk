// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddAuthorityTemplateItemsRequest : TeaModel {
        /// <summary>
        /// <para>The resources that you want to add to the permission template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<AddAuthorityTemplateItemsRequestItems> Items { get; set; }
        public class AddAuthorityTemplateItemsRequestItems : TeaModel {
            /// <summary>
            /// <para>The database ID. Databases are divided into physical databases and logical databases.</para>
            /// <list type="bullet">
            /// <item><description>To query the ID of a physical database, call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
            /// <item><description>To query the ID of a logical database, call the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is required if the ResourceType parameter is set to META_DB, LOGIC_DB, META_TABLE, or LOGIC_TABLE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2478****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the instance ID.</para>
            /// <remarks>
            /// <para>This parameter is required if the ResourceType parameter is set to INSTANCE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>237****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public int? InstanceId { get; set; }

            /// <summary>
            /// <para>The permission types.</para>
            /// </summary>
            [NameInMap("PermissionTypes")]
            [Validation(Required=false)]
            public List<string> PermissionTypes { get; set; }

            /// <summary>
            /// <para>The type of the resource from which you want to remove tags. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTANCE</b>: instance</description></item>
            /// <item><description><b>LOGIC_DB</b>: logical database</description></item>
            /// <item><description><b>META_DB</b>: physical database</description></item>
            /// <item><description><b>LOGIC_TABLE</b>: logical table</description></item>
            /// <item><description><b>LOGIC_TABLE</b>: physical table</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The table name. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the name of the table.</para>
            /// <remarks>
            /// <para>This parameter is required if the ResourceType parameter is set to META_TABLE or LOGIC_TABLE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the permission template. You can call the <a href="https://help.aliyun.com/document_detail/600705.html">CreateAuthorityTemplate</a> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
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
