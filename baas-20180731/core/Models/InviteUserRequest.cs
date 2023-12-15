// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class InviteUserRequest : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("UserEmail")]
        [Validation(Required=false)]
        public string UserEmail { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
