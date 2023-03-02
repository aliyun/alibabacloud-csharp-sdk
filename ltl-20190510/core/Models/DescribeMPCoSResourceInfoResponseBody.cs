// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class DescribeMPCoSResourceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMPCoSResourceInfoResponseBodyData Data { get; set; }
        public class DescribeMPCoSResourceInfoResponseBodyData : TeaModel {
            [NameInMap("MemberQuota")]
            [Validation(Required=false)]
            public long? MemberQuota { get; set; }

            [NameInMap("PhaseGroupQuota")]
            [Validation(Required=false)]
            public long? PhaseGroupQuota { get; set; }

            [NameInMap("PhaseQuotaInfoList")]
            [Validation(Required=false)]
            public List<DescribeMPCoSResourceInfoResponseBodyDataPhaseQuotaInfoList> PhaseQuotaInfoList { get; set; }
            public class DescribeMPCoSResourceInfoResponseBodyDataPhaseQuotaInfoList : TeaModel {
                [NameInMap("PhaseGroupId")]
                [Validation(Required=false)]
                public string PhaseGroupId { get; set; }

                [NameInMap("PhaseGroupName")]
                [Validation(Required=false)]
                public string PhaseGroupName { get; set; }

                [NameInMap("PhaseQuota")]
                [Validation(Required=false)]
                public long? PhaseQuota { get; set; }

                [NameInMap("UsedPhase")]
                [Validation(Required=false)]
                public long? UsedPhase { get; set; }

            }

            [NameInMap("UsedMember")]
            [Validation(Required=false)]
            public long? UsedMember { get; set; }

            [NameInMap("UsedPhaseGroup")]
            [Validation(Required=false)]
            public long? UsedPhaseGroup { get; set; }

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
