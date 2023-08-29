// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ListPermissionsRequest : TeaModel {
        /// <summary>
        /// CatalogId
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("IsListUserRolePermissions")]
        [Validation(Required=false)]
        public bool? IsListUserRolePermissions { get; set; }

        [NameInMap("MetaResource")]
        [Validation(Required=false)]
        public MetaResource MetaResource { get; set; }

        [NameInMap("MetaResourceType")]
        [Validation(Required=false)]
        public string MetaResourceType { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Principal")]
        [Validation(Required=false)]
        public Principal Principal { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
