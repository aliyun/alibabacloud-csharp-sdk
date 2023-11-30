// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class MoveFileRequest : TeaModel {
        /// <summary>
        /// The processing method that is used if the file that you want to move has the same name as an existing file in the destination directory. Valid values:
        /// 
        /// ignore: allows you to move the file by using the same name as an existing file in the destination directory.
        /// 
        /// auto_rename: automatically renames the file that has the same name exists in the destination directory. By default, the current point in time is added to the end of the file name. Example: xxx\_20060102\_150405.
        /// 
        /// refuse: does not move the file that you want to move but returns the information about the file that has the same name in the destination directory.
        /// 
        /// Default value: ignore.
        /// </summary>
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

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
        /// The ID of the destination parent directory to which you want to move a file or folder. If you want to move a file or folder to the root directory, set this parameter to root.
        /// </summary>
        [NameInMap("to_parent_file_id")]
        [Validation(Required=false)]
        public string ToParentFileId { get; set; }

    }

}
