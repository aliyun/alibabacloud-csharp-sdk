// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class CreateOutboundJobRequest : TeaModel {
        [NameInMap("OutboundJobDTO")]
        [Validation(Required=false)]
        public CreateOutboundJobRequestOutboundJobDTO OutboundJobDTO { get; set; }
        public class CreateOutboundJobRequestOutboundJobDTO : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }
            [NameInMap("CrowdConfig")]
            [Validation(Required=false)]
            public string CrowdConfig { get; set; }
            [NameInMap("CrowdType")]
            [Validation(Required=false)]
            public int? CrowdType { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }
            [NameInMap("RunConfig")]
            [Validation(Required=false)]
            public string RunConfig { get; set; }
            [NameInMap("RunType")]
            [Validation(Required=false)]
            public int? RunType { get; set; }
            [NameInMap("SaasId")]
            [Validation(Required=false)]
            public string SaasId { get; set; }
            [NameInMap("ShopId")]
            [Validation(Required=false)]
            public long? ShopId { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public CreateOutboundJobRequestUserProfile UserProfile { get; set; }
        public class CreateOutboundJobRequestUserProfile : TeaModel {
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
