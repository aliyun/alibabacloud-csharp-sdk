// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The billable region where the usage data was collected.
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The accelerated domain name that was queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The type of the returned data.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The traffic that was collected at each interval.
        /// </summary>
        [NameInMap("UsageDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainUsageDataResponseBodyUsageDataPerInterval UsageDataPerInterval { get; set; }
        public class DescribeDcdnDomainUsageDataResponseBodyUsageDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainUsageDataResponseBodyUsageDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainUsageDataResponseBodyUsageDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The time of the peak bandwidth value if the **Field** parameter in the request is set to **bps**. Otherwise, this parameter returns the same value as the **TimeStamp** parameter.
                /// </summary>
                [NameInMap("PeakTime")]
                [Validation(Required=false)]
                public string PeakTime { get; set; }

                /// <summary>
                /// The data usage in a specific scenario.
                /// 
                /// >  This parameter indicates the data usage in a specific scenario. If no special billable item is specified, ignore this parameter.
                /// </summary>
                [NameInMap("SpecialValue")]
                [Validation(Required=false)]
                public string SpecialValue { get; set; }

                /// <summary>
                /// The timestamp of the returned data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The usage.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
