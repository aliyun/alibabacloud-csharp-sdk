// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class CreatePhysicalDeleteRequest : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("GmtWakeup")]
        [Validation(Required=false)]
        public string GmtWakeup { get; set; }

        [NameInMap("Hid")]
        [Validation(Required=false)]
        public long? Hid { get; set; }

        [NameInMap("Interrupt")]
        [Validation(Required=false)]
        public bool? Interrupt { get; set; }

        [NameInMap("Invoker")]
        [Validation(Required=false)]
        public string Invoker { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskExtraData")]
        [Validation(Required=false)]
        public string TaskExtraData { get; set; }

        [NameInMap("TaskIdentifier")]
        [Validation(Required=false)]
        public string TaskIdentifier { get; set; }

    }

}
