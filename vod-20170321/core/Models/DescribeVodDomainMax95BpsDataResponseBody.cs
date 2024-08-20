// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainMax95BpsDataResponseBody : TeaModel {
        [NameInMap("DetailData")]
        [Validation(Required=false)]
        public DescribeVodDomainMax95BpsDataResponseBodyDetailData DetailData { get; set; }
        public class DescribeVodDomainMax95BpsDataResponseBodyDetailData : TeaModel {
            [NameInMap("Max95Detail")]
            [Validation(Required=false)]
            public List<DescribeVodDomainMax95BpsDataResponseBodyDetailDataMax95Detail> Max95Detail { get; set; }
            public class DescribeVodDomainMax95BpsDataResponseBodyDetailDataMax95Detail : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("Max95Bps")]
                [Validation(Required=false)]
                public float? Max95Bps { get; set; }

                [NameInMap("Max95BpsPeakTime")]
                [Validation(Required=false)]
                public string Max95BpsPeakTime { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomesticMax95Bps")]
        [Validation(Required=false)]
        public string DomesticMax95Bps { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Max95Bps")]
        [Validation(Required=false)]
        public string Max95Bps { get; set; }

        [NameInMap("OverseasMax95Bps")]
        [Validation(Required=false)]
        public string OverseasMax95Bps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
