// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180701.Models
{
    public class InviteSubAccountRequest : TeaModel {
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public List<InviteSubAccountRequestAccountInfoList> AccountInfoList { get; set; }
        public class InviteSubAccountRequestAccountInfoList : TeaModel {
            [NameInMap("AccountNickname")]
            [Validation(Required=false)]
            public string AccountNickname { get; set; }

            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SubAccountType")]
            [Validation(Required=false)]
            public string SubAccountType { get; set; }

            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

        }

    }

}
