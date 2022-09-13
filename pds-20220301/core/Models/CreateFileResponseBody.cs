// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateFileResponseBody : TeaModel {
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("rapid_upload")]
        [Validation(Required=false)]
        public bool? RapidUpload { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
