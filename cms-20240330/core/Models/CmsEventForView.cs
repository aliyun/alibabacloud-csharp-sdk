// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsEventForView : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, object> Annotations { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        [NameInMap("datacontenttype")]
        [Validation(Required=false)]
        public string Datacontenttype { get; set; }

        [NameInMap("dataschema")]
        [Validation(Required=false)]
        public string Dataschema { get; set; }

        [NameInMap("dedupId")]
        [Validation(Required=false)]
        public string DedupId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("integrationUuid")]
        [Validation(Required=false)]
        public string IntegrationUuid { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("receiveTime")]
        [Validation(Required=false)]
        public long? ReceiveTime { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public EventResourceForEventView Resource { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("sourcetype")]
        [Validation(Required=false)]
        public string Sourcetype { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("subtype")]
        [Validation(Required=false)]
        public string Subtype { get; set; }

        [NameInMap("sysId")]
        [Validation(Required=false)]
        public string SysId { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("workspaceTags")]
        [Validation(Required=false)]
        public Dictionary<string, object> WorkspaceTags { get; set; }

    }

}
