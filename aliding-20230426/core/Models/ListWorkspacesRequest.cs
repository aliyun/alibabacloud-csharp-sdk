// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListWorkspacesRequest : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("TeamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ListWorkspacesRequestTenantContext TenantContext { get; set; }
        public class ListWorkspacesRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WithPermissionRole")]
        [Validation(Required=false)]
        public bool? WithPermissionRole { get; set; }

    }

}
