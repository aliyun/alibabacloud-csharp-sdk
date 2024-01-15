// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetIdpMetadataResponseBody : TeaModel {
        /// <summary>
        /// The entity ID obtained after the IdP metadata file is parsed.
        /// </summary>
        [NameInMap("IdpEntityId")]
        [Validation(Required=false)]
        public string IdpEntityId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
