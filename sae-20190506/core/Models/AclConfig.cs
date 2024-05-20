/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class AclConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("aclEntries")]
        [Validation(Required=false)]
        public List<AclEntryConfig> AclEntries { get; set; }

    }

}
