// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnsecServiceResponseBody : TeaModel {
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        [NameInMap("DomainNum")]
        [Validation(Required=false)]
        public string DomainNum { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnsecServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnsecServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnsecServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnsecServiceResponseBodyOperationLocksLockReason : TeaModel {
                public string LockReason { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestType")]
        [Validation(Required=false)]
        public string RequestType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
