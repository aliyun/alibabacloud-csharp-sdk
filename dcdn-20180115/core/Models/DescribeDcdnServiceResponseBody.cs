// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnServiceResponseBody : TeaModel {
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
        public DescribeDcdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebsocketChangingTime")]
        [Validation(Required=false)]
        public string WebsocketChangingTime { get; set; }

        [NameInMap("WebsocketChangingType")]
        [Validation(Required=false)]
        public string WebsocketChangingType { get; set; }

        [NameInMap("WebsocketType")]
        [Validation(Required=false)]
        public string WebsocketType { get; set; }

    }

}
