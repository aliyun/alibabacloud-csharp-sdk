// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebAclConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WebAclEntries")]
        [Validation(Required=false)]
        public List<WebAclEntryConfig> WebAclEntries { get; set; }

    }

}
