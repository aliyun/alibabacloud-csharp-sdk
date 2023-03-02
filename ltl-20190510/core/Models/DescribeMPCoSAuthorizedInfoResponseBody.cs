// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class DescribeMPCoSAuthorizedInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMPCoSAuthorizedInfoResponseBodyData Data { get; set; }
        public class DescribeMPCoSAuthorizedInfoResponseBodyData : TeaModel {
            [NameInMap("AuthorizedPhaseList")]
            [Validation(Required=false)]
            public List<DescribeMPCoSAuthorizedInfoResponseBodyDataAuthorizedPhaseList> AuthorizedPhaseList { get; set; }
            public class DescribeMPCoSAuthorizedInfoResponseBodyDataAuthorizedPhaseList : TeaModel {
                [NameInMap("PhaseId")]
                [Validation(Required=false)]
                public string PhaseId { get; set; }

                [NameInMap("PhaseName")]
                [Validation(Required=false)]
                public string PhaseName { get; set; }

            }

            [NameInMap("UnAuthorizedPhaseList")]
            [Validation(Required=false)]
            public List<DescribeMPCoSAuthorizedInfoResponseBodyDataUnAuthorizedPhaseList> UnAuthorizedPhaseList { get; set; }
            public class DescribeMPCoSAuthorizedInfoResponseBodyDataUnAuthorizedPhaseList : TeaModel {
                [NameInMap("PhaseId")]
                [Validation(Required=false)]
                public string PhaseId { get; set; }

                [NameInMap("PhaseName")]
                [Validation(Required=false)]
                public string PhaseName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
