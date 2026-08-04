// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class BatchQueryAgAccountResponseBody : TeaModel {
        [NameInMap("AgAccounts")]
        [Validation(Required=false)]
        public List<BatchQueryAgAccountResponseBodyAgAccounts> AgAccounts { get; set; }
        public class BatchQueryAgAccountResponseBodyAgAccounts : TeaModel {
            [NameInMap("LoginEmail")]
            [Validation(Required=false)]
            public string LoginEmail { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("ShowNickName")]
            [Validation(Required=false)]
            public string ShowNickName { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
