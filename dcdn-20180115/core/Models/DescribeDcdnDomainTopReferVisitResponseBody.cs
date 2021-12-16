// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopReferVisitResponseBody : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string ReferDetail { get; set; }
                public string VisitData { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

    }

}
