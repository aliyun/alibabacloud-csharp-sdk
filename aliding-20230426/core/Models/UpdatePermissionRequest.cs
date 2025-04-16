// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdatePermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>kDnRL6jAJMLgNkw7tBnw5aY4VyMoPYe1</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<UpdatePermissionRequestMembers> Members { get; set; }
        public class UpdatePermissionRequestMembers : TeaModel {
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

        [NameInMap("Option")]
        [Validation(Required=false)]
        public UpdatePermissionRequestOption Option { get; set; }
        public class UpdatePermissionRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>READER</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdatePermissionRequestTenantContext TenantContext { get; set; }
        public class UpdatePermissionRequestTenantContext : TeaModel {
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
