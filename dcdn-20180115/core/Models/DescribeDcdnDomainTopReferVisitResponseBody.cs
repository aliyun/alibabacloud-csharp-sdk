// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopReferVisitResponseBody : TeaModel {
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
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The list of frequently referenced URLs returned.
        /// </summary>
        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
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
                /// The complete referenced URL.
                /// </summary>
                [NameInMap("ReferDetail")]
                [Validation(Required=false)]
                public string ReferDetail { get; set; }

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
