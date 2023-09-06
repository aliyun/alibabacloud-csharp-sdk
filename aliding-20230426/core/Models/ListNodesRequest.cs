// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListNodesRequest : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ParentNodeId")]
        [Validation(Required=false)]
        public string ParentNodeId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ListNodesRequestTenantContext TenantContext { get; set; }
        public class ListNodesRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WithPermissionRole")]
        [Validation(Required=false)]
        public bool? WithPermissionRole { get; set; }

    }

}
