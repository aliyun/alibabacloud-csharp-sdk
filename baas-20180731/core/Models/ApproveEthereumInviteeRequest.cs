// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApproveEthereumInviteeRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Invitee")]
        [Validation(Required=false)]
        public List<ApproveEthereumInviteeRequestInvitee> Invitee { get; set; }
        public class ApproveEthereumInviteeRequestInvitee : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
