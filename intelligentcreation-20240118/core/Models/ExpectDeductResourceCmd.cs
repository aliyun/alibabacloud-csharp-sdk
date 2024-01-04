// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240118.Models
{
    public class ExpectDeductResourceCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        [NameInMap("subAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
