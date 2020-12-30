// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeBpsFlowResponseBody : TeaModel {
        [NameInMap("FlowData")]
        [Validation(Required=false)]
        public DescribeBpsFlowResponseBodyFlowData FlowData { get; set; }
        public class DescribeBpsFlowResponseBodyFlowData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeBpsFlowResponseBodyFlowDataItems> Items { get; set; }
            public class DescribeBpsFlowResponseBodyFlowDataItems : TeaModel {
                public List<string> Values { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }
            [NameInMap("TimeScope")]
            [Validation(Required=false)]
            public DescribeBpsFlowResponseBodyFlowDataTimeScope TimeScope { get; set; }
            public class DescribeBpsFlowResponseBodyFlowDataTimeScope : TeaModel {
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
