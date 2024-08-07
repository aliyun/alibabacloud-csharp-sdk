// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class HostAlias : TeaModel {
        [NameInMap("hostnames")]
        [Validation(Required=false)]
        public List<string> Hostnames { get; set; }

        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}
