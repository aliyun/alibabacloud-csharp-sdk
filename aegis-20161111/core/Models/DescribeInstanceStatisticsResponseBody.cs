// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aegis20161111.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyData> Data { get; set; }
        public class DescribeInstanceStatisticsResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public int? Account { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            [NameInMap("Health")]
            [Validation(Required=false)]
            public int? Health { get; set; }

            [NameInMap("Trojan")]
            [Validation(Required=false)]
            public int? Trojan { get; set; }

            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

    }

}
