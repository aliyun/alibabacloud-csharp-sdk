// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryDentryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("IncludeSpace")]
        [Validation(Required=false)]
        public bool? IncludeSpace { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryDentryRequestTenantContext TenantContext { get; set; }
        public class QueryDentryRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
