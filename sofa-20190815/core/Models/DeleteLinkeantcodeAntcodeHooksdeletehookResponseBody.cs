// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteLinkeantcodeAntcodeHooksdeletehookResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PushEvents")]
        [Validation(Required=false)]
        public bool? PushEvents { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("TagPushEvents")]
        [Validation(Required=false)]
        public bool? TagPushEvents { get; set; }

        [NameInMap("IssuesEvents")]
        [Validation(Required=false)]
        public bool? IssuesEvents { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("MergeRequestsEvents")]
        [Validation(Required=false)]
        public bool? MergeRequestsEvents { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("BuildEvents")]
        [Validation(Required=false)]
        public bool? BuildEvents { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("EnableSslVerification")]
        [Validation(Required=false)]
        public bool? EnableSslVerification { get; set; }

        [NameInMap("NoteEvents")]
        [Validation(Required=false)]
        public bool? NoteEvents { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
