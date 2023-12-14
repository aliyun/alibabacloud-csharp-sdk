// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeExpressSyncSharesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Shares")]
        [Validation(Required=false)]
        public DescribeExpressSyncSharesResponseBodyShares Shares { get; set; }
        public class DescribeExpressSyncSharesResponseBodyShares : TeaModel {
            [NameInMap("Share")]
            [Validation(Required=false)]
            public List<DescribeExpressSyncSharesResponseBodySharesShare> Share { get; set; }
            public class DescribeExpressSyncSharesResponseBodySharesShare : TeaModel {
                [NameInMap("ExpressSyncId")]
                [Validation(Required=false)]
                public string ExpressSyncId { get; set; }

                [NameInMap("ExpressSyncState")]
                [Validation(Required=false)]
                public string ExpressSyncState { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("GatewayName")]
                [Validation(Required=false)]
                public string GatewayName { get; set; }

                [NameInMap("GatewayRegion")]
                [Validation(Required=false)]
                public string GatewayRegion { get; set; }

                [NameInMap("MnsQueue")]
                [Validation(Required=false)]
                public string MnsQueue { get; set; }

                [NameInMap("ShareName")]
                [Validation(Required=false)]
                public string ShareName { get; set; }

                [NameInMap("StorageBundleId")]
                [Validation(Required=false)]
                public string StorageBundleId { get; set; }

                [NameInMap("SyncProgress")]
                [Validation(Required=false)]
                public int? SyncProgress { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
