// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficResponseBody : TeaModel {
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeTrafficResponseBodyFlowList> FlowList { get; set; }
        public class DescribeTrafficResponseBodyFlowList : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            [NameInMap("Kbps")]
            [Validation(Required=false)]
            public int? Kbps { get; set; }

            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
