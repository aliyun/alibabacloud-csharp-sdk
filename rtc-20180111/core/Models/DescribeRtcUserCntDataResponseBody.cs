// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcUserCntDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserCntDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcUserCntDataResponseBodyUserCntDataPerInterval UserCntDataPerInterval { get; set; }
        public class DescribeRtcUserCntDataResponseBodyUserCntDataPerInterval : TeaModel {
            [NameInMap("UserCntModule")]
            [Validation(Required=false)]
            public List<DescribeRtcUserCntDataResponseBodyUserCntDataPerIntervalUserCntModule> UserCntModule { get; set; }
            public class DescribeRtcUserCntDataResponseBodyUserCntDataPerIntervalUserCntModule : TeaModel {
                [NameInMap("ActiveUserCnt")]
                [Validation(Required=false)]
                public long? ActiveUserCnt { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
