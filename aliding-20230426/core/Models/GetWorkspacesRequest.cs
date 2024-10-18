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
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("WithPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetWorkspacesRequestTenantContext TenantContext { get; set; }
        public class GetWorkspacesRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace_id</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

    }

}
