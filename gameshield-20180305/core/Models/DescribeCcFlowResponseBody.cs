// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcFlowResponseBody : TeaModel {
        [NameInMap("FlowData")]
        [Validation(Required=false)]
        public DescribeCcFlowResponseBodyFlowData FlowData { get; set; }
        public class DescribeCcFlowResponseBodyFlowData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeCcFlowResponseBodyFlowDataItems> Items { get; set; }
            public class DescribeCcFlowResponseBodyFlowDataItems : TeaModel {
                public List<string> Values { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }
            [NameInMap("TimeScope")]
            [Validation(Required=false)]
            public DescribeCcFlowResponseBodyFlowDataTimeScope TimeScope { get; set; }
            public class DescribeCcFlowResponseBodyFlowDataTimeScope : TeaModel {
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

            }
            [NameInMap("CategoriesType")]
            [Validation(Required=false)]
            public string CategoriesType { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
