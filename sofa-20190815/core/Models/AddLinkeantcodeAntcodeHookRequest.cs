// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeantcodeAntcodeHookRequest : TeaModel {
        [NameInMap("BuildEvents")]
        [Validation(Required=false)]
        public string BuildEvents { get; set; }

        [NameInMap("EnableSslVerification")]
        [Validation(Required=false)]
        public string EnableSslVerification { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IssuesEvents")]
        [Validation(Required=false)]
        public string IssuesEvents { get; set; }

        [NameInMap("MergeRequestsEvents")]
        [Validation(Required=false)]
        public string MergeRequestsEvents { get; set; }

        [NameInMap("NoteEvents")]
        [Validation(Required=false)]
        public string NoteEvents { get; set; }

        [NameInMap("PushEvents")]
        [Validation(Required=false)]
        public string PushEvents { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("TagPushEvents")]
        [Validation(Required=false)]
        public string TagPushEvents { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
