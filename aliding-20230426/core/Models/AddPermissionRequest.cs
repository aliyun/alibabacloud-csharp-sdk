// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddPermissionRequest : TeaModel {
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddPermissionRequestMembers> Members { get; set; }
        public class AddPermissionRequestMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
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

        [NameInMap("Option")]
        [Validation(Required=false)]
        public AddPermissionRequestOption Option { get; set; }
        public class AddPermissionRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddPermissionRequestTenantContext TenantContext { get; set; }
        public class AddPermissionRequestTenantContext : TeaModel {
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
