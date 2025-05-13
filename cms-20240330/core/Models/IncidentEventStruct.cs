// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventStruct : TeaModel {
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dimension { get; set; }

        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, string> GroupBy { get; set; }

        [NameInMap("incidentEventId")]
        [Validation(Required=false)]
        public string IncidentEventId { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public Dictionary<string, string> Resource { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
