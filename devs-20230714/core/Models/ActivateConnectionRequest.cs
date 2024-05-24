// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ActivateConnectionRequest : TeaModel {
        [NameInMap("account")]
        [Validation(Required=false)]
        public GitAccount Account { get; set; }

        [NameInMap("credential")]
        [Validation(Required=false)]
        public OAuthCredential Credential { get; set; }

    }

}
