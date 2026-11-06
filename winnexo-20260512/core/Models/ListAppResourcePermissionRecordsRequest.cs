// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAppResourcePermissionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The tenant filter for cross-tenant users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("granteeId")]
        [Validation(Required=false)]
        public string GranteeId { get; set; }

        /// <summary>
        /// <para>The permission filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("granteeTenantId")]
        [Validation(Required=false)]
        public string GranteeTenantId { get; set; }

        /// <summary>
        /// <para>The principal ID filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("granteeType")]
        [Validation(Required=false)]
        public string GranteeType { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The principal type filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The permission filter.</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app.demo</para>
        /// </summary>
        [NameInMap("resourceKeyPrefix")]
        [Validation(Required=false)]
        public string ResourceKeyPrefix { get; set; }

        /// <summary>
        /// <para>The resource tenant ID. This parameter is fixed to APP_RESOURCE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>The application key or its subpath.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_RESOURCE</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. If omitted, the current tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
