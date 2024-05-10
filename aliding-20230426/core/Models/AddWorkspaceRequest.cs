// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddWorkspaceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public AddWorkspaceRequestOption Option { get; set; }
        public class AddWorkspaceRequestOption : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("TeamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddWorkspaceRequestTenantContext TenantContext { get; set; }
        public class AddWorkspaceRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
