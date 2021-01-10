// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPOperationAuditRequest : TeaModel {
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public bool? Desc { get; set; }

        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
