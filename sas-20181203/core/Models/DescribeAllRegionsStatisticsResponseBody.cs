// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllRegionsStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAllRegionsStatisticsResponseBodyData Data { get; set; }
        public class DescribeAllRegionsStatisticsResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public int? Account { get; set; }
            [NameInMap("Health")]
            [Validation(Required=false)]
            public int? Health { get; set; }
            [NameInMap("NewSuspicious")]
            [Validation(Required=false)]
            public int? NewSuspicious { get; set; }
            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }
            [NameInMap("Trojan")]
            [Validation(Required=false)]
            public int? Trojan { get; set; }
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
