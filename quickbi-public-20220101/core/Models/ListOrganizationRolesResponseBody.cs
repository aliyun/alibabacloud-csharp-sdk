// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListOrganizationRolesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7AAB95D7-2E11-4FE2-94BC-858E4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListOrganizationRolesResponseBodyResult> Result { get; set; }
        public class ListOrganizationRolesResponseBodyResult : TeaModel {
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<ListOrganizationRolesResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class ListOrganizationRolesResponseBodyResultAuthConfigList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>enterprise_safety</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSystemRole")]
            [Validation(Required=false)]
            public bool? IsSystemRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
