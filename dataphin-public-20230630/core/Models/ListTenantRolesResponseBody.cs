// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTenantRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request error code. OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the backend response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message of the request.</para>
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
        /// <para>The role list.</para>
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
            /// <para>The user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30121201</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07 16:45:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07 16:45:30</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The user ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30121201</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The role description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RoleDesc")]
            [Validation(Required=false)]
            public string RoleDesc { get; set; }

            /// <summary>
            /// <para>The role key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test::1212</para>
            /// </summary>
            [NameInMap("RoleKey")]
            [Validation(Required=false)]
            public string RoleKey { get; set; }

            /// <summary>
            /// <para>The role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The role type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUILD_IN: built-in role</description></item>
            /// <item><description>CUSTOM: custom role</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <para>The role status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: enabled</description></item>
            /// <item><description>OFF: disabled</description></item>
            /// <item><description>DEL: deleted</description></item>
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
            /// <para>The tenant type.</para>
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
