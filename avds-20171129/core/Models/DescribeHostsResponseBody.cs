// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeHostsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeHostsResponseBodyRecords> Records { get; set; }
        public class DescribeHostsResponseBodyRecords : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("OS")]
            [Validation(Required=false)]
            public string OS { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("IsUp")]
            [Validation(Required=false)]
            public string IsUp { get; set; }

        }

    }

}
