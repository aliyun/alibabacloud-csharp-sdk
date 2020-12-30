// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultTimelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MediaAuditResultTimeline")]
        [Validation(Required=false)]
        public GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline MediaAuditResultTimeline { get; set; }
        public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline : TeaModel {
            [NameInMap("Live")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive> Live { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive : TeaModel {
                public string Score { get; set; }
                public string Timestamp { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd> Ad { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd : TeaModel {
                public string Score { get; set; }
                public string Timestamp { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo> Logo { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo : TeaModel {
                public string Score { get; set; }
                public string Timestamp { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism> Terrorism { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism : TeaModel {
                public string Score { get; set; }
                public string Timestamp { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("Porn")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn> Porn { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn : TeaModel {
                public string Score { get; set; }
                public string Timestamp { get; set; }
                public string Label { get; set; }
            }
        };

    }

}
