// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CopyFileRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically rename the file if the file name already exists in the destination folder. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_rename")]
        [Validation(Required=false)]
        public bool? AutoRename { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID or folder ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4221bf6e6ab43c255edc4463bf3a6f5f5d317406</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a share link, carry the <c>x-share-token</c> header for authentication in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify one of <c>share_id</c> and <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The ID of the drive to which you want to copy the file or folder. Default value: the value of drive_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("to_drive_id")]
        [Validation(Required=false)]
        public string ToDriveId { get; set; }

        /// <summary>
        /// <para>The ID of the destination parent folder. If you want to copy the file or folder to a root directory, set this parameter to root.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6520943DC261</para>
        /// </summary>
        [NameInMap("to_parent_file_id")]
        [Validation(Required=false)]
        public string ToParentFileId { get; set; }

    }

}
