// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetLinkeBahamutCookieswitchtenantRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("MaxAge")]
        [Validation(Required=false)]
        public string MaxAge { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
