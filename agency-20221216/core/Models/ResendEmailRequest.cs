// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ResendEmailRequest : TeaModel {
        /// <summary>
        /// <para>The invitation ID, obtained from the InviteSbuAccount operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176</para>
        /// </summary>
        [NameInMap("InviteId")]
        [Validation(Required=false)]
        public long? InviteId { get; set; }

    }

}
