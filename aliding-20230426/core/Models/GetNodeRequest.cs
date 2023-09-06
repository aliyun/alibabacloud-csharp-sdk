// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodeRequest : TeaModel {
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetNodeRequestTenantContext TenantContext { get; set; }
        public class GetNodeRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WithPermissionRole")]
        [Validation(Required=false)]
        public bool? WithPermissionRole { get; set; }

        [NameInMap("WithStatisticalInfo")]
        [Validation(Required=false)]
        public bool? WithStatisticalInfo { get; set; }

    }

}
