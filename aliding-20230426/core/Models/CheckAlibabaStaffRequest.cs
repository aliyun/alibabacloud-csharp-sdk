// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CheckAlibabaStaffRequest : TeaModel {
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CheckAlibabaStaffRequestTenantContext TenantContext { get; set; }
        public class CheckAlibabaStaffRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
