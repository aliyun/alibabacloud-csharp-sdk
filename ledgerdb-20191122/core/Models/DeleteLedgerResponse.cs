// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class DeleteLedgerResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public DeleteLedgerResponseBody Body { get; set; }

    }

}
