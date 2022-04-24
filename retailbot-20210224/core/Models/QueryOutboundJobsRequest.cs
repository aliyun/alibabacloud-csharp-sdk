// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobsRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("SaasId")]
        [Validation(Required=false)]
        public string SaasId { get; set; }

        [NameInMap("ShopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public QueryOutboundJobsRequestUserProfile UserProfile { get; set; }
        public class QueryOutboundJobsRequestUserProfile : TeaModel {
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

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
