// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopUrlVisitResponseBody : TeaModel {
        /// <summary>
        /// A list of frequently requested URLs.
        /// </summary>
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. (Unit: bytes)
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// The complete URL.
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The request ID.
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

        /// <summary>
        /// A list of URLs for which 2xx status codes were returned.
        /// </summary>
        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. (Unit: bytes)
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// The complete URL.
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// A list of URLs for which 3xx status codes were returned.
        /// </summary>
        [NameInMap("Url300List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. (Unit: bytes)
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// The complete URL.
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// A list of URLs for which 4xx status codes were returned.
        /// </summary>
        [NameInMap("Url400List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. (Unit: bytes)
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// The complete URL.
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// A list of URLs for which 5xx status codes were returned.
        /// </summary>
        [NameInMap("Url500List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. (Unit: bytes)
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// The complete URL.
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
