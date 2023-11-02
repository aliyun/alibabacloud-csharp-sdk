// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventCountByThreatLevelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventCountByThreatLevelResponseBodyData Data { get; set; }
        public class DescribeEventCountByThreatLevelResponseBodyData : TeaModel {
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public long? EventNum { get; set; }

            [NameInMap("HighLevelEventNum")]
            [Validation(Required=false)]
            public long? HighLevelEventNum { get; set; }

            [NameInMap("LowLevelEventNum")]
            [Validation(Required=false)]
            public long? LowLevelEventNum { get; set; }

            [NameInMap("MediumLevelEventNum")]
            [Validation(Required=false)]
            public long? MediumLevelEventNum { get; set; }

            [NameInMap("UndealEventNum")]
            [Validation(Required=false)]
            public long? UndealEventNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
