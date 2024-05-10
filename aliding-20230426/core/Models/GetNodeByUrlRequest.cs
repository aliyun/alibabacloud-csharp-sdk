// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodeByUrlRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetNodeByUrlRequestOption Option { get; set; }
        public class GetNodeByUrlRequestOption : TeaModel {
            [NameInMap("WithPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

            [NameInMap("WithStatisticalInfo")]
            [Validation(Required=false)]
            public bool? WithStatisticalInfo { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetNodeByUrlRequestTenantContext TenantContext { get; set; }
        public class GetNodeByUrlRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
