// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainSrcTopUrlVisitResponseBody : TeaModel {
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        [NameInMap("Url300List")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        [NameInMap("Url400List")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        [NameInMap("Url500List")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
