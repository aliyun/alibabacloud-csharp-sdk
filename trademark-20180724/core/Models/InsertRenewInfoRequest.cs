// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class InsertRenewInfoRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("EngAddress")]
        [Validation(Required=false)]
        public string EngAddress { get; set; }

        [NameInMap("EngName")]
        [Validation(Required=false)]
        public string EngName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegisterTime")]
        [Validation(Required=false)]
        public long? RegisterTime { get; set; }

    }

}
