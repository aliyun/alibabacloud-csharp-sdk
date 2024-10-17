// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_name</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The type of the environment to which the database belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>product: production environment</description></item>
        /// <item><description>dev: development environment</description></item>
        /// <item><description>pre: staging environment</description></item>
        /// <item><description>test: test environment</description></item>
        /// <item><description>sit: SIT environment</description></item>
        /// <item><description>uat: user acceptance testing (UAT) environment</description></item>
        /// <item><description>pet: stress testing environment</description></item>
        /// <item><description>stag: STAG environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

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
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The permissions on a specific type of resources that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATABASE: permissions on databases</description></item>
        /// <item><description>TABLE: permissions on tables</description></item>
        /// <item><description>COLUMN: permissions on fields</description></item>
        /// <item><description>INSTANCE: permissions on instances</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATABASE</para>
        /// </summary>
        [NameInMap("PermType")]
        [Validation(Required=false)]
        public string PermType { get; set; }

        /// <summary>
        /// <para>The keyword used in the query. For example, if you want to query permissions on an instance, you can specify the endpoint of the instance, such as rm-bp144d5ky4l4r****.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp144d5ky4l4r****</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

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
