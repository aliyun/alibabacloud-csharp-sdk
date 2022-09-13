// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileStreamInfo : TeaModel {
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("content_md5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public UploadPartInfo PartInfoList { get; set; }

        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

        [NameInMap("proof_code")]
        [Validation(Required=false)]
        public string ProofCode { get; set; }

        [NameInMap("proof_version")]
        [Validation(Required=false)]
        public string ProofVersion { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
