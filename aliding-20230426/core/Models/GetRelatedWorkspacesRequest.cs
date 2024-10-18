// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetRelatedWorkspacesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRecent")]
        [Validation(Required=false)]
        public bool? IncludeRecent { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetRelatedWorkspacesRequestTenantContext TenantContext { get; set; }
        public class GetRelatedWorkspacesRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
