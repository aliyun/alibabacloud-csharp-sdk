// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTenantRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of roles.</para>
        /// </summary>
        [NameInMap("RoleList")]
        [Validation(Required=false)]
        public List<ListTenantRolesResponseBodyRoleList> RoleList { get; set; }
        public class ListTenantRolesResponseBodyRoleList : TeaModel {
            /// <summary>
            /// <para>The JSON string of the permission set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("AuthJson")]
            [Validation(Required=false)]
            public string AuthJson { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30121201</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The time when the role was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07 16:45:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the role was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07 16:45:30</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30121201</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The description of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RoleDesc")]
            [Validation(Required=false)]
            public string RoleDesc { get; set; }

            /// <summary>
            /// <para>The key of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test::1212</para>
            /// </summary>
            [NameInMap("RoleKey")]
            [Validation(Required=false)]
            public string RoleKey { get; set; }

            /// <summary>
            /// <para>The name of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The type of the role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUILD_IN: built-in role.</description></item>
            /// <item><description>CUSTOM: custom role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <para>The status of the role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: enabled.</description></item>
            /// <item><description>OFF: disabled.</description></item>
            /// <item><description>DEL: deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30121001</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The type of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("TenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
