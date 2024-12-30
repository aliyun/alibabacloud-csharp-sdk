// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileRemovePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4221bf6e6ab43c255edc4463bf3a6f5f5d317406</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The identities with whom the file is shared.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("member_list")]
        [Validation(Required=false)]
        public List<FileRemovePermissionRequestMemberList> MemberList { get; set; }
        public class FileRemovePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// <para>The identity to whom the permissions are granted, which is a user or a group.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            /// <summary>
            /// <para>The role ID. You can grant permissions by assigning roles to identities, or you can customize the permissions. To grant permissions by assigning roles to identities, specify role_id. role_id and action_list are mutually exclusive. If both parameters are specified, role_id has a higher priority.</para>
            /// <para>Valid values:</para>
            /// <para>SystemFileOwner: collaborator.</para>
            /// <para>SystemFileDownloader: downloader.</para>
            /// <para>SystemFileEditor: editor.</para>
            /// <para>SystemFileEditorWithoutDelete: editor without permissions to delete the file.</para>
            /// <para>SystemFileEditorWithoutShareLink: editor without permissions to share the file.</para>
            /// <para>SystemFileMetaViewer: viewer of lists.</para>
            /// <para>SystemFileUploader: uploader. SystemFileUploaderAndDownloader: uploader and downloader.</para>
            /// <para>SystemFileDownloaderWithShareLink: downloader and sharer.</para>
            /// <para>SystemFileUploaderAndDownloaderWithShareLink: uploader, downloader, and sharer.</para>
            /// <para>SystemFileUploaderAndViewer: viewer and uploader.</para>
            /// <para>SystemFileUploaderWithShareLink: uploader and sharer.</para>
            /// <para>SystemFileViewer: viewer.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemFileDownloader</para>
            /// </summary>
            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

    }

}
