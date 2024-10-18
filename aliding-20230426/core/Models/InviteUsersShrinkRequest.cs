// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InviteUsersShrinkRequest : TeaModel {
        [NameInMap("InviteeList")]
        [Validation(Required=false)]
        public string InviteeListShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61289fxxx</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("phoneInviteeList")]
        [Validation(Required=false)]
        public string PhoneInviteeListShrink { get; set; }

    }

}
