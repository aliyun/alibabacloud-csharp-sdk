// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the entries returned. Unit: seconds Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The proportions of HTTP status codes at each time interval.</para>
        /// </summary>
        [NameInMap("RealTimeHttpCodeData")]
        [Validation(Required=false)]
        public DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData RealTimeHttpCodeData { get; set; }
        public class DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-11-30T05:39:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The proportions of HTTP status codes.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("RealTimeCodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData> RealTimeCodeProportionData { get; set; }
                    public class DescribeLiveDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The number of times the HTTP status code was returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The proportion of the HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>66.046511627907</para>
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
