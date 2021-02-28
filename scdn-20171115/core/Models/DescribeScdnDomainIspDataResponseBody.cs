// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainIspDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeScdnDomainIspDataResponseBodyValue Value { get; set; }
        public class DescribeScdnDomainIspDataResponseBodyValue : TeaModel {
            [NameInMap("ISPProportionData")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainIspDataResponseBodyValueISPProportionData> ISPProportionData { get; set; }
            public class DescribeScdnDomainIspDataResponseBodyValueISPProportionData : TeaModel {
                public string TotalQuery { get; set; }
                public string TotalBytes { get; set; }
                public string AvgResponseRate { get; set; }
                public string AvgResponseTime { get; set; }
                public string ReqErrRate { get; set; }
                public string AvgObjectSize { get; set; }
                public string Bps { get; set; }
                public string Qps { get; set; }
                public string Proportion { get; set; }
                public string IspEname { get; set; }
                public string ISP { get; set; }
                public string BytesProportion { get; set; }
            }
        };

    }

}
