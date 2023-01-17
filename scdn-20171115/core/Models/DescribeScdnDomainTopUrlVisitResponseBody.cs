// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainTopUrlVisitResponseBody : TeaModel {
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeScdnDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeScdnDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeScdnDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
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
        public DescribeScdnDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeScdnDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeScdnDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
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
        public DescribeScdnDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeScdnDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeScdnDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
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
        public DescribeScdnDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeScdnDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeScdnDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
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
        public DescribeScdnDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeScdnDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeScdnDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
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
