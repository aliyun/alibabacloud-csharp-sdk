// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission name, which is unique in a region. For more information about permissions, see <a href="https://help.aliyun.com/document_detail/2840449.html">Appendix: Roles and permissions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiDLC:ListJobs</para>
        /// </summary>
        [NameInMap("PermissionCode")]
        [Validation(Required=false)]
        public string PermissionCode { get; set; }

        /// <summary>
        /// <para>The permission rules.</para>
        /// </summary>
        [NameInMap("PermissionRules")]
        [Validation(Required=false)]
        public List<GetPermissionResponseBodyPermissionRules> PermissionRules { get; set; }
        public class GetPermissionResponseBodyPermissionRules : TeaModel {
            /// <summary>
            /// <para>The accessibility. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: All members can access the workspace.</description></item>
            /// <item><description>PRIVATE: Only the creator can access the workspace.</description></item>
            /// <item><description>ANY: All users can access the workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// <para>The access type. If you set Accessibility to PUBLIC, all users can access the workspace. This parameter is invalid. If you set Accessibility to PRIVATE, the value of this parameter can be:</para>
            /// <list type="bullet">
            /// <item><description>PRIVATE: Only the creator can access the workspace.</description></item>
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
