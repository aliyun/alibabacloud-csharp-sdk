// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserRequestTenantContext TenantContext { get; set; }
        public class GetUserRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
