// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeAuditSettingResponseBody : TeaModel {
        [NameInMap("AuditRange")]
        [Validation(Required=false)]
        public DescribeAuditSettingResponseBodyAuditRange AuditRange { get; set; }
        public class DescribeAuditSettingResponseBodyAuditRange : TeaModel {
            [NameInMap("block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            [NameInMap("review")]
            [Validation(Required=false)]
            public bool? Review { get; set; }

        }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Seed")]
        [Validation(Required=false)]
        public string Seed { get; set; }

    }

}
