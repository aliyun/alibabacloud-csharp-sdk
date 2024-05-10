// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetWorkspacesRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetWorkspacesRequestOption Option { get; set; }
        public class GetWorkspacesRequestOption : TeaModel {
            [NameInMap("WithPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetWorkspacesRequestTenantContext TenantContext { get; set; }
        public class GetWorkspacesRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

    }

}
