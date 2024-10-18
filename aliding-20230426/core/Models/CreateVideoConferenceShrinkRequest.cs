// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateVideoConferenceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InviteCaller")]
        [Validation(Required=false)]
        public bool? InviteCaller { get; set; }

        [NameInMap("InviteUserIds")]
        [Validation(Required=false)]
        public string InviteUserIdsShrink { get; set; }

    }

}
