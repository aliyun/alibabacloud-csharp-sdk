// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainISPDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeVodDomainISPDataResponseBodyValue Value { get; set; }
        public class DescribeVodDomainISPDataResponseBodyValue : TeaModel {
            [NameInMap("ISPProportionData")]
            [Validation(Required=false)]
            public List<DescribeVodDomainISPDataResponseBodyValueISPProportionData> ISPProportionData { get; set; }
            public class DescribeVodDomainISPDataResponseBodyValueISPProportionData : TeaModel {
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("IspEname")]
                [Validation(Required=false)]
                public string IspEname { get; set; }

                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                [NameInMap("ReqErrRate")]
                [Validation(Required=false)]
                public string ReqErrRate { get; set; }

                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
