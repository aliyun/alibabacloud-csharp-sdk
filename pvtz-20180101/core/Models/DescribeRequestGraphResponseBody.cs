// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRequestGraphResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestDetails")]
        [Validation(Required=false)]
        public DescribeRequestGraphResponseBodyRequestDetails RequestDetails { get; set; }
        public class DescribeRequestGraphResponseBodyRequestDetails : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop : TeaModel {
                public string Time { get; set; }
                public long? RequestCount { get; set; }
                public long? Timestamp { get; set; }
            }
        };

    }

}
