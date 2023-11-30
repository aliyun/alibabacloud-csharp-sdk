// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileRemovePermissionRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The identities with whom the file is shared.
        /// </summary>
        [NameInMap("member_list")]
        [Validation(Required=false)]
        public List<FileRemovePermissionRequestMemberList> MemberList { get; set; }
        public class FileRemovePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// The identity to whom the permissions are granted, which is a user or a group.
            /// </summary>
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            /// <summary>
            /// The role ID. You can grant permissions by assigning roles to identities, or you can customize the permissions. To grant permissions by assigning roles to identities, specify role_id. role_id and action_list are mutually exclusive. If both parameters are specified, role_id has a higher priority.
            /// 
            /// Valid values:
            /// 
            /// SystemFileOwner: collaborator.
            /// 
            /// SystemFileDownloader: downloader.
            /// 
            /// SystemFileEditor: editor.
            /// 
            /// SystemFileEditorWithoutDelete: editor without permissions to delete the file.
            /// 
            /// SystemFileEditorWithoutShareLink: editor without permissions to share the file.
            /// 
            /// SystemFileMetaViewer: viewer of lists.
            /// 
            /// SystemFileUploader: uploader. SystemFileUploaderAndDownloader: uploader and downloader.
            /// 
            /// SystemFileDownloaderWithShareLink: downloader and sharer.
            /// 
            /// SystemFileUploaderAndDownloaderWithShareLink: uploader, downloader, and sharer.
            /// 
            /// SystemFileUploaderAndViewer: viewer and uploader.
            /// 
            /// SystemFileUploaderWithShareLink: uploader and sharer.
            /// 
            /// SystemFileViewer: viewer.
            /// </summary>
            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

    }

}
