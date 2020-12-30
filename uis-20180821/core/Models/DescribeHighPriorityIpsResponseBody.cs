// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeHighPriorityIpsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("HighPriorityIps")]
        [Validation(Required=false)]
        public DescribeHighPriorityIpsResponseBodyHighPriorityIps HighPriorityIps { get; set; }
        public class DescribeHighPriorityIpsResponseBodyHighPriorityIps : TeaModel {
            [NameInMap("HighPriorityIp")]
            [Validation(Required=false)]
            public List<DescribeHighPriorityIpsResponseBodyHighPriorityIpsHighPriorityIp> HighPriorityIp { get; set; }
            public class DescribeHighPriorityIpsResponseBodyHighPriorityIpsHighPriorityIp : TeaModel {
                public string AreaId { get; set; }
                public string Destination { get; set; }
            }
        };

    }

}
