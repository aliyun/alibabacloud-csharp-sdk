// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticResourceOwner : TeaModel {
        /// <summary>
        /// <para>The UUID of the Catalog to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-5d9fbt8wW4AnGZNddXg4f</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The qualified name of the database. This field has a value only when ResourceType is DATABASE and the downstream backfills the value. This field is provided for direct display on the frontend. For MySQL, this is the database name itself. For PostgreSQL or SQL Server, this is in the format of DatabaseName.SchemaName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finance.public</para>
        /// </summary>
        [NameInMap("DatabaseQualifiedName")]
        [Validation(Required=false)]
        public string DatabaseQualifiedName { get; set; }

        /// <summary>
        /// <para>The UUID of the database. This field has a value only when ResourceType is DATABASE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-vXR1ezNGjiDjiV13Gos1N</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The principal ID of the operator who registered this ownership relationship. In the &quot;My Assets&quot; scenario, the downstream does not return this field, and the value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usr_6ieggks7zuy6gpfdmgzsjdso</para>
        /// </summary>
        [NameInMap("GrantBy")]
        [Validation(Required=false)]
        public string GrantBy { get; set; }

        /// <summary>
        /// <para>The source channel of the ownership. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONSOLE: Manually registered in the console.</description></item>
        /// <item><description>Other values: Written by the system built-in ownership mechanism.</description></item>
        /// </list>
        /// <para>In the &quot;My Assets&quot; scenario, the downstream does not return this field, and the value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSOLE</para>
        /// </summary>
        [NameInMap("GrantFrom")]
        [Validation(Required=false)]
        public string GrantFrom { get; set; }

        /// <summary>
        /// <para>The Owner principal ID. This is a gateway internal principal ID with the usr_ or agt_ prefix, not an Alibaba Cloud UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usr_wlwp5a7uruanebg5bbdqqf5n</para>
        /// </summary>
        [NameInMap("OwnerPrincipalId")]
        [Validation(Required=false)]
        public string OwnerPrincipalId { get; set; }

        /// <summary>
        /// <para>The Owner principal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: Human user.</description></item>
        /// <item><description>AGENT: Managed Agent.</description></item>
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
        /// <item><description>INSTANCE: Instance-level ownership. The coordinate contains only CatalogUuid.</description></item>
        /// <item><description>DATABASE: Database-level ownership. The coordinate contains CatalogUuid + DatabaseUuid.</description></item>
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
