// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryStatementsRequest : TeaModel {
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("PayeeIds")]
        [Validation(Required=false)]
        public string PayeeIds { get; set; }

        [NameInMap("SettleNoes")]
        [Validation(Required=false)]
        public string SettleNoes { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SettleStatus")]
        [Validation(Required=false)]
        public string SettleStatus { get; set; }

        [NameInMap("SettleType")]
        [Validation(Required=false)]
        public string SettleType { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

    }

}
