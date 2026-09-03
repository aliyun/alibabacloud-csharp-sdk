// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveFilePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise cloud disk ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-066224****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The file ID. You can call <a href="https://help.aliyun.com/document_detail/2247622.html">ListCdsFiles</a> to query the ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6333e553a133ce21e6f747cf948bb9ef95d7****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The team space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-1fbmvrc7ug5m7****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The list of authorized users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<RemoveFilePermissionRequestMemberList> MemberList { get; set; }
        public class RemoveFilePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// <para>The permission information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public RemoveFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class RemoveFilePermissionRequestMemberListCdsIdentity : TeaModel {
                /// <summary>
                /// <para>The user ID or group ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>249dsfseee643h33g3dv****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IT_User</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Two methods are supported for setting permissions: specifying a role or customizing operation permissions. This parameter specifies the role-based permission and is mutually exclusive with <c>ActionList</c>. If both parameters are specified, this parameter takes precedence.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemFileUploaderAndDownloader</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
