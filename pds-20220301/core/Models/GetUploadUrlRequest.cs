// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUploadUrlRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<GetUploadUrlRequestPartInfoList> PartInfoList { get; set; }
        public class GetUploadUrlRequestPartInfoList : TeaModel {
            [NameInMap("content_md5")]
            [Validation(Required=false)]
            public string ContentMd5 { get; set; }

            [NameInMap("content_type")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("parallel_sha1_ctx")]
            [Validation(Required=false)]
            public GetUploadUrlRequestPartInfoListParallelSha1Ctx ParallelSha1Ctx { get; set; }
            public class GetUploadUrlRequestPartInfoListParallelSha1Ctx : TeaModel {
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

        }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
