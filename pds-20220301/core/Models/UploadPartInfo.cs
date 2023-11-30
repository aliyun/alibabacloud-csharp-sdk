// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UploadPartInfo : TeaModel {
        [NameInMap("etag")]
        [Validation(Required=false)]
        public string Etag { get; set; }

        [NameInMap("internal_upload_url")]
        [Validation(Required=false)]
        public string InternalUploadUrl { get; set; }

        [NameInMap("parallel_sha1_ctx")]
        [Validation(Required=false)]
        public UploadPartInfoParallelSha1Ctx ParallelSha1Ctx { get; set; }
        public class UploadPartInfoParallelSha1Ctx : TeaModel {
            [NameInMap("h")]
            [Validation(Required=false)]
            public List<long?> H { get; set; }

            [NameInMap("part_offset")]
            [Validation(Required=false)]
            public long? PartOffset { get; set; }

        }

        [NameInMap("parallel_sha256_ctx")]
        [Validation(Required=false)]
        public UploadPartInfoParallelSha256Ctx ParallelSha256Ctx { get; set; }
        public class UploadPartInfoParallelSha256Ctx : TeaModel {
            [NameInMap("h")]
            [Validation(Required=false)]
            public List<long?> H { get; set; }

            [NameInMap("part_offset")]
            [Validation(Required=false)]
            public long? PartOffset { get; set; }

        }

        [NameInMap("part_number")]
        [Validation(Required=false)]
        public int? PartNumber { get; set; }

        [NameInMap("part_size")]
        [Validation(Required=false)]
        public long? PartSize { get; set; }

        [NameInMap("upload_url")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
