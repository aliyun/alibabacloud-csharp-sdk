// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentTimelineForView : TeaModel {
        [NameInMap("changeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public object Content { get; set; }

        [NameInMap("incidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public ContactForIncidentView Operator { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("timelineUuid")]
        [Validation(Required=false)]
        public string TimelineUuid { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
