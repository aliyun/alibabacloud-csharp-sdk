// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DeletePermissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9E05BDRVQRkezKGCE3nlwPDJ63zgkYA</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DeletePermissionRequestMembers> Members { get; set; }
        public class DeletePermissionRequestMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORG</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORG</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGER</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public DeletePermissionRequestTenantContext TenantContext { get; set; }
        public class DeletePermissionRequestTenantContext : TeaModel {
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
