// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveFilePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise drive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-066224****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The file ID. You can call the <a href="https://help.aliyun.com/document_detail/2247622.html">ListCdsFiles</a> operation to query the ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6333e553a133ce21e6f747cf948bb9ef95d7****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The ID of the team space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-1fbmvrc7ug5m7****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The users that you want to authorize to use the cloud disk.</para>
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
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IT_Group: group.</description></item>
                /// <item><description>IT_User: user.</description></item>
                /// </list>
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
            /// <para>You can set permissions by specifying roles or by customizing operation permissions. This field is used to set permissions by specifying roles. This field is mutually exclusive with <c>ActionList</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SystemFileEditorWithoutShareLink: the role that has the permissions to edit files but cannot share files.</description></item>
            /// <item><description>SystemFileUploaderAndDownloaderWithShareLink: the role that has the permissions to upload, download, and share files.</description></item>
            /// <item><description>SystemFileDownloader: the role that has the permissions to download files.</description></item>
            /// <item><description>SystemFileEditorWithoutDelete: the role that has the permissions to edit files but cannot delete files.</description></item>
            /// <item><description>SystemFileOwner: the role that has the permissions to collaborate with others.</description></item>
            /// <item><description>SystemFileDownloaderWithShareLink: the role that has the permissions to download and share files</description></item>
            /// <item><description>SystemFileUploaderAndViewer: the role that has the permissions to preview or upload files.</description></item>
            /// <item><description>SystemFileViewer: the role that has the permissions to preview files.</description></item>
            /// <item><description>SystemFileEditor: the role that has the permissions to edit files</description></item>
            /// <item><description>SystemFileUploaderWithShareLink: the role that has the permissions to upload or share files.</description></item>
            /// <item><description>SystemFileUploader: the role that has the permission to upload files.</description></item>
            /// <item><description>SystemFileUploaderAndDownloader: the role that has the permissions to upload or download files.</description></item>
            /// <item><description>SystemFileMetaViewer: the role that has the permissions to view files</description></item>
            /// </list>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
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
