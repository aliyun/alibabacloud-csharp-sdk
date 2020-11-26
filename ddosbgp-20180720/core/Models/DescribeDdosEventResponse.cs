// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosEventResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long Total { get; set; }

        [NameInMap("Events")]
        [Validation(Required=true)]
        public List<DescribeDdosEventResponseEvents> Events { get; set; }
        public class DescribeDdosEventResponseEvents : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public int? StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public int? EndTime { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=true)]
            public int? Pps { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=true)]
            public string Ip { get; set; }

            [NameInMap("Mbps")]
            [Validation(Required=true)]
            public int? Mbps { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}
