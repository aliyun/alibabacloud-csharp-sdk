// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetOuterCallCenterDataListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOuterCallCenterDataListResponseBodyData> Data { get; set; }
        public class GetOuterCallCenterDataListResponseBodyData : TeaModel {
            [NameInMap("Acid")]
            [Validation(Required=false)]
            public string Acid { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CallType")]
            [Validation(Required=false)]
            public string CallType { get; set; }

            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public string EndReason { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("FromPhoneNum")]
            [Validation(Required=false)]
            public string FromPhoneNum { get; set; }

            [NameInMap("InterveneTime")]
            [Validation(Required=false)]
            public string InterveneTime { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("ToPhoneNum")]
            [Validation(Required=false)]
            public string ToPhoneNum { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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
