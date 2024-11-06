// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTrafficDataResponseBody : TeaModel {
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
        /// <para>2017-12-10T21:00:00Z</para>
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
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The network traffic returned at each time interval. Unit: bytes.</para>
        /// </summary>
        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The network traffic that was consumed to deliver dynamic content over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpTraffic { get; set; }

                /// <summary>
                /// <para>The network traffic that was consumed to deliver dynamic content over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpsTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsTraffic { get; set; }

                /// <summary>
                /// <para>The network traffic that was consumed to deliver static content over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("StaticHttpTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpTraffic { get; set; }

                /// <summary>
                /// <para>The network traffic that was consumed to deliver static content over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132</para>
                /// </summary>
                [NameInMap("StaticHttpsTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsTraffic { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total amount of network traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public float? Traffic { get; set; }

            }

        }

    }

}
