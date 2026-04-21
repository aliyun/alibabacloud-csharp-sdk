// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHmacConfig : TeaModel {
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketHmacConfigCredentials> Credentials { get; set; }
        public class HiMarketHmacConfigCredentials : TeaModel {
            [NameInMap("ak")]
            [Validation(Required=false)]
            public string Ak { get; set; }

            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("sk")]
            [Validation(Required=false)]
            public string Sk { get; set; }

        }

    }

}
