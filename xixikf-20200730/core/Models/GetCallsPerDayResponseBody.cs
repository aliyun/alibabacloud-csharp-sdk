// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetCallsPerDayResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallsPerDayResponseBodyData Data { get; set; }
        public class GetCallsPerDayResponseBodyData : TeaModel {
            [NameInMap("CallsPerdayResponseList")]
            [Validation(Required=false)]
            public List<GetCallsPerDayResponseBodyDataCallsPerdayResponseList> CallsPerdayResponseList { get; set; }
            public class GetCallsPerDayResponseBodyDataCallsPerdayResponseList : TeaModel {
                public string CallInCnt { get; set; }
                public string CallOutCnt { get; set; }
                public string DataId { get; set; }
                public string HourId { get; set; }
                public string MinuteId { get; set; }
                public string PhoneNum { get; set; }
                public string TenantId { get; set; }
                public string TenantName { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public string PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
