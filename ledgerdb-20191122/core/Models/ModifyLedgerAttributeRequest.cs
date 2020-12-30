// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ModifyLedgerAttributeRequest : TeaModel {
        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("LedgerName")]
        [Validation(Required=false)]
        public string LedgerName { get; set; }

        [NameInMap("LedgerDescription")]
        [Validation(Required=false)]
        public string LedgerDescription { get; set; }

    }

}
