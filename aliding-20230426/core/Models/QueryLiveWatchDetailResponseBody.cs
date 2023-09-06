// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryLiveWatchDetailResponseBody : TeaModel {
        [NameInMap("avgWatchTime")]
        [Validation(Required=false)]
        public long? AvgWatchTime { get; set; }

        [NameInMap("liveUv")]
        [Validation(Required=false)]
        public int? LiveUv { get; set; }

        [NameInMap("msgCount")]
        [Validation(Required=false)]
        public int? MsgCount { get; set; }

        [NameInMap("playbackUv")]
        [Validation(Required=false)]
        public int? PlaybackUv { get; set; }

        [NameInMap("praiseCount")]
        [Validation(Required=false)]
        public int? PraiseCount { get; set; }

        [NameInMap("pv")]
        [Validation(Required=false)]
        public int? Pv { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalWatchTime")]
        [Validation(Required=false)]
        public long? TotalWatchTime { get; set; }

        [NameInMap("uv")]
        [Validation(Required=false)]
        public int? Uv { get; set; }

    }

}
