// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendResponseBody : TeaModel {
        [NameInMap("InProtectCnt")]
        [Validation(Required=false)]
        public long? InProtectCnt { get; set; }

        [NameInMap("InterVPCProtectCnt")]
        [Validation(Required=false)]
        public long? InterVPCProtectCnt { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("OutProtectCnt")]
        [Validation(Required=false)]
        public long? OutProtectCnt { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

        [NameInMap("TrendList")]
        [Validation(Required=false)]
        public List<DescribeACLProtectTrendResponseBodyTrendList> TrendList { get; set; }
        public class DescribeACLProtectTrendResponseBodyTrendList : TeaModel {
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public int? ProtectCnt { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

    }

}
