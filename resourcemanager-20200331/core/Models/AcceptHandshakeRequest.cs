/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AcceptHandshakeRequest : TeaModel {
        /// <summary>
        /// The ID of the invitation.
        /// 
        /// You can call the [ListHandshakesForAccount](~~160006~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("HandshakeId")]
        [Validation(Required=false)]
        public string HandshakeId { get; set; }

    }

}
