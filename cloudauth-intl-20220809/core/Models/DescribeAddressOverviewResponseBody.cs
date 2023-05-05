// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeAddressOverviewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAddressOverviewResponseBodyData Data { get; set; }
        public class DescribeAddressOverviewResponseBodyData : TeaModel {
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public float? Balance { get; set; }

            [NameInMap("FirstSeen")]
            [Validation(Required=false)]
            public long? FirstSeen { get; set; }

            [NameInMap("LastSeen")]
            [Validation(Required=false)]
            public long? LastSeen { get; set; }

            [NameInMap("ReceivedTxsCount")]
            [Validation(Required=false)]
            public int? ReceivedTxsCount { get; set; }

            [NameInMap("SpentTxsCount")]
            [Validation(Required=false)]
            public int? SpentTxsCount { get; set; }

            [NameInMap("TotalReceived")]
            [Validation(Required=false)]
            public float? TotalReceived { get; set; }

            [NameInMap("TotalSpent")]
            [Validation(Required=false)]
            public float? TotalSpent { get; set; }

            [NameInMap("TxsCount")]
            [Validation(Required=false)]
            public long? TxsCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
