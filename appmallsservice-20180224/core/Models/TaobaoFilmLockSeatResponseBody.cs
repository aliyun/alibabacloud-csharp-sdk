// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmLockSeatResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SeatLocked")]
        [Validation(Required=false)]
        public TaobaoFilmLockSeatResponseBodySeatLocked SeatLocked { get; set; }
        public class TaobaoFilmLockSeatResponseBodySeatLocked : TeaModel {
            [NameInMap("ApplyKey")]
            [Validation(Required=false)]
            public string ApplyKey { get; set; }

            [NameInMap("DefaultLockSecond")]
            [Validation(Required=false)]
            public long? DefaultLockSecond { get; set; }

            [NameInMap("LockTime")]
            [Validation(Required=false)]
            public long? LockTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
