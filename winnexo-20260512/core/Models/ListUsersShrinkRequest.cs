// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListUsersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1182725234319446&quot;]</para>
        /// </summary>
        [NameInMap("accountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the account is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Activated.</description></item>
        /// <item><description><b>false</b>: Not activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// <para>The keyword for product search. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample keyword</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <remarks>
        /// <para>The maximum number of entries per page is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of new system role codes. This is a full replacement and must contain at least one role. Valid values: SUPER_ADMIN, SYSTEM_ADMIN, SEMANTIC_ADMIN, SKILL_ADMIN, KB_ADMIN, AGENT_ADMIN, and APPLICATION_USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;string_value&quot;]</para>
        /// </summary>
        [NameInMap("roleCodes")]
        [Validation(Required=false)]
        public string RoleCodesShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. winnexo-cli explicitly passes this parameter by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
