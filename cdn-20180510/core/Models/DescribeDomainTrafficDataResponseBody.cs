// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

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
