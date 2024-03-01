// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240118.Models
{
    public class GetRemainResourceRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("subAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

    }

}
