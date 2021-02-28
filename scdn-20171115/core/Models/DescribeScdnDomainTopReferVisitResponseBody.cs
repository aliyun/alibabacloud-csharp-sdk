// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainTopReferVisitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeScdnDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeScdnDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeScdnDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                public string VisitData { get; set; }
                public string ReferDetail { get; set; }
                public float? VisitProportion { get; set; }
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
            }
        };

    }

}
