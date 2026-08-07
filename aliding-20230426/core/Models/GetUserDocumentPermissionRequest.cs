// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserDocumentPermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>87654321</para>
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public long? DentryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a9E05BDRVQRkezKGCDOvkbzrJ63zgkYA</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserDocumentPermissionRequestTenantContext TenantContext { get; set; }
        public class GetUserDocumentPermissionRequestTenantContext : TeaModel {
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
