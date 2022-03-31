// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeDcdnUserConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("ArgName")]
            [Validation(Required=false)]
            public string ArgName { get; set; }

            [NameInMap("ArgValue")]
            [Validation(Required=false)]
            public string ArgValue { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
