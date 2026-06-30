// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryGroupLiveInfoResponseBody : TeaModel {
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
        public string LiveId { get; set; }

        [NameInMap("livePlayUrl")]
        [Validation(Required=false)]
        public string LivePlayUrl { get; set; }

        [NameInMap("liveStatus")]
        [Validation(Required=false)]
        public int? LiveStatus { get; set; }

        [NameInMap("playbackDuration")]
        [Validation(Required=false)]
        public long? PlaybackDuration { get; set; }

        [NameInMap("replayUrl")]
        [Validation(Required=false)]
        public string ReplayUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
