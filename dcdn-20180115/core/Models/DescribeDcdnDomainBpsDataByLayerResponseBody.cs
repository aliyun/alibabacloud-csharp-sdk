// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainBpsDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth returned at each time interval.
        /// </summary>
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// The traffic that is used to deliver dynamic content. Unit: bytes.
                /// </summary>
                [NameInMap("DynamicTrafficValue")]
                [Validation(Required=false)]
                public string DynamicTrafficValue { get; set; }

                /// <summary>
                /// The bandwidth that is used to deliver dynamic content. Unit: bit/s.
                /// </summary>
                [NameInMap("DynamicValue")]
                [Validation(Required=false)]
                public string DynamicValue { get; set; }

                /// <summary>
                /// The traffic that is used to deliver static content. Unit: bytes.
                /// </summary>
                [NameInMap("StaticTrafficValue")]
                [Validation(Required=false)]
                public string StaticTrafficValue { get; set; }

                /// <summary>
                /// The bandwidth that is used to deliver static content. Unit: bit/s.
                /// </summary>
                [NameInMap("StaticValue")]
                [Validation(Required=false)]
                public string StaticValue { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The total traffic. Unit: bytes.
                /// </summary>
                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public string TrafficValue { get; set; }

                /// <summary>
                /// The total bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
