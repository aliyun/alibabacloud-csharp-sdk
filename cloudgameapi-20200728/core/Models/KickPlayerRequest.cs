// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class KickPlayerRequest : TeaModel {
        [NameInMap("GameSession")]
        [Validation(Required=false)]
        public string GameSession { get; set; }

        [NameInMap("KickedAccountId")]
        [Validation(Required=false)]
        public string KickedAccountId { get; set; }

    }

}
