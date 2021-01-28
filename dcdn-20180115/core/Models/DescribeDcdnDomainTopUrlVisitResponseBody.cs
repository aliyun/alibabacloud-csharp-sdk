// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopUrlVisitResponseBody : TeaModel {
        [NameInMap("Url500List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

        [NameInMap("Url400List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Url300List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

    }

}
