// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketDomain : TeaModel {
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
