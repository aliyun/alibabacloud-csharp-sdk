// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopReferVisitResponseBody : TeaModel {
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                public string Flow { get; set; }
                public float? FlowProportion { get; set; }
                public string VisitData { get; set; }
                public string ReferDetail { get; set; }
                public float? VisitProportion { get; set; }
            }
        };

    }

}
