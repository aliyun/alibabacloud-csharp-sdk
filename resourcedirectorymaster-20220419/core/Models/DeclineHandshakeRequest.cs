// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeclineHandshakeRequest : TeaModel {
        /// <summary>
        /// The ID of the invitation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HandshakeId")]
        [Validation(Required=false)]
        public string HandshakeId { get; set; }

    }

}
