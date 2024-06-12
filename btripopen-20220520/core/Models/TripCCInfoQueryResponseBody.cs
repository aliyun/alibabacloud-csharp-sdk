// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripCCInfoQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module。
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<TripCCInfoQueryResponseBodyModule> Module { get; set; }
        public class TripCCInfoQueryResponseBodyModule : TeaModel {
            [NameInMap("notifier")]
            [Validation(Required=false)]
            public string Notifier { get; set; }

            [NameInMap("notify_start_time")]
            [Validation(Required=false)]
            public long? NotifyStartTime { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
