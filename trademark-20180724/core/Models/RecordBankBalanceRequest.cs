// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class RecordBankBalanceRequest : TeaModel {
        [NameInMap("ActionDate")]
        [Validation(Required=false)]
        public long? ActionDate { get; set; }

        [NameInMap("Balance")]
        [Validation(Required=false)]
        public string Balance { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

    }

}
