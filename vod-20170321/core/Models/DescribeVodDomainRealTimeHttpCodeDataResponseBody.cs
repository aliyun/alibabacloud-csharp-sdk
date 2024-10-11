// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval at which data is returned. Unit: seconds.</para>
        /// <para>The returned value varies based on the time range per query. Valid values: 60 (1 minute), 300 (5 minutes), and 3600 (1 hour). For more information, see the <b>Time granularity</b> section in the <b>API documentation</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
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
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The proportion of each HTTP status code in each time interval.</para>
        /// </summary>
        [NameInMap("RealTimeHttpCodeData")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData RealTimeHttpCodeData { get; set; }
        public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-30T05:39:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The proportion of each HTTP status code is displayed in a data list.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("RealTimeCodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData> RealTimeCodeProportionData { get; set; }
                    public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The number of the HTTP status codes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The proportion of the HTTP status code in percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>28.4496124031008</para>
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:39:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
