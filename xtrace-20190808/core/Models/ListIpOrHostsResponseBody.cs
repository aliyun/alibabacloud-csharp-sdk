// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListIpOrHostsResponseBody : TeaModel {
        [NameInMap("IpNames")]
        [Validation(Required=false)]
        public ListIpOrHostsResponseBodyIpNames IpNames { get; set; }
        public class ListIpOrHostsResponseBodyIpNames : TeaModel {
            [NameInMap("IpName")]
            [Validation(Required=false)]
            public List<string> IpName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
