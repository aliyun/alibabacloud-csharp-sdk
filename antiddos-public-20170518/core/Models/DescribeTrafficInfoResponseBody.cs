// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeTrafficInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficInfo")]
        [Validation(Required=false)]
        public DescribeTrafficInfoResponseBodyTrafficInfo TrafficInfo { get; set; }
        public class DescribeTrafficInfoResponseBodyTrafficInfo : TeaModel {
            [NameInMap("LastUsedTraffic")]
            [Validation(Required=false)]
            public int? LastUsedTraffic { get; set; }
            [NameInMap("AddTraffic")]
            [Validation(Required=false)]
            public int? AddTraffic { get; set; }
            [NameInMap("UsableTraffic")]
            [Validation(Required=false)]
            public int? UsableTraffic { get; set; }
        };

    }

}
