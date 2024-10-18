// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>lHiicjNFM2iSFYSdz2iPuI8ZwiEiE</para>
            /// </summary>
            [NameInMap("TeamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddWorkspaceRequestTenantContext TenantContext { get; set; }
        public class AddWorkspaceRequestTenantContext : TeaModel {
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
