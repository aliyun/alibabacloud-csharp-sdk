// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class StreamUploadInfo : TeaModel {
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("pre_rapid_upload")]
        [Validation(Required=false)]
        public bool? PreRapidUpload { get; set; }

        [NameInMap("rapid_upload")]
        [Validation(Required=false)]
        public bool? RapidUpload { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
