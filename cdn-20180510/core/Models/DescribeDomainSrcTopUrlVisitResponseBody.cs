// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainSrcTopUrlVisitResponseBody : TeaModel {
        /// <summary>
        /// A list of frequently requested URLs.
        /// </summary>
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. Unit: bytes.
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
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits to the URL.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range that was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// A list of URLs for which 2xx status codes were returned.
        /// </summary>
        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. Unit: bytes.
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
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits to the URL.
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. Unit: bytes.
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
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits to the URL.
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. Unit: bytes.
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
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits to the URL.
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                /// <summary>
                /// The amount of network traffic. Unit: bytes.
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
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// The proportion of visits to the URL.
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
