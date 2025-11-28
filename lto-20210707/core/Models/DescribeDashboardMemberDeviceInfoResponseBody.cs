// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeDashboardMemberDeviceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDashboardMemberDeviceInfoResponseBodyData> Data { get; set; }
        public class DescribeDashboardMemberDeviceInfoResponseBodyData : TeaModel {
            [NameInMap("MemberInfoList")]
            [Validation(Required=false)]
            public List<DescribeDashboardMemberDeviceInfoResponseBodyDataMemberInfoList> MemberInfoList { get; set; }
            public class DescribeDashboardMemberDeviceInfoResponseBodyDataMemberInfoList : TeaModel {
                [NameInMap("DeviceCount")]
                [Validation(Required=false)]
                public int? DeviceCount { get; set; }

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
