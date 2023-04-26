// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileRemovePermissionRequest : TeaModel {
        /// <summary>
        /// 空间id
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// 共享的用户对象集合
        /// </summary>
        [NameInMap("member_list")]
        [Validation(Required=false)]
        public List<FileRemovePermissionRequestMemberList> MemberList { get; set; }
        public class FileRemovePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// 可授权对象，表示一个用户或者一个群组
            /// </summary>
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            /// <summary>
            /// 目前支持两种方式设置权限，一种是通过指定角色设置权限，另一种是自定义操作权限，此字段用于指定角色设置权限，与action\_list互斥，当两个字段同时设置时，以此字段为准
            /// 
            /// 目前支持：
            /// 
            /// SystemFileOwner（文件协同）
            /// 
            /// SystemFileDownloader（下载者）
            /// 
            /// SystemFileEditor（编辑者）
            /// 
            /// SystemFileEditorWithoutDelete（无删除编辑者）
            /// 
            /// SystemFileEditorWithoutShareLink（无分享编辑者）
            /// 
            /// SystemFileMetaViewer（可见列表）
            /// 
            /// SystemFileUploader（上传者）、SystemFileUploaderAndDownloader（上传/下载者）
            /// 
            /// SystemFileDownloaderWithShareLink（下载/分享者）
            /// 
            /// SystemFileUploaderAndDownloaderWithShareLink（上传/下载/分享者）
            /// 
            /// SystemFileUploaderAndViewer（预览/上传者）
            /// 
            /// SystemFileUploaderWithShareLink（上传/分享者）
            /// 
            /// SystemFileViewer（预览者）
            /// </summary>
            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

    }

}
