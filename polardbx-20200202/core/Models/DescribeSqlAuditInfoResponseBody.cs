// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSqlAuditInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlAuditInfoResponseBodyData Data { get; set; }
        public class DescribeSqlAuditInfoResponseBodyData : TeaModel {
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public bool? IsEnabled { get; set; }
        };

    }

}
