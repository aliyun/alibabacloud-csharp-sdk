// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainHttpCodeDataResponseBody : TeaModel {
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
        /// <para>The proportions of HTTP status codes at each time interval.</para>
        /// </summary>
        [NameInMap("DataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainHttpCodeDataResponseBodyDataPerInterval DataPerInterval { get; set; }
        public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The proportions of the HTTP status codes.</para>
                /// </summary>
                [NameInMap("HttpCodeDataPerInterval")]
                [Validation(Required=false)]
                public DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval HttpCodeDataPerInterval { get; set; }
                public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval : TeaModel {
                    [NameInMap("HttpCodeDataModule")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule> HttpCodeDataModule { get; set; }
                    public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>404</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public int? Code { get; set; }

                        /// <summary>
                        /// <para>The count of each HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// <para>The proportion of the HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33.333333</para>
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public float? Proportion { get; set; }

                    }

                }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-01T13:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

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
        /// <para>2018-03-01T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91FC2D9D-B042-4634-8A5C-7B8E7482C22D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
