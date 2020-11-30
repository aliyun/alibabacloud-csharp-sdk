// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeTrafficResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("FlowList")]
        [Validation(Required=true)]
        public List<DescribeTrafficResponseFlowList> FlowList { get; set; }
        public class DescribeTrafficResponseFlowList : TeaModel {
            [NameInMap("Pps")]
            [Validation(Required=true)]
            public int? Pps { get; set; }

            [NameInMap("FlowType")]
            [Validation(Required=true)]
            public string FlowType { get; set; }

            [NameInMap("Kbps")]
            [Validation(Required=true)]
            public int? Kbps { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Time")]
            [Validation(Required=true)]
            public int? Time { get; set; }

        }

    }

}
