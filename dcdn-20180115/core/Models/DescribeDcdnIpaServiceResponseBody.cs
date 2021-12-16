// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaServiceResponseBody : TeaModel {
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnIpaServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnIpaServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason : TeaModel {
                public string LockReason { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
