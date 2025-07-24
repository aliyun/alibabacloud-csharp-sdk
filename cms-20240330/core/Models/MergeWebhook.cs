// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeWebhook : TeaModel {
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public Dictionary<string, object> GmtModified { get; set; }

        [NameInMap("headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
