// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        [NameInMap("DefaultAddrPoolStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolStatus { get; set; }

        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        [NameInMap("AccessStatus")]
        [Validation(Required=false)]
        public string AccessStatus { get; set; }

        [NameInMap("DefaultAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolMonitorStatus { get; set; }

        [NameInMap("DefaultAddrPoolName")]
        [Validation(Required=false)]
        public string DefaultAddrPoolName { get; set; }

        [NameInMap("DefultAddrPoolId")]
        [Validation(Required=false)]
        public string DefultAddrPoolId { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("FailoverAddrPoolStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolStatus { get; set; }

        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        [NameInMap("FailoverAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolMonitorStatus { get; set; }

        [NameInMap("FailoverAddrPoolName")]
        [Validation(Required=false)]
        public string FailoverAddrPoolName { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                public string GroupName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
            }
        };

    }

}
