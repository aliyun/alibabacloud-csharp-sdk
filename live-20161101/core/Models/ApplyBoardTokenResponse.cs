// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ApplyBoardTokenResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=true)]
        public string Token { get; set; }

        [NameInMap("Expired")]
        [Validation(Required=true)]
        public string Expired { get; set; }

    }

}
