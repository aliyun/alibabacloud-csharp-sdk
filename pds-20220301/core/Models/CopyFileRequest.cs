// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CopyFileRequest : TeaModel {
        [NameInMap("auto_rename")]
        [Validation(Required=false)]
        public bool? AutoRename { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("to_parent_file_id")]
        [Validation(Required=false)]
        public string ToParentFileId { get; set; }

    }

}
