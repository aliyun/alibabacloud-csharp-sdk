// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class LinkRule : TeaModel {
        [NameInMap("link_type")]
        [Validation(Required=false)]
        public string LinkType { get; set; }

        [NameInMap("src_drive_id")]
        [Validation(Required=false)]
        public string SrcDriveId { get; set; }

        [NameInMap("src_drive_name")]
        [Validation(Required=false)]
        public string SrcDriveName { get; set; }

        [NameInMap("src_file_id")]
        [Validation(Required=false)]
        public string SrcFileId { get; set; }

        [NameInMap("src_file_name")]
        [Validation(Required=false)]
        public string SrcFileName { get; set; }

        [NameInMap("src_valid")]
        [Validation(Required=false)]
        public bool? SrcValid { get; set; }

    }

}
