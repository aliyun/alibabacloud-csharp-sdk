// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class RefreshTokenRequest : TeaModel {
        [NameInMap("accessTokenExpirationTime")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationTime { get; set; }

        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
