// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeTopTrafficResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("TrafficList")]
        [Validation(Required=true)]
        public List<DescribeTopTrafficResponseTrafficList> TrafficList { get; set; }
        public class DescribeTopTrafficResponseTrafficList : TeaModel {
            [NameInMap("Pps")]
            [Validation(Required=true)]
            public int? Pps { get; set; }

            [NameInMap("Bps")]
            [Validation(Required=true)]
            public int? Bps { get; set; }

            [NameInMap("AttackBps")]
            [Validation(Required=true)]
            public int? AttackBps { get; set; }

            [NameInMap("AttackPps")]
            [Validation(Required=true)]
            public int? AttackPps { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=true)]
            public string Ip { get; set; }

        }

    }

}
