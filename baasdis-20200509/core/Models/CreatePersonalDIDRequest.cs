// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BaasDis20200509.Models
{
    public class CreatePersonalDIDRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerUniqueID")]
        [Validation(Required=false)]
        public string OwnerUniqueID { get; set; }

    }

}
