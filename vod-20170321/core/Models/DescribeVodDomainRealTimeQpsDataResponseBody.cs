// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeQpsDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

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
