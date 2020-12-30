// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDdosAttackEventSourceIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDdosAttackEventSourceIpsResponseBodyData Data { get; set; }
        public class DescribeDdosAttackEventSourceIpsResponseBodyData : TeaModel {
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<DescribeDdosAttackEventSourceIpsResponseBodyDataIpList> IpList { get; set; }
            public class DescribeDdosAttackEventSourceIpsResponseBodyDataIpList : TeaModel {
                public string SourceIp { get; set; }
                public int? InBps { get; set; }
                public string City { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
