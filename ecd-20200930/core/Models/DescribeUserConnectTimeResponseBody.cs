// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectTimeResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeUserConnectTimeResponseBodyData> Data { get; set; }
        public class DescribeUserConnectTimeResponseBodyData : TeaModel {
            [NameInMap("EndConnectTime")]
            [Validation(Required=false)]
            public string EndConnectTime { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("OversoldGroupId")]
            [Validation(Required=false)]
            public string OversoldGroupId { get; set; }

            [NameInMap("StartConnectTime")]
            [Validation(Required=false)]
            public string StartConnectTime { get; set; }

            [NameInMap("UserDesktopId")]
            [Validation(Required=false)]
            public string UserDesktopId { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
