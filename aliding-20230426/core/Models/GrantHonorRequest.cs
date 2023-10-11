// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GrantHonorRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GrantHonorRequestTenantContext TenantContext { get; set; }
        public class GrantHonorRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        [NameInMap("noticeAnnouncer")]
        [Validation(Required=false)]
        public bool? NoticeAnnouncer { get; set; }

        [NameInMap("noticeSingle")]
        [Validation(Required=false)]
        public bool? NoticeSingle { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIds { get; set; }

        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
