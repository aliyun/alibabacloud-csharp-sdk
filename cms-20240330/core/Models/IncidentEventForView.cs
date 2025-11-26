// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventForView : TeaModel {
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public CmsEventForView Content { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Dimension { get; set; }

        [NameInMap("eventResource")]
        [Validation(Required=false)]
        public EventResourceForIncidentView EventResource { get; set; }

        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupBy { get; set; }

        [NameInMap("incidentEventUuid")]
        [Validation(Required=false)]
        public string IncidentEventUuid { get; set; }

        [NameInMap("incidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        [NameInMap("searchIndex")]
        [Validation(Required=false)]
        public List<string> SearchIndex { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("severityCountMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SeverityCountMap { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        [NameInMap("textIndex")]
        [Validation(Required=false)]
        public string TextIndex { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
