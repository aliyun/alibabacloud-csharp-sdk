// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeColumnPermissionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the permissions on table fields are revoked.
        /// </summary>
        [NameInMap("RevokeSuccess")]
        [Validation(Required=false)]
        public bool? RevokeSuccess { get; set; }

    }

}
