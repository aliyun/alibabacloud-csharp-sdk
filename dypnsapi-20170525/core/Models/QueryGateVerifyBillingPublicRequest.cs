// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicRequest : TeaModel {
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public int? AuthenticationType { get; set; }

        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
