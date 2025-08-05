// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetDedicatedIpWarmUpInfoResponseBody : TeaModel {
        [NameInMap("Info")]
        [Validation(Required=false)]
        public List<GetDedicatedIpWarmUpInfoResponseBodyInfo> Info { get; set; }
        public class GetDedicatedIpWarmUpInfoResponseBodyInfo : TeaModel {
            [NameInMap("Esp")]
            [Validation(Required=false)]
            public string Esp { get; set; }

            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
