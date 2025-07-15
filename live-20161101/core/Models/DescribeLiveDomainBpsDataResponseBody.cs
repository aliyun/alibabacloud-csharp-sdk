// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth data returned at each interval.</para>
        /// </summary>
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeLiveDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11288111</para>
                /// </summary>
                [NameInMap("BpsValue")]
                [Validation(Required=false)]
                public string BpsValue { get; set; }

                /// <summary>
                /// <para>The bandwidth over HTTP. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11286111</para>
                /// </summary>
                [NameInMap("HttpBpsValue")]
                [Validation(Required=false)]
                public string HttpBpsValue { get; set; }

                /// <summary>
                /// <para>The bandwidth over HTTPS. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("HttpsBpsValue")]
                [Validation(Required=false)]
                public string HttpsBpsValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T08:00:05Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T09:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
