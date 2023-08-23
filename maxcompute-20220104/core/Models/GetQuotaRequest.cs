// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaRequest : TeaModel {
        [NameInMap("AkProven")]
        [Validation(Required=false)]
        public string AkProven { get; set; }

        [NameInMap("mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
