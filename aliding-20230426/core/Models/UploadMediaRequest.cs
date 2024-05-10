// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UploadMediaRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UploadMediaRequestTenantContext TenantContext { get; set; }
        public class UploadMediaRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("mediaName")]
        [Validation(Required=false)]
        public string MediaName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
