// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DescribeMeterImpWatchTimeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImpWatchTimeResponseBodyData> Data { get; set; }
        public class DescribeMeterImpWatchTimeResponseBodyData : TeaModel {
            [NameInMap("LiveRtcDuration")]
            [Validation(Required=false)]
            public long? LiveRtcDuration { get; set; }

            [NameInMap("LiveRtmpDuration")]
            [Validation(Required=false)]
            public long? LiveRtmpDuration { get; set; }

            [NameInMap("LiveRtsDuration")]
            [Validation(Required=false)]
            public long? LiveRtsDuration { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("VodDuration")]
            [Validation(Required=false)]
            public long? VodDuration { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
