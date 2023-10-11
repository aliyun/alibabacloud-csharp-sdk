// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RecallHonorRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public RecallHonorRequestTenantContext TenantContext { get; set; }
        public class RecallHonorRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
