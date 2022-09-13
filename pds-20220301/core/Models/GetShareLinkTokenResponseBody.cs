// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkTokenResponseBody : TeaModel {
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        [NameInMap("share_token")]
        [Validation(Required=false)]
        public string ShareToken { get; set; }

    }

}
