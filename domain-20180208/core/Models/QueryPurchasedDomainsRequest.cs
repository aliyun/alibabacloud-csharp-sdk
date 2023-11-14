// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryPurchasedDomainsRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndOperationTime")]
        [Validation(Required=false)]
        public string EndOperationTime { get; set; }

        [NameInMap("OpTimeOrder")]
        [Validation(Required=false)]
        public bool? OpTimeOrder { get; set; }

        [NameInMap("OperationStatus")]
        [Validation(Required=false)]
        public int? OperationStatus { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

        [NameInMap("StartOperationTime")]
        [Validation(Required=false)]
        public string StartOperationTime { get; set; }

        [NameInMap("UpdateTimeOrder")]
        [Validation(Required=false)]
        public bool? UpdateTimeOrder { get; set; }

    }

}
