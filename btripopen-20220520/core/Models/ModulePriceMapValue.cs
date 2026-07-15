// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModulePriceMapValue : TeaModel {
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("service_no")]
        [Validation(Required=false)]
        public string ServiceNo { get; set; }

    }

}
