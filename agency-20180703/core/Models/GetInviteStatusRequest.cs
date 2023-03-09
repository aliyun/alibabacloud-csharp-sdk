// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetInviteStatusRequest : TeaModel {
        [NameInMap("InviteStatusList")]
        [Validation(Required=false)]
        public List<GetInviteStatusRequestInviteStatusList> InviteStatusList { get; set; }
        public class GetInviteStatusRequestInviteStatusList : TeaModel {
            [NameInMap("InviteId")]
            [Validation(Required=false)]
            public long? InviteId { get; set; }

        }

    }

}
