// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetDedicatedIpWarmUpDetailResponseBody : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public List<GetDedicatedIpWarmUpDetailResponseBodyDetail> Detail { get; set; }
        public class GetDedicatedIpWarmUpDetailResponseBodyDetail : TeaModel {
            [NameInMap("DayMark")]
            [Validation(Required=false)]
            public long? DayMark { get; set; }

            [NameInMap("DeliverCounts")]
            [Validation(Required=false)]
            public long? DeliverCounts { get; set; }

            [NameInMap("Esp")]
            [Validation(Required=false)]
            public string Esp { get; set; }

            [NameInMap("SendCounts")]
            [Validation(Required=false)]
            public long? SendCounts { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
