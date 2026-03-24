// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval.</para>
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
        /// <para>2021-06-29T05:45:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("HttpCodeData")]
        [Validation(Required=false)]
        public DescribeDomainHttpCodeDataResponseBodyHttpCodeData HttpCodeData { get; set; }
        public class DescribeDomainHttpCodeDataResponseBodyHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageData : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("CodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValueCodeProportionData> CodeProportionData { get; set; }
                    public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValueCodeProportionData : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

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
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T05:30:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
