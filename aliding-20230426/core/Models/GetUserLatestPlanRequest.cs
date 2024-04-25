// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserLatestPlanRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserLatestPlanRequestTenantContext TenantContext { get; set; }
        public class GetUserLatestPlanRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
