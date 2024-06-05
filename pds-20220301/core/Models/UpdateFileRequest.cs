// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFileRequest : TeaModel {
        /// <summary>
        /// The processing method that is used if the file that you want to modify has the same name as an existing file on the cloud. Valid values:
        /// 
        /// ignore: allows you to modify the file by using the same name as an existing file on the cloud.
        /// 
        /// auto_rename: automatically renames the file that has the same name on the cloud. By default, the current point in time is added to the end of the file name. Example: xxx_20060102_150405.
        /// 
        /// refuse: does not modify the file that you want to modify but returns the information about the file that has the same name on the cloud.
        /// 
        /// Default value: ignore.
        /// </summary>
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

        /// <summary>
        /// The description of the file. The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The drive ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether to hide the file.
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The tags of the file. You can specify up to 100 tags.
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// The local time when the file was modified. The time is in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.
        /// </summary>
        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        /// <summary>
        /// The name of the file. The name can be up to 1,024 bytes in length based on the UTF-8 encoding rule.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether to add the file to favorites.
        /// </summary>
        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

    }

}
