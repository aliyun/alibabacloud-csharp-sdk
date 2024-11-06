// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth data returned at each interval.</para>
        /// </summary>
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth value. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11286</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed to deliver dynamic content over HTTP. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11286111</para>
                /// </summary>
                [NameInMap("DynamicHttpBps")]
                [Validation(Required=false)]
                public float? DynamicHttpBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed to deliver dynamic content over HTTPS. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312</para>
                /// </summary>
                [NameInMap("DynamicHttpsBps")]
                [Validation(Required=false)]
                public float? DynamicHttpsBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed to deliver static content over HTTP. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("StaticHttpBps")]
                [Validation(Required=false)]
                public float? StaticHttpBps { get; set; }

                /// <summary>
                /// <para>The bandwidth that was consumed to deliver static content over HTTPS. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("StaticHttpsBps")]
                [Validation(Required=false)]
                public float? StaticHttpsBps { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The time interval between the data entries returned.</para>
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
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T10:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
