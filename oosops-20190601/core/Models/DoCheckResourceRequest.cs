// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class DoCheckResourceRequest : TeaModel {
        [NameInMap("bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("gmtWakeup")]
        [Validation(Required=false)]
        public string GmtWakeup { get; set; }

        [NameInMap("hid")]
        [Validation(Required=false)]
        public int? Hid { get; set; }

        [NameInMap("interrupt")]
        [Validation(Required=false)]
        public bool? Interrupt { get; set; }

        [NameInMap("invoker")]
        [Validation(Required=false)]
        public string Invoker { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("taskExtraData")]
        [Validation(Required=false)]
        public string TaskExtraData { get; set; }

        [NameInMap("taskIdentifier")]
        [Validation(Required=false)]
        public string TaskIdentifier { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
