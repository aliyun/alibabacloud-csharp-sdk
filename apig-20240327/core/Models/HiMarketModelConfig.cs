// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketModelConfig : TeaModel {
        [NameInMap("modelAPIConfig")]
        [Validation(Required=false)]
        public HiMarketModelConfigModelAPIConfig ModelAPIConfig { get; set; }
        public class HiMarketModelConfigModelAPIConfig : TeaModel {
            [NameInMap("aiProtocols")]
            [Validation(Required=false)]
            public List<string> AiProtocols { get; set; }

            [NameInMap("modelCategory")]
            [Validation(Required=false)]
            public string ModelCategory { get; set; }

            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<HiMarketHttpRoute> Routes { get; set; }

        }

    }

}
