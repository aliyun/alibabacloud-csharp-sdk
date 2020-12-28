// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListRequest : TeaModel {
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsInstanceInServiceListRequestTag> Tag { get; set; }
        public class OnsInstanceInServiceListRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
