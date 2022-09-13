// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListUploadedPartsResponseBody : TeaModel {
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("next_part_number_marker")]
        [Validation(Required=false)]
        public string NextPartNumberMarker { get; set; }

        [NameInMap("parallel_upload")]
        [Validation(Required=false)]
        public bool? ParallelUpload { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        [NameInMap("uploaded_parts")]
        [Validation(Required=false)]
        public List<UploadPartInfo> UploadedParts { get; set; }

    }

}
