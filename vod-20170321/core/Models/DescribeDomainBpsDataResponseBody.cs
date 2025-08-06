// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeDomainBpsDataResponseBody : TeaModel {
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("DomesticL2Value")]
                [Validation(Required=false)]
                public string DomesticL2Value { get; set; }

                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                [NameInMap("DynamicDomesticValue")]
                [Validation(Required=false)]
                public string DynamicDomesticValue { get; set; }

                [NameInMap("DynamicOverseasValue")]
                [Validation(Required=false)]
                public string DynamicOverseasValue { get; set; }

                [NameInMap("DynamicValue")]
                [Validation(Required=false)]
                public long? DynamicValue { get; set; }

                [NameInMap("L2Value")]
                [Validation(Required=false)]
                public string L2Value { get; set; }

                [NameInMap("OverseasL2Value")]
                [Validation(Required=false)]
                public string OverseasL2Value { get; set; }

                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                [NameInMap("StaticDomesticValue")]
                [Validation(Required=false)]
                public string StaticDomesticValue { get; set; }

                [NameInMap("StaticOverseasValue")]
                [Validation(Required=false)]
                public string StaticOverseasValue { get; set; }

                [NameInMap("StaticValue")]
                [Validation(Required=false)]
                public string StaticValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

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

        [NameInMap("SupplyBpsDatas")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataResponseBodySupplyBpsDatas SupplyBpsDatas { get; set; }
        public class DescribeDomainBpsDataResponseBodySupplyBpsDatas : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataResponseBodySupplyBpsDatasDataModule> DataModule { get; set; }
            public class DescribeDomainBpsDataResponseBodySupplyBpsDatasDataModule : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
