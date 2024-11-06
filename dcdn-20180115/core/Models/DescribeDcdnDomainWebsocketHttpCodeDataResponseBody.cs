// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
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
        /// <para>2018-03-01T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// </summary>
        [NameInMap("HttpCodeDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerInterval HttpCodeDataPerInterval { get; set; }
        public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-03-01T13:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The proportions of the HTTP status codes.</para>
                /// </summary>
                [NameInMap("WebsocketHttpCode")]
                [Validation(Required=false)]
                public DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModuleWebsocketHttpCode WebsocketHttpCode { get; set; }
                public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModuleWebsocketHttpCode : TeaModel {
                    [NameInMap("HttpCodeDataModule")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModuleWebsocketHttpCodeHttpCodeDataModule> HttpCodeDataModule { get; set; }
                    public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyHttpCodeDataPerIntervalDataModuleWebsocketHttpCodeHttpCodeDataModule : TeaModel {
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
                        /// <para>The total number of entries returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// <para>The proportion of the HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public float? Proportion { get; set; }

                    }

                }

            }

        }

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
        /// <para>2018-03-01T05:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
