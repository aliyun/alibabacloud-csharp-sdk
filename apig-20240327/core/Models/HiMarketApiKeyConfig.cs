// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketApiKeyConfig : TeaModel {
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketApiKeyConfigCredentials> Credentials { get; set; }
        public class HiMarketApiKeyConfigCredentials : TeaModel {
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
