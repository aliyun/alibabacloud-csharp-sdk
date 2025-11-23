// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserOwnedResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_name</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The type of the database instance. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The type of the environment in which the database instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>product</b>: production environment.</description></item>
        /// <item><description><b>dev</b>: development environment.</description></item>
        /// <item><description><b>pre</b>: pre-release environment.</description></item>
        /// <item><description><b>test</b>: test environment.</description></item>
        /// <item><description><b>sit</b>: system integration testing (SIT) environment.</description></item>
        /// <item><description><b>uat</b>: user acceptance testing (UAT) environment.</description></item>
        /// <item><description><b>pet</b>: stress testing environment.</description></item>
        /// <item><description><b>stag</b>: staging environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is a logical database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true.</b>: The database is a logical database</description></item>
        /// <item><description><b>false</b>: The database is a physical database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// <para>The type of the owner. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: an owner of an instance.</description></item>
        /// <item><description>DATABASE: an owner of a physical database.</description></item>
        /// <item><description>TABLE: an owner of a physical table.</description></item>
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
        /// <para>The page number.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1***</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
