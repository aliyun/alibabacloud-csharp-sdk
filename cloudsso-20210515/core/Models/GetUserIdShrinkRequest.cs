// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserIdShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The identifier information about the user that is synchronized from an external identity provider (IdP).
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalIdShrink { get; set; }

    }

}
