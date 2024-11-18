// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AcceptResourceShareInvitationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource sharing invitation.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/450564.html">ListResourceShareInvitations</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-pMnItMX19fBJ****</para>
        /// </summary>
        [NameInMap("ResourceShareInvitationId")]
        [Validation(Required=false)]
        public string ResourceShareInvitationId { get; set; }

    }

}
