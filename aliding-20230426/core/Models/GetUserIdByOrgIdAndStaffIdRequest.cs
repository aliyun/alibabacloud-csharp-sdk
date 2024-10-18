// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserIdByOrgIdAndStaffIdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserIdByOrgIdAndStaffIdRequestTenantContext TenantContext { get; set; }
        public class GetUserIdByOrgIdAndStaffIdRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
