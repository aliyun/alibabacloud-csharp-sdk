// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class AuthLoginTicketResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LoginTicketDto")]
        [Validation(Required=false)]
        public AuthLoginTicketResponseBodyLoginTicketDto LoginTicketDto { get; set; }
        public class AuthLoginTicketResponseBodyLoginTicketDto : TeaModel {
            [NameInMap("LoginTicket")]
            [Validation(Required=false)]
            public string LoginTicket { get; set; }

        }

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
