// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddressGroup : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<AddressGroupPorts> Ports { get; set; }
        public class AddressGroupPorts : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

    }

}
