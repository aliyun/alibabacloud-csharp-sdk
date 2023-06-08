// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The HTTP status code.
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
                /// The timestamp of the returned data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The proportions of the HTTP status codes.
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
                        /// The HTTP status code returned.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public int? Code { get; set; }

                        /// <summary>
                        /// The total number of entries returned.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// The proportion of the HTTP status code.
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public float? Proportion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
