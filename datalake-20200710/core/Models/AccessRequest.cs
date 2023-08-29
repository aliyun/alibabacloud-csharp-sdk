/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class AccessRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("Principal")]
        [Validation(Required=false)]
        public Principal Principal { get; set; }

        [NameInMap("PrivilegeResources")]
        [Validation(Required=false)]
        public List<PrivilegeResource> PrivilegeResources { get; set; }

    }

}
