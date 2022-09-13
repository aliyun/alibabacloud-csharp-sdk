// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListUploadedPartsRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("part_number_marker")]
        [Validation(Required=false)]
        public int? PartNumberMarker { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
