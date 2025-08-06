// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeDomainFlowDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FlowDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainFlowDataResponseBodyFlowDataPerInterval FlowDataPerInterval { get; set; }
        public class DescribeDomainFlowDataResponseBodyFlowDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainFlowDataResponseBodyFlowDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainFlowDataResponseBodyFlowDataPerIntervalDataModule : TeaModel {
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
                public string DynamicValue { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
