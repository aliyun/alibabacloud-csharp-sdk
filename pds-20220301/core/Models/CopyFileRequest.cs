// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CopyFileRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically rename the file if the file name already exists in the destination folder. Default value: false.
        /// </summary>
        [NameInMap("auto_rename")]
        [Validation(Required=false)]
        public bool? AutoRename { get; set; }

        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID or folder ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The share ID. If you want to manage a file by using a share link, carry the `x-share-token` header for authentication in the request and specify share_id. In this case, `drive_id` is invalid. Otherwise, use an `AccessKey pair` or `access token` for authentication and specify `drive_id`. You must specify one of `share_id` and `drive_id`.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The ID of the drive to which you want to copy the file or folder. Default value: the value of drive_id.
        /// </summary>
        [NameInMap("to_drive_id")]
        [Validation(Required=false)]
        public string ToDriveId { get; set; }

        /// <summary>
        /// The ID of the destination parent folder. If you want to copy the file or folder to a root directory, set this parameter to root.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("to_parent_file_id")]
        [Validation(Required=false)]
        public string ToParentFileId { get; set; }

    }

}
