// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUploadUrlResponseBody : TeaModel {
        [NameInMap("create_at")]
        [Validation(Required=false)]
        public string CreateAt { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
