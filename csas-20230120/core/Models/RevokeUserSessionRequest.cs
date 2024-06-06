// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RevokeUserSessionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExternalIds")]
        [Validation(Required=false)]
        public string ExternalIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

    }

}
