// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileDeleteUserTagsRequest : TeaModel {
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
        /// The tags that you want to remove from a file. You cannot leave this parameter empty. You can specify up to 1,000 tags.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("key_list")]
        [Validation(Required=false)]
        public List<string> KeyList { get; set; }

    }

}
