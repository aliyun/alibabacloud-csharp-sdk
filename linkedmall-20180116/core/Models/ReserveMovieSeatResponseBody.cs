// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ReserveMovieSeatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("ReservedSeat")]
        [Validation(Required=false)]
        public ReserveMovieSeatResponseBodyReservedSeat ReservedSeat { get; set; }
        public class ReserveMovieSeatResponseBodyReservedSeat : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ReservedTime")]
            [Validation(Required=false)]
            public long? ReservedTime { get; set; }
            [NameInMap("DefaultLockSecond")]
            [Validation(Required=false)]
            public long? DefaultLockSecond { get; set; }
            [NameInMap("ApplyKey")]
            [Validation(Required=false)]
            public string ApplyKey { get; set; }
        };

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
