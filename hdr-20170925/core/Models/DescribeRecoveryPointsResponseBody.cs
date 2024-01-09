// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeRecoveryPointsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RecoveryPoints")]
        [Validation(Required=false)]
        public DescribeRecoveryPointsResponseBodyRecoveryPoints RecoveryPoints { get; set; }
        public class DescribeRecoveryPointsResponseBodyRecoveryPoints : TeaModel {
            [NameInMap("recoveryPoint")]
            [Validation(Required=false)]
            public List<DescribeRecoveryPointsResponseBodyRecoveryPointsRecoveryPoint> RecoveryPoint { get; set; }
            public class DescribeRecoveryPointsResponseBodyRecoveryPointsRecoveryPoint : TeaModel {
                [NameInMap("ApplicationConsistent")]
                [Validation(Required=false)]
                public bool? ApplicationConsistent { get; set; }

                [NameInMap("DisableReason")]
                [Validation(Required=false)]
                public string DisableReason { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("RecoveryPointId")]
                [Validation(Required=false)]
                public string RecoveryPointId { get; set; }

                [NameInMap("RecoveryPointTime")]
                [Validation(Required=false)]
                public long? RecoveryPointTime { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public bool? Used { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
