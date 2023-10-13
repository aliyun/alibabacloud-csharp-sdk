// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class DeductOutstandingBalanceRequest : TeaModel {
        [NameInMap("DeductAmount")]
        [Validation(Required=false)]
        public string DeductAmount { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
