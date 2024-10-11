// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainHitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval at which data is returned, which is the time granularity. Unit: seconds.</para>
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
        /// <para>The end of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-20T14:59:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The byte hit rate data at each time interval.</para>
        /// </summary>
        [NameInMap("HitRateInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainHitRateDataResponseBodyHitRateInterval HitRateInterval { get; set; }
        public class DescribeVodDomainHitRateDataResponseBodyHitRateInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainHitRateDataResponseBodyHitRateIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainHitRateDataResponseBodyHitRateIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The HTTPS byte hit rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-20T13:59:58Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total byte hit rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D94E471F-1A27-442E-552D-D4D2000C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-20T13:59:58Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
