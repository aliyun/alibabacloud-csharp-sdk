// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the permission. The name is unique within the same region. For more information about permissions, see <a href="https://help.aliyun.com/document_detail/2840449.html">Appendix: Roles and permissions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiDLC:ListJobs</para>
        /// </summary>
        [NameInMap("PermissionCode")]
        [Validation(Required=false)]
        public string PermissionCode { get; set; }

        /// <summary>
        /// <para>The list of permission rules.</para>
        /// </summary>
        [NameInMap("PermissionRules")]
        [Validation(Required=false)]
        public List<GetPermissionResponseBodyPermissionRules> PermissionRules { get; set; }
        public class GetPermissionResponseBodyPermissionRules : TeaModel {
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
            /// <para>The access type.
            /// This parameter is invalid when Accessibility is set to PUBLIC because all users can perform the operation.
            /// When Accessibility is set to PRIVATE, EntityAccessType supports the following values:</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
