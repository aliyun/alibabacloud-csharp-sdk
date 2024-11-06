// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginTrafficDataResponseBody : TeaModel {
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
        /// <para>The amount of back-to-origin traffic returned at each time interval. Unit: bytes.</para>
        /// </summary>
        [NameInMap("OriginTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval OriginTrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The amount of back-to-origin traffic that was consumed to deliver dynamic content over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("DynamicHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginTraffic { get; set; }

                /// <summary>
                /// <para>The amount of back-to-origin traffic that was consumed to deliver dynamic content over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("DynamicHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginTraffic { get; set; }

                /// <summary>
                /// <para>The amount of back-to-origin traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OriginTraffic")]
                [Validation(Required=false)]
                public float? OriginTraffic { get; set; }

                /// <summary>
                /// <para>The amount of back-to-origin traffic that was consumed to deliver static content over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StaticHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpOriginTraffic { get; set; }

                /// <summary>
                /// <para>The amount of back-to-origin traffic that was consumed to deliver static content over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StaticHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginTraffic { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T21:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A666D44F-19D6-490E-97CF-1A64AB962C57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
