// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RegisterAppResourcePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The newly created or idempotently matched permission records.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<RegisterAppResourcePermissionsResponseBodyRecords> Records { get; set; }
        public class RegisterAppResourcePermissionsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-31T23:59:59+08:00</para>
            /// </summary>
            [NameInMap("expireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <para>The platform user ID of the grantor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10086</para>
            /// </summary>
            [NameInMap("grantedBy")]
            [Validation(Required=false)]
            public string GrantedBy { get; set; }

            /// <summary>
            /// <para>The principal ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10086</para>
            /// </summary>
            [NameInMap("granteeId")]
            [Validation(Required=false)]
            public string GranteeId { get; set; }

            /// <summary>
            /// <para>The principal name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("granteeName")]
            [Validation(Required=false)]
            public string GranteeName { get; set; }

            /// <summary>
            /// <para>The tenant to which the cross-tenant USER belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("granteeTenantId")]
            [Validation(Required=false)]
            public string GranteeTenantId { get; set; }

            /// <summary>
            /// <para>The principal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("granteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>The permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP/VIEW</para>
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>The permission record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("permissionId")]
            [Validation(Required=false)]
            public long? PermissionId { get; set; }

            /// <summary>
            /// <para>The resource key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_RESOURCE</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
