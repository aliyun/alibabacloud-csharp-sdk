// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMineWorkspaceRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public Dictionary<string, object> Request { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetMineWorkspaceRequestTenantContext TenantContext { get; set; }
        public class GetMineWorkspaceRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
