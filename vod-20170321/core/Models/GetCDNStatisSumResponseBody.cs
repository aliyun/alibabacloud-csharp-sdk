// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCDNStatisSumResponseBody : TeaModel {
        [NameInMap("CDNStatisList")]
        [Validation(Required=false)]
        public GetCDNStatisSumResponseBodyCDNStatisList CDNStatisList { get; set; }
        public class GetCDNStatisSumResponseBodyCDNStatisList : TeaModel {
            [NameInMap("CDNMetric")]
            [Validation(Required=false)]
            public List<GetCDNStatisSumResponseBodyCDNStatisListCDNMetric> CDNMetric { get; set; }
            public class GetCDNStatisSumResponseBodyCDNStatisListCDNMetric : TeaModel {
                [NameInMap("BpsDataDomesticValue")]
                [Validation(Required=false)]
                public long? BpsDataDomesticValue { get; set; }

                [NameInMap("BpsDataOverseasValue")]
                [Validation(Required=false)]
                public long? BpsDataOverseasValue { get; set; }

                [NameInMap("BpsDataValue")]
                [Validation(Required=false)]
                public long? BpsDataValue { get; set; }

                [NameInMap("FlowDataDomesticValue")]
                [Validation(Required=false)]
                public long? FlowDataDomesticValue { get; set; }

                [NameInMap("FlowDataOverseasValue")]
                [Validation(Required=false)]
                public long? FlowDataOverseasValue { get; set; }

                [NameInMap("FlowDataValue")]
                [Validation(Required=false)]
                public long? FlowDataValue { get; set; }

                [NameInMap("StatTime")]
                [Validation(Required=false)]
                public string StatTime { get; set; }

            }

        }

        [NameInMap("MaxBpsDataValue")]
        [Validation(Required=false)]
        public long? MaxBpsDataValue { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SumFlowDataValue")]
        [Validation(Required=false)]
        public long? SumFlowDataValue { get; set; }

    }

}
