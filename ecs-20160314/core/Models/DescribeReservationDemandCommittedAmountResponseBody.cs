// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservationDemandCommittedAmountResponseBody : TeaModel {
        [NameInMap("CommittedAmountInfo")]
        [Validation(Required=false)]
        public DescribeReservationDemandCommittedAmountResponseBodyCommittedAmountInfo CommittedAmountInfo { get; set; }
        public class DescribeReservationDemandCommittedAmountResponseBodyCommittedAmountInfo : TeaModel {
            [NameInMap("CommittedAmount")]
            [Validation(Required=false)]
            public float? CommittedAmount { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
