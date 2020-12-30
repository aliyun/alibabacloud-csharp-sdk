// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnSslServerLogsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("IsCompleted")]
        [Validation(Required=false)]
        public bool? IsCompleted { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVpnSslServerLogsResponseBodyData Data { get; set; }
        public class DescribeVpnSslServerLogsResponseBodyData : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }
        };

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
