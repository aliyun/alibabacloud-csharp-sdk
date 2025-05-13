// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentTimeline : TeaModel {
        [NameInMap("childType")]
        [Validation(Required=false)]
        public string ChildType { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("incidentTimelineId")]
        [Validation(Required=false)]
        public string IncidentTimelineId { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("timelineId")]
        [Validation(Required=false)]
        public string TimelineId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
