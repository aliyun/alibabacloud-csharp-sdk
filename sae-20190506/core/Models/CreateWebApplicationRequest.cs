// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateWebApplicationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateWebApplicationInput Body { get; set; }

    }

}
