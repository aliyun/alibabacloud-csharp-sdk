// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class DescribeMemberCapacityInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMemberCapacityInfoResponseBodyData> Data { get; set; }
        public class DescribeMemberCapacityInfoResponseBodyData : TeaModel {
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public string UsedCapacity { get; set; }

            [NameInMap("UsedCount")]
            [Validation(Required=false)]
            public string UsedCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
