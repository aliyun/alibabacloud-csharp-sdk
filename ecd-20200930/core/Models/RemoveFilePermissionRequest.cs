// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveFilePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk in Cloud Drive Service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The file ID. The ID is a unique identifier for the file.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The users that you want to authorize.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<RemoveFilePermissionRequestMemberList> MemberList { get; set; }
        public class RemoveFilePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// The permission information.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public RemoveFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class RemoveFilePermissionRequestMemberListCdsIdentity : TeaModel {
                /// <summary>
                /// The user ID or group ID.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The object type.
                /// 
                /// Valid values:
                /// 
                /// *   IT_Group
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     group
                /// 
                ///     <!-- -->
                /// 
                /// *   IT_User
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     user
                /// 
                ///     <!-- -->
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The role ID. You can configure permissions on roles or actions. This parameter is used to specify the permissions on roles, which conflicts with the ActionList parameter. When you configure both the parameters, this parameter shall prevail.
            /// 
            /// Valid values:
            /// 
            /// *   SystemFileEditorWithoutShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to edit files but cannot share files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileUploaderAndDownloaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to upload, download, and share files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileDownloader
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to download files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileEditorWithoutDelete
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to edit files but cannot delete files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileOwner
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to collaborate with others
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileDownloaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to download and share files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileUploaderAndViewer
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to preview or upload files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileViewer
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to preview files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileEditor
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to edit files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileUploaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to upload or share files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileUploader
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permission to upload files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileUploaderAndDownloader
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to upload or download files
            /// 
            ///     <!-- -->
            /// 
            /// *   SystemFileMetaViewer
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the role that has the permissions to view files
            /// 
            ///     <!-- -->
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
