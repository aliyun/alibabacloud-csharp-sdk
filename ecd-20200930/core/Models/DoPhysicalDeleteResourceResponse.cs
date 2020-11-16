// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DoPhysicalDeleteResourceResponse : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=true)]
        public string Bid { get; set; }

        [NameInMap("Country")]
        [Validation(Required=true)]
        public string Country { get; set; }

        [NameInMap("Hid")]
        [Validation(Required=true)]
        public long Hid { get; set; }

        [NameInMap("Interrupt")]
        [Validation(Required=true)]
        public bool? Interrupt { get; set; }

        [NameInMap("Invoker")]
        [Validation(Required=true)]
        public string Invoker { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=true)]
        public string Pk { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TaskExtraData")]
        [Validation(Required=true)]
        public string TaskExtraData { get; set; }

        [NameInMap("TaskIdentifier")]
        [Validation(Required=true)]
        public string TaskIdentifier { get; set; }

        [NameInMap("GmtWakeup")]
        [Validation(Required=true)]
        public string GmtWakeup { get; set; }

    }

}
