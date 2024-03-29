/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AcceptResourceShareInvitationRequest : TeaModel {
        /// <summary>
        /// The ID of the resource sharing invitation.
        /// 
        /// You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ResourceShareInvitationId")]
        [Validation(Required=false)]
        public string ResourceShareInvitationId { get; set; }

    }

}
