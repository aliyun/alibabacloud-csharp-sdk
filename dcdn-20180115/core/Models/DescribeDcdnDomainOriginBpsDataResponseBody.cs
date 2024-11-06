// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginBpsDataResponseBody : TeaModel {
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
        /// <para>2019-12-11T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The origin bandwidth data returned at each time interval. Unit: bit/s.</para>
        /// </summary>
        [NameInMap("OriginBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval OriginBpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth that was consumed for fetching dynamic content from the origin over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DynamicHttpOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed for fetching dynamic content from the origin over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DynamicHttpsOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed for fetching content from the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OriginBps")]
                [Validation(Required=false)]
                public float? OriginBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed for fetching static content from the origin over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StaticHttpOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpOriginBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed for fetching static content from the origin over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StaticHttpsOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginBps { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-10T00:00:00Z</para>
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
        /// <para>7CBCD6AD-B016-42E5-AE0B-B3731DE8F755</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-10T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
