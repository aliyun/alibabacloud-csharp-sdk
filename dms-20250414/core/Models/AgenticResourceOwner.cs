// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticResourceOwner : TeaModel {
        /// <summary>
        /// <para>The instance alias. This display property comes from the catalog to which the resource belongs and is used only for frontend display to align with the data permission list. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production database</para>
        /// </summary>
        [NameInMap("CatalogAlias")]
        [Validation(Required=false)]
        public string CatalogAlias { get; set; }

        /// <summary>
        /// <para>The instance data source type, used only for frontend display. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("CatalogDataSourceType")]
        [Validation(Required=false)]
        public string CatalogDataSourceType { get; set; }

        /// <summary>
        /// <para>The instance environment type, used only for frontend display. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("CatalogEnvType")]
        [Validation(Required=false)]
        public string CatalogEnvType { get; set; }

        /// <summary>
        /// <para>The instance host, used only for frontend display. Built-in sample data sources are masked as ******. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxxxxxx.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CatalogHost")]
        [Validation(Required=false)]
        public string CatalogHost { get; set; }

        /// <summary>
        /// <para>The instance port, used only for frontend display. Built-in sample data sources are masked as ******. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("CatalogPort")]
        [Validation(Required=false)]
        public string CatalogPort { get; set; }

        /// <summary>
        /// <para>The UUID of the catalog to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-5d9fbt8wW4AnGZNddXg4f</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the instance data source to which the resource belongs. It is used only for frontend display and instance locating. Non-sensitive connection information is not masked. It is populated only in the My Assets or Managed Resources query scenarios and is null in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsc-HZ-3f2b9a7c1d</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the database. It has a value only when ResourceType is DATABASE and is populated by the downstream service, which facilitates direct frontend display. For MySQL, it is the database name itself. For PostgreSQL or SQL Server, it is in the format of DatabaseName.SchemaName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finance.public</para>
        /// </summary>
        [NameInMap("DatabaseQualifiedName")]
        [Validation(Required=false)]
        public string DatabaseQualifiedName { get; set; }

        /// <summary>
        /// <para>The UUID of the database. It has a value only when ResourceType is DATABASE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-vXR1ezNGjiDjiV13Gos1N</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The principal ID of the operator who registered the ownership relationship. The downstream service does not return this field in the My Assets query scenario, and the value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usr_6ieggks7zuy6gpfdmgzsjdso</para>
        /// </summary>
        [NameInMap("GrantBy")]
        [Validation(Required=false)]
        public string GrantBy { get; set; }

        /// <summary>
        /// <para>The source channel of the ownership. CONSOLE indicates manual registration in the console. Other values indicate that the ownership is written by the built-in system. The downstream service does not return this field in the My Assets query scenario, and the value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSOLE</para>
        /// </summary>
        [NameInMap("GrantFrom")]
        [Validation(Required=false)]
        public string GrantFrom { get; set; }

        /// <summary>
        /// <para>The principal ID of the owner. This is the internal principal ID of the gateway with a usr_ or agt_ prefix, not the Alibaba Cloud UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usr_wlwp5a7uruanebg5bbdqqf5n</para>
        /// </summary>
        [NameInMap("OwnerPrincipalId")]
        [Validation(Required=false)]
        public string OwnerPrincipalId { get; set; }

        /// <summary>
        /// <para>The principal type of the owner. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: Human user.</description></item>
        /// <item><description>AGENT: Managed agent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("OwnerPrincipalType")]
        [Validation(Required=false)]
        public string OwnerPrincipalType { get; set; }

        /// <summary>
        /// <para>The ownership level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: Instance-level ownership. The coordinate includes only CatalogUuid.</description></item>
        /// <item><description>DATABASE: Database-level ownership. The coordinate includes CatalogUuid and DatabaseUuid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DATABASE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
