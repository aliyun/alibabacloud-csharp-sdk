// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbSlsInfoResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public DescribeInstDbSlsInfoResponseBodyAuditInfo AuditInfo { get; set; }
        public class DescribeInstDbSlsInfoResponseBodyAuditInfo : TeaModel {
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }
        };

    }

}
