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

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("grantReason")]
        [Validation(Required=false)]
        public string GrantReason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("granterName")]
        [Validation(Required=false)]
        public string GranterName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21659398</para>
        /// </summary>
        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noticeAnnouncer")]
        [Validation(Required=false)]
        public bool? NoticeAnnouncer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("noticeSingle")]
        [Validation(Required=false)]
        public bool? NoticeSingle { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public string OpenConversationIdsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345391052</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiverUserIds")]
        [Validation(Required=false)]
        public string ReceiverUserIdsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>363784</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
