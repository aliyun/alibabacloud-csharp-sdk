// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribePodEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePodEventsResponseBodyResult Result { get; set; }
        public class DescribePodEventsResponseBodyResult : TeaModel {
            [NameInMap("DeployOrderName")]
            [Validation(Required=false)]
            public string DeployOrderName { get; set; }
            [NameInMap("PodEvents")]
            [Validation(Required=false)]
            public List<DescribePodEventsResponseBodyResultPodEvents> PodEvents { get; set; }
            public class DescribePodEventsResponseBodyResultPodEvents : TeaModel {
                public string Action { get; set; }
                public int? Count { get; set; }
                public string EventTime { get; set; }
                public string FirstTimestamp { get; set; }
                public string LastTimestamp { get; set; }
                public string Message { get; set; }
                public string Reason { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
