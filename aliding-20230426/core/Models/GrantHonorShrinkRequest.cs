// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GrantHonorShrinkRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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
        public string OpenConversationIdsShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public string ReceiverUserIdsShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
