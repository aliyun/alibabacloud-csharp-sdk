// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddInvoiceEntityShrinkRequest : TeaModel {
        [NameInMap("entities")]
        [Validation(Required=false)]
        public string EntitiesShrink { get; set; }

        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
