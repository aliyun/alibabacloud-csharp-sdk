// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth data that is collected for each interval.</para>
        /// </summary>
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeVodDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth in mainland China. Unit: bit/s. When the bandwidth data is queried by ISP, no value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11286111</para>
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// <para>The HTTPS bandwidth on L1 nodes in mainland China. Unit: bit/s. When the bandwidth data is queried by ISP, no value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11286111</para>
                /// </summary>
                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                /// <summary>
                /// <para>The HTTPS bandwidth on L1 nodes outside mainland China. Unit: bit/s. When the bandwidth data is queried by ISP, no value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                /// <summary>
                /// <para>The total HTTPS bandwidth on L1 nodes. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11288111</para>
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// <para>The bandwidth outside mainland China. Unit: bit/s. When the bandwidth data is queried by ISP, no value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T13:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11288111</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The time interval between the returned entries. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The domain name for CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range in which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the ISP. By default, the data of all ISPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. By default, the data in all regions is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-****-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range in which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T13:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
