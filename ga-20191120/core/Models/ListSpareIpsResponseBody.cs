// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSpareIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpareIps")]
        [Validation(Required=false)]
        public List<ListSpareIpsResponseBodySpareIps> SpareIps { get; set; }
        public class ListSpareIpsResponseBodySpareIps : TeaModel {
            [NameInMap("SpareIp")]
            [Validation(Required=false)]
            public string SpareIp { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
