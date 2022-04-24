// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobDetailRecordShrinkRequest : TeaModel {
        [NameInMap("JobTaskDetailPaginatedQuery")]
        [Validation(Required=false)]
        public string JobTaskDetailPaginatedQueryShrink { get; set; }

        [NameInMap("SaasId")]
        [Validation(Required=false)]
        public string SaasId { get; set; }

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public string UserProfileShrink { get; set; }

    }

}
