// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SyncDingTypeRequest : TeaModel {
        [NameInMap("DingType")]
        [Validation(Required=false)]
        public string DingType { get; set; }

        [NameInMap("IsDimission")]
        [Validation(Required=false)]
        public string IsDimission { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SyncDingTypeRequestTenantContext TenantContext { get; set; }
        public class SyncDingTypeRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WorkNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
