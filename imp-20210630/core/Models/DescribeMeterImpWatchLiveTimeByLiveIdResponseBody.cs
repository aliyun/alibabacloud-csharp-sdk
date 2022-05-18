// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DescribeMeterImpWatchLiveTimeByLiveIdResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImpWatchLiveTimeByLiveIdResponseBodyData> Data { get; set; }
        public class DescribeMeterImpWatchLiveTimeByLiveIdResponseBodyData : TeaModel {
            [NameInMap("WatchTimeInLatency")]
            [Validation(Required=false)]
            public long? WatchTimeInLatency { get; set; }

            [NameInMap("WatchTimeInLowLatency")]
            [Validation(Required=false)]
            public long? WatchTimeInLowLatency { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
