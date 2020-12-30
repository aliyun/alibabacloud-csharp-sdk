// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeHighPriorityIpResponseBody : TeaModel {
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
        public DescribeHighPriorityIpResponseBodyHighPriorityIps HighPriorityIps { get; set; }
        public class DescribeHighPriorityIpResponseBodyHighPriorityIps : TeaModel {
            [NameInMap("HighPriorityIp")]
            [Validation(Required=false)]
            public List<DescribeHighPriorityIpResponseBodyHighPriorityIpsHighPriorityIp> HighPriorityIp { get; set; }
            public class DescribeHighPriorityIpResponseBodyHighPriorityIpsHighPriorityIp : TeaModel {
                public string StaticOffAreaId { get; set; }
                public string Domain { get; set; }
                public string DynamicOffAreaId { get; set; }
                public string State { get; set; }
                public string Ip { get; set; }
                public string BoardAreaId { get; set; }
            }
        };

    }

}
