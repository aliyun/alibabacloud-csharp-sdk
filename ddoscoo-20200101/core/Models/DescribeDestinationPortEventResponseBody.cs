// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDestinationPortEventResponseBody : TeaModel {
        [NameInMap("PortList")]
        [Validation(Required=false)]
        public List<DescribeDestinationPortEventResponseBodyPortList> PortList { get; set; }
        public class DescribeDestinationPortEventResponseBodyPortList : TeaModel {
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
