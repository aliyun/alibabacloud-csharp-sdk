// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainTopReferVisitResponseBody : TeaModel {
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
        public DescribeScdnDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeScdnDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeScdnDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                [NameInMap("ReferDetail")]
                [Validation(Required=false)]
                public string ReferDetail { get; set; }

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
