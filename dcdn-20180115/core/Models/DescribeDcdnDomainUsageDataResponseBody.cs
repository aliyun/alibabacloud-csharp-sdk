// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainUsageDataResponseBody : TeaModel {
        /// <summary>
        /// data.field
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// data.area
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The time interval between the data entries to return. Unit: seconds.
        /// 
        /// The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see **Usage notes**.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the content returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The beginning of the time range during which data was queried.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The billable region where the usage data was collected.
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
                /// The time interval between the data entries. Unit: seconds.
                /// </summary>
                [NameInMap("PeakTime")]
                [Validation(Required=false)]
                public string PeakTime { get; set; }

                /// <summary>
                /// The network traffic that was collected at each interval.
                /// </summary>
                [NameInMap("SpecialValue")]
                [Validation(Required=false)]
                public string SpecialValue { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// data.content
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
