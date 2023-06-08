// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeDcdnWafUsageData**.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Specifies how query results are grouped. By default, this parameter is empty. Valid values:
        /// 
        /// *   domain: Query results are grouped by accelerated domain name.
        /// *   An empty string: Query results are not grouped.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The number of monitored requests.
        /// </summary>
        [NameInMap("WafUsageData")]
        [Validation(Required=false)]
        public DescribeDcdnWafUsageDataResponseBodyWafUsageData WafUsageData { get; set; }
        public class DescribeDcdnWafUsageDataResponseBodyWafUsageData : TeaModel {
            [NameInMap("WafUsageDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem> WafUsageDataItem { get; set; }
            public class DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem : TeaModel {
                /// <summary>
                /// The number of blocked requests.
                /// </summary>
                [NameInMap("AccessCnt")]
                [Validation(Required=false)]
                public long? AccessCnt { get; set; }

                /// <summary>
                /// The number of allowed requests.
                /// </summary>
                [NameInMap("BlockCnt")]
                [Validation(Required=false)]
                public long? BlockCnt { get; set; }

                /// <summary>
                /// The domain name that you want to query. If you do not specify an accelerated domain name, all accelerated domain names are queried by default.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The end of the time range during which data was queried.
                /// </summary>
                [NameInMap("ObserveCnt")]
                [Validation(Required=false)]
                public long? ObserveCnt { get; set; }

                /// <summary>
                /// The time granularity for a query. Unit: seconds.
                /// 
                /// The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day).
                /// </summary>
                [NameInMap("SecCu")]
                [Validation(Required=false)]
                public long? SecCu { get; set; }

                /// <summary>
                /// The beginning of the time range during which data was queried.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
