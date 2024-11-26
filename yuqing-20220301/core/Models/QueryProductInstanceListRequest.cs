// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class QueryProductInstanceListRequest : TeaModel {
        [NameInMap("appCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tenantUid")]
        [Validation(Required=false)]
        public string TenantUid { get; set; }

        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
