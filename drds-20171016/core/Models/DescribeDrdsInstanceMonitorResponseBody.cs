// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeDrdsInstanceMonitorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceMonitorResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceMonitorResponseBodyData : TeaModel {
            [NameInMap("PartialPerformanceData")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceData> PartialPerformanceData { get; set; }
            public class DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceData : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceDataValues Values { get; set; }
                public class DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceDataValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceDataValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDrdsInstanceMonitorResponseBodyDataPartialPerformanceDataValuesPerformanceValue : TeaModel {
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public long? Date { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
