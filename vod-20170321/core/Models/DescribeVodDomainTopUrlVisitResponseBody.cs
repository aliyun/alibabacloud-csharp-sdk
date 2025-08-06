// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainTopUrlVisitResponseBody : TeaModel {
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeVodDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeVodDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeVodDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
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

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeVodDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeVodDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeVodDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
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
        public DescribeVodDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeVodDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeVodDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
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
        public DescribeVodDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeVodDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeVodDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
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
        public DescribeVodDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeVodDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeVodDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
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
