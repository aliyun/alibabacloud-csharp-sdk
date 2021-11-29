// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopUrlVisitResponseBody : TeaModel {
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

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
        public DescribeDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

        [NameInMap("Url300List")]
        [Validation(Required=false)]
        public DescribeDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

        [NameInMap("Url400List")]
        [Validation(Required=false)]
        public DescribeDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

        [NameInMap("Url500List")]
        [Validation(Required=false)]
        public DescribeDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string UrlDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

    }

}
