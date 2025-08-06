// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCDNStatisResponseBody : TeaModel {
        [NameInMap("CDNStatisList")]
        [Validation(Required=false)]
        public GetCDNStatisResponseBodyCDNStatisList CDNStatisList { get; set; }
        public class GetCDNStatisResponseBodyCDNStatisList : TeaModel {
            [NameInMap("CDNMetric")]
            [Validation(Required=false)]
            public List<GetCDNStatisResponseBodyCDNStatisListCDNMetric> CDNMetric { get; set; }
            public class GetCDNStatisResponseBodyCDNStatisListCDNMetric : TeaModel {
                [NameInMap("BpsDataDomesticValue")]
                [Validation(Required=false)]
                public long? BpsDataDomesticValue { get; set; }

                [NameInMap("BpsDataOverseasValue")]
                [Validation(Required=false)]
                public long? BpsDataOverseasValue { get; set; }

                [NameInMap("BpsDataValue")]
                [Validation(Required=false)]
                public long? BpsDataValue { get; set; }

                [NameInMap("CdnDomain")]
                [Validation(Required=false)]
                public string CdnDomain { get; set; }

                [NameInMap("FlowDataDomesticValue")]
                [Validation(Required=false)]
                public long? FlowDataDomesticValue { get; set; }

                [NameInMap("FlowDataOverseasValue")]
                [Validation(Required=false)]
                public long? FlowDataOverseasValue { get; set; }

                [NameInMap("FlowDataValue")]
                [Validation(Required=false)]
                public long? FlowDataValue { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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
