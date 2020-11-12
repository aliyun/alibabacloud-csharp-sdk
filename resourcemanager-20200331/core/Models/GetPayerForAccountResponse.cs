// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetPayerForAccountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PayerAccountId")]
        [Validation(Required=true)]
        public string PayerAccountId { get; set; }

        [NameInMap("PayerAccountName")]
        [Validation(Required=true)]
        public string PayerAccountName { get; set; }

    }

}
