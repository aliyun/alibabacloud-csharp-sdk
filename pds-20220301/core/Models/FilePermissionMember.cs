// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FilePermissionMember : TeaModel {
        /// <summary>
        /// <para>The list of permissions to grant. You can grant permissions by assigning roles to identities, or you can customize the permissions. To grant permissions by assigning roles to identities, specify role_id. role_id and action_list are mutually exclusive. If both parameters are specified, the value of role_id prevails. When you specify action_list, the system automatically generates a temporary role_id. You can use this role_id to revoke the permissions.</para>
        /// </summary>
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// <para>Specifies whether the users of subgroups can inherit the permissions. For example, a user named user1 belongs to the group1 group, and a user named user2 belongs to the group2 group. group2 is the subgroup of group1. If you set disinherit_sub_group to true, only user1 is granted the permissions. user2 is not granted the permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disinherit_sub_group")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        /// <summary>
        /// <para>The time when the permissions expire. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A value of 4775500800000 indicates that the permissions never expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633598085642</para>
        /// </summary>
        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The identity to which the permissions are granted, which is a user or a group.</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        /// <summary>
        /// <para>The role ID. You can grant permissions by assigning roles to identities, or you can customize the permissions. To grant permissions by assigning roles to identities, specify role_id. role_id and action_list are mutually exclusive. If both parameters are specified, the value of role_id prevails.</para>
        /// <para>Valid values:</para>
        /// <para>SystemFileOwner: collaborator</para>
        /// <para>SystemFileDownloader: downloader</para>
        /// <para>SystemFileEditor: editor</para>
        /// <para>SystemFileEditorWithoutDelete: editor without permissions to delete the file</para>
        /// <para>SystemFileEditorWithoutShareLink: editor without permissions to share the file</para>
        /// <para>SystemFileMetaViewer: viewer of lists</para>
        /// <para>SystemFileUploader: uploader. SystemFileUploaderAndDownloader: uploader and downloader</para>
        /// <para>SystemFileDownloaderWithShareLink: downloader and sharer</para>
        /// <para>SystemFileUploaderAndDownloaderWithShareLink: uploader, downloader, and sharer</para>
        /// <para>SystemFileUploaderAndViewer: viewer and uploader</para>
        /// <para>SystemFileUploaderWithShareLink: uploader and sharer</para>
        /// <para>SystemFileViewer: viewer</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemFileDownloader</para>
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
