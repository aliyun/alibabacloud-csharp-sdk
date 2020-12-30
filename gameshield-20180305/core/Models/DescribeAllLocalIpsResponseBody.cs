// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeAllLocalIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LocalIps")]
        [Validation(Required=false)]
        public DescribeAllLocalIpsResponseBodyLocalIps LocalIps { get; set; }
        public class DescribeAllLocalIpsResponseBodyLocalIps : TeaModel {
            [NameInMap("Bgp")]
            [Validation(Required=false)]
            public List<string> Bgp { get; set; }
            [NameInMap("Gf")]
            [Validation(Required=false)]
            public List<string> Gf { get; set; }
        };

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
