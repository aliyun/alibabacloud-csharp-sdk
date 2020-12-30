// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcRouteSwitchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Switch")]
        [Validation(Required=false)]
        public DescribeCcRouteSwitchResponseBodySwitch Switch { get; set; }
        public class DescribeCcRouteSwitchResponseBodySwitch : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }
        };

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
