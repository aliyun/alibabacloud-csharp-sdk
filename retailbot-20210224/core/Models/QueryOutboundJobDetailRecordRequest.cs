// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobDetailRecordRequest : TeaModel {
        [NameInMap("JobTaskDetailPaginatedQuery")]
        [Validation(Required=false)]
        public QueryOutboundJobDetailRecordRequestJobTaskDetailPaginatedQuery JobTaskDetailPaginatedQuery { get; set; }
        public class QueryOutboundJobDetailRecordRequestJobTaskDetailPaginatedQuery : TeaModel {
            [NameInMap("BatchNo")]
            [Validation(Required=false)]
            public string BatchNo { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("SortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }
            [NameInMap("StatusSet")]
            [Validation(Required=false)]
            public List<string> StatusSet { get; set; }
        };

        [NameInMap("SaasId")]
        [Validation(Required=false)]
        public string SaasId { get; set; }

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public QueryOutboundJobDetailRecordRequestUserProfile UserProfile { get; set; }
        public class QueryOutboundJobDetailRecordRequestUserProfile : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }
            [NameInMap("PlatformCode")]
            [Validation(Required=false)]
            public string PlatformCode { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }
        };

    }

}
