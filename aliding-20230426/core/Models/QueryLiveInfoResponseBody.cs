// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryLiveInfoResponseBody : TeaModel {
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("liveId")]
        [Validation(Required=false)]
        public int? LiveId { get; set; }

        [NameInMap("livePlayUrl")]
        [Validation(Required=false)]
        public string LivePlayUrl { get; set; }

        [NameInMap("playbackDuration")]
        [Validation(Required=false)]
        public long? PlaybackDuration { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("subscribeCount")]
        [Validation(Required=false)]
        public int? SubscribeCount { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("uv")]
        [Validation(Required=false)]
        public int? Uv { get; set; }

    }

}
