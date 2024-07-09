// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCdsFileRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The policy that is used when the file that you want to upload has the same name as an existing file in the cloud disk.
        /// 
        /// Valid values:
        /// 
        /// *   refuse
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     denies creating the file
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   auto_rename
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     automatically renames the file
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   ignore
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     allows the file to use the same name as the existing file in the cloud disk
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   over_write
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     overwrites the existing file in the cloud disk
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The hash value of the SHA1 algorithm that is used by the file.
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// The file size. Unit: bytes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileLength")]
        [Validation(Required=false)]
        public long? FileLength { get; set; }

        /// <summary>
        /// The file name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The file type.
        /// 
        /// Valid values:
        /// 
        /// *   file
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   folder
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the parent folder.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParentFileId")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
