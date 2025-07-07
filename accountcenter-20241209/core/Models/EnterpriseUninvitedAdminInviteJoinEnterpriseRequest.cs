// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseUninvitedAdminInviteJoinEnterpriseRequest : TeaModel {
        [NameInMap("EcId")]
        [Validation(Required=false)]
        public string EcId { get; set; }

        [NameInMap("EncryptTicket")]
        [Validation(Required=false)]
        public string EncryptTicket { get; set; }

        [NameInMap("InviteePk")]
        [Validation(Required=false)]
        public string InviteePk { get; set; }

        [NameInMap("LeId")]
        [Validation(Required=false)]
        public string LeId { get; set; }

        [NameInMap("NbId")]
        [Validation(Required=false)]
        public string NbId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
