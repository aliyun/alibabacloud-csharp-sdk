// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <para>The permission name, which is unique in a region. For more information about permissions, see <a href="https://help.aliyun.com/document_detail/2840449.html">Appendix: Roles and permissions</a>. The example value PaiDLC:GetTensorboard indicates the permission to view details about a TensorBoard job on the Deep Learning Containers (DLC) page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PaiDLC:GetTensorboard</para>
            /// </summary>
            [NameInMap("PermissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

            /// <summary>
            /// <para>The permission rules.</para>
            /// </summary>
            [NameInMap("PermissionRules")]
            [Validation(Required=false)]
            public List<ListPermissionsResponseBodyPermissionsPermissionRules> PermissionRules { get; set; }
            public class ListPermissionsResponseBodyPermissionsPermissionRules : TeaModel {
                /// <summary>
                /// <para>The accessibility of the permission rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PUBLIC: All members in the workspace can access the permission rule.</description></item>
                /// <item><description>PRIVATE: Only the creator can access the permission rule.</description></item>
                /// <item><description>ANY: All users can access the permission rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                /// <summary>
                /// <para>The type of access. If you set Accessibility to PUBLIC, all users can access the workspace. This parameter is invalid. If you set Accessibility to PRIVATE, the permissions are determined based on the value of EntityAccessType. The value of EntityAccessType can be:</para>
                /// <list type="bullet">
                /// <item><description>CREATOR: Only the creator can access the workspace.</description></item>
                /// <item><description>ANY: All users can access the workspace.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CREATOR</para>
                /// </summary>
                [NameInMap("EntityAccessType")]
                [Validation(Required=false)]
                public string EntityAccessType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-B******8174039A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of permissions that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
