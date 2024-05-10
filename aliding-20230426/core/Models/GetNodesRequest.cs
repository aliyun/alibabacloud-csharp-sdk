// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetNodesRequestOption Option { get; set; }
        public class GetNodesRequestOption : TeaModel {
            [NameInMap("WithPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

            [NameInMap("WithStatisticalInfo")]
            [Validation(Required=false)]
            public bool? WithStatisticalInfo { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetNodesRequestTenantContext TenantContext { get; set; }
        public class GetNodesRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
