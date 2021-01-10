// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RemoveLinkeBahamutBuildconfigregistryRequest : TeaModel {
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("SecretKeysRepeatList")]
        [Validation(Required=false)]
        public List<string> SecretKeysRepeatList { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
