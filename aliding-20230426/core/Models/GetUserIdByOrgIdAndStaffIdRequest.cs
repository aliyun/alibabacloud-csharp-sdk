// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserIdByOrgIdAndStaffIdRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserIdByOrgIdAndStaffIdRequestTenantContext TenantContext { get; set; }
        public class GetUserIdByOrgIdAndStaffIdRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
