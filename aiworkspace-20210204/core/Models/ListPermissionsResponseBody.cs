// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of permissions.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <para>The name of the permission point. The name is unique within the same region. For more information about permission points, see <a href="https://help.aliyun.com/document_detail/2840449.html">Appendix: Roles and permissions</a>.
            /// For example, the value PaiDLC:GetTensorboard grants the permission to view Tensorboard details for the DLC feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PaiDLC:GetTensorboard</para>
            /// </summary>
            [NameInMap("PermissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

            /// <summary>
            /// <para>The list of permission rules.</para>
            /// </summary>
            [NameInMap("PermissionRules")]
            [Validation(Required=false)]
            public List<ListPermissionsResponseBodyPermissionsPermissionRules> PermissionRules { get; set; }
            public class ListPermissionsResponseBodyPermissionsPermissionRules : TeaModel {
                /// <summary>
                /// <para>The access type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PUBLIC: All members in the current workspace can perform the operation.</para>
                /// </description></item>
                /// <item><description><para>PRIVATE: Only the creator can perform the operation.</para>
                /// </description></item>
                /// <item><description><para>ANY: Both the creator and non-creators can perform the operation.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                /// <summary>
                /// <para>The entity access type.
                /// This parameter is invalid if Accessibility is set to PUBLIC. In this case, all users can perform the operation.
                /// If Accessibility is set to PRIVATE, the permission is determined by the value of EntityAccessType. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>CREATOR: Only the creator can perform the operation.</para>
                /// </description></item>
                /// <item><description><para>ANY: Both the creator and non-creators can perform the operation.</para>
                /// </description></item>
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
        /// <para>The number of entries that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
