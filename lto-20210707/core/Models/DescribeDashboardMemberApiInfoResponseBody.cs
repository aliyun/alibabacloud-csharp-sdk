// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeDashboardMemberApiInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDashboardMemberApiInfoResponseBodyData> Data { get; set; }
        public class DescribeDashboardMemberApiInfoResponseBodyData : TeaModel {
            [NameInMap("MemberInfoList")]
            [Validation(Required=false)]
            public List<DescribeDashboardMemberApiInfoResponseBodyDataMemberInfoList> MemberInfoList { get; set; }
            public class DescribeDashboardMemberApiInfoResponseBodyDataMemberInfoList : TeaModel {
                [NameInMap("ApiInvokeCount")]
                [Validation(Required=false)]
                public long? ApiInvokeCount { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
