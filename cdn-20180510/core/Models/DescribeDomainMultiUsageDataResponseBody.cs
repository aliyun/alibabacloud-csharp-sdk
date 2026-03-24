// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMultiUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Request")]
                [Validation(Required=false)]
                public long? Request { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The start of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TrafficPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
