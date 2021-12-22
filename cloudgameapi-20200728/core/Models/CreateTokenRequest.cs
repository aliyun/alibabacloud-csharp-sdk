// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CreateTokenRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CurrentToken")]
        [Validation(Required=false)]
        public string CurrentToken { get; set; }

        [NameInMap("Session")]
        [Validation(Required=false)]
        public string Session { get; set; }

    }

}
