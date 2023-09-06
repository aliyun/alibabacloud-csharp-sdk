// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DeleteLiveRequest : TeaModel {
        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public DeleteLiveRequestTenantContext TenantContext { get; set; }
        public class DeleteLiveRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
