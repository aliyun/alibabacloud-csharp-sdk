// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveFilePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud disk in Cloud Drive Service.</para>
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
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The file ID. The ID is a unique identifier for the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6333e553a133ce21e6f747cf948bb9ef95d7****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The users that you want to authorize.</para>
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
                /// <item><description><para>IT_Group</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>group</para>
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>IT_User</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>user</para>
                /// <!-- --></description></item>
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
            /// <para>The role ID. You can configure permissions on roles or actions. This parameter is used to specify the permissions on roles, which conflicts with the ActionList parameter. When you configure both the parameters, this parameter shall prevail.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SystemFileEditorWithoutShareLink</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to edit files but cannot share files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileUploaderAndDownloaderWithShareLink</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to upload, download, and share files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileDownloader</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to download files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileEditorWithoutDelete</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to edit files but cannot delete files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileOwner</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to collaborate with others</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileDownloaderWithShareLink</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to download and share files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileUploaderAndViewer</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to preview or upload files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileViewer</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to preview files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileEditor</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to edit files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileUploaderWithShareLink</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to upload or share files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileUploader</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permission to upload files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileUploaderAndDownloader</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to upload or download files</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>SystemFileMetaViewer</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>the role that has the permissions to view files</para>
            /// <!-- --></description></item>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
