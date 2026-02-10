// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class FilePermissionMember : TeaModel {
        /// <summary>
        /// <para>The object that you want to grant permissions. The object can be a user or a group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CdsIdentity")]
        [Validation(Required=false)]
        public FilePermissionMemberCdsIdentity CdsIdentity { get; set; }
        public class FilePermissionMemberCdsIdentity : TeaModel {
            /// <summary>
            /// <para>The user ID or a team ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16435bdf934248b788b7b3771ee9****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The object type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IT_Group: team</description></item>
            /// <item><description>IT_User: user</description></item>
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
        /// <para>Indicates whether to disable the permission from users in the subgroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisinheritSubGroup")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        /// <summary>
        /// <para>The expiration time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633598866642</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The role.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemFileEditorWithoutShareLink: The role that can edit but cannot share files.</description></item>
        /// <item><description>SystemFileUploaderAndDownloaderWithShareLink: The role that can upload, download, and share files.</description></item>
        /// <item><description>SystemFileDownloader: The role that can download files.</description></item>
        /// <item><description>SystemFileEditorWithoutDelete: The role that can edit but cannot edit files.</description></item>
        /// <item><description>SystemFileOwner: The role that can collaborate with others on files.</description></item>
        /// <item><description>SystemFileDownloaderWithShareLink: The role that can download and share files.</description></item>
        /// <item><description>SystemFileUploaderAndViewer: The role that can preview and upload files.</description></item>
        /// <item><description>SystemFileViewer: The role that can preview files.</description></item>
        /// <item><description>SystemFileEditor: The role that can edit files.</description></item>
        /// <item><description>SystemFileUploaderWithShareLink: The role that can upload and share files.</description></item>
        /// <item><description>SystemFileUploader: The role that can upload files.</description></item>
        /// <item><description>SystemFileUploaderAndDownloader: The role that can upload and download files.</description></item>
        /// <item><description>SystemFileMetaViewer: The role that can view file list.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemFileEditor</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
