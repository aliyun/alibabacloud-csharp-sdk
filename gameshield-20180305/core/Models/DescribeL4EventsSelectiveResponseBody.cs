// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeL4EventsSelectiveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EsnL4EventList")]
        [Validation(Required=false)]
        public List<DescribeL4EventsSelectiveResponseBodyEsnL4EventList> EsnL4EventList { get; set; }
        public class DescribeL4EventsSelectiveResponseBodyEsnL4EventList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("TargetRegion")]
            [Validation(Required=false)]
            public string TargetRegion { get; set; }

            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("AttackSrc")]
            [Validation(Required=false)]
            public string AttackSrc { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("AttackTime")]
            [Validation(Required=false)]
            public long? AttackTime { get; set; }

            [NameInMap("MaxAttack")]
            [Validation(Required=false)]
            public long? MaxAttack { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
