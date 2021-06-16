// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeCdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeCdnUserConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("ArgValue")]
            [Validation(Required=false)]
            public string ArgValue { get; set; }

            [NameInMap("ArgName")]
            [Validation(Required=false)]
            public string ArgName { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

    }

}
