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
                public string ExpressSyncId { get; set; }
                public string ExpressSyncState { get; set; }
                public string GatewayId { get; set; }
                public string GatewayName { get; set; }
                public string GatewayRegion { get; set; }
                public string MnsQueue { get; set; }
                public string ShareName { get; set; }
                public string StorageBundleId { get; set; }
                public int? SyncProgress { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
