// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddFilePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk whose folder you want to share.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The ID of the end user who uses the cloud disk.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The ID of the file.
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
        /// The members who are granted the folder permissions.
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<AddFilePermissionRequestMemberList> MemberList { get; set; }
        public class AddFilePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// The user of the cloud disk.
            /// </summary>
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public AddFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class AddFilePermissionRequestMemberListCdsIdentity : TeaModel {
                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type of the user.
                /// 
                /// Valid values:
                /// 
                /// *   <!-- -->
                /// 
                ///     IT_Group
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   <!-- -->
                /// 
                ///     IT_User
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Specifies whether the users of the child group can inherit the folder permissions.
            /// </summary>
            [NameInMap("DisinheritSubGroup")]
            [Validation(Required=false)]
            public bool? DisinheritSubGroup { get; set; }

            /// <summary>
            /// The time when the authorization expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The value never expires. You can specify a value that is predefined by the system for this parameter. Example: 4775500800000.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The ID of the role to which you want to attach the folder permissions. To configure the folder permissions: you can specify a role or create custom operation permissions. You can use RoleId to specify a role. RoleId is mutually exclusive with ActionList. If you specify both of them, the value of RoleId takes precedence.
            /// 
            /// Valid values:
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileEditorWithoutShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileUploaderAndDownloaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileDownloader
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileEditorWithoutDelete
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileOwner
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileDownloaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileUploaderAndViewer
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileViewer
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileEditor
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileUploaderWithShareLink
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileUploader
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileUploaderAndDownloader
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     SystemFileMetaViewer
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// The region ID of the folder. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
