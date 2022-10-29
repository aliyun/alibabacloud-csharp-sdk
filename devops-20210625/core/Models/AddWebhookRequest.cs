// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class AddWebhookRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enableSslVerification")]
        [Validation(Required=false)]
        public bool? EnableSslVerification { get; set; }

        [NameInMap("mergeRequestsEvents")]
        [Validation(Required=false)]
        public bool? MergeRequestsEvents { get; set; }

        [NameInMap("noteEvents")]
        [Validation(Required=false)]
        public bool? NoteEvents { get; set; }

        [NameInMap("pushEvents")]
        [Validation(Required=false)]
        public bool? PushEvents { get; set; }

        [NameInMap("secretToken")]
        [Validation(Required=false)]
        public string SecretToken { get; set; }

        [NameInMap("tagPushEvents")]
        [Validation(Required=false)]
        public bool? TagPushEvents { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
