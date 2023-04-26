// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDownloadUrlRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public int? ExpireSec { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

    }

}
