// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcScaleDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scale")]
        [Validation(Required=false)]
        public List<DescribeRtcScaleDetailResponseBodyScale> Scale { get; set; }
        public class DescribeRtcScaleDetailResponseBodyScale : TeaModel {
            [NameInMap("CC")]
            [Validation(Required=false)]
            public long? CC { get; set; }

            [NameInMap("TS")]
            [Validation(Required=false)]
            public string TS { get; set; }

            [NameInMap("UC")]
            [Validation(Required=false)]
            public long? UC { get; set; }

        }

    }

}
