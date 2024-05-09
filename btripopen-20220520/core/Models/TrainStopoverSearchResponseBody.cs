// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStopoverSearchResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<TrainStopoverSearchResponseBodyModule> Module { get; set; }
        public class TrainStopoverSearchResponseBodyModule : TeaModel {
            [NameInMap("arr_time")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("station_name")]
            [Validation(Required=false)]
            public string StationName { get; set; }

            [NameInMap("station_no")]
            [Validation(Required=false)]
            public string StationNo { get; set; }

            [NameInMap("station_type")]
            [Validation(Required=false)]
            public string StationType { get; set; }

            [NameInMap("stop_over_time")]
            [Validation(Required=false)]
            public string StopOverTime { get; set; }

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
