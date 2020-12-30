// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcTunnelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("CcTunnel")]
        [Validation(Required=false)]
        public DescribeCcTunnelResponseBodyCcTunnel CcTunnel { get; set; }
        public class DescribeCcTunnelResponseBodyCcTunnel : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("OnlyAllow")]
            [Validation(Required=false)]
            public bool? OnlyAllow { get; set; }
            [NameInMap("Gray")]
            [Validation(Required=false)]
            public int? Gray { get; set; }
        };

    }

}
