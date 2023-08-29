// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class BatchRevokePermissionsRequest : TeaModel {
        /// <summary>
        /// catalogId
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("GrantRevokeEntries")]
        [Validation(Required=false)]
        public List<GrantRevokeEntry> GrantRevokeEntries { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
