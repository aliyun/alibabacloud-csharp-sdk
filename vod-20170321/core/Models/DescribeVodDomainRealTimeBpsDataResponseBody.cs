// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeBpsDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeBpsDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeBpsDataResponseBodyData : TeaModel {
            [NameInMap("BpsModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeBpsDataResponseBodyDataBpsModel> BpsModel { get; set; }
            public class DescribeVodDomainRealTimeBpsDataResponseBodyDataBpsModel : TeaModel {
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
