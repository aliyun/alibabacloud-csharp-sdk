// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUploadUrlRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The information about the file parts.
        /// </summary>
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

            /// <summary>
            /// The SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.
            /// </summary>
            [NameInMap("parallel_sha1_ctx")]
            [Validation(Required=false)]
            public GetUploadUrlRequestPartInfoListParallelSha1Ctx ParallelSha1Ctx { get; set; }
            public class GetUploadUrlRequestPartInfoListParallelSha1Ctx : TeaModel {
                /// <summary>
                /// The first to fifth 32-bit variables of the SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.
                /// </summary>
                [NameInMap("h")]
                [Validation(Required=false)]
                public List<long?> H { get; set; }

                /// <summary>
                /// The size of the file part. Unit: bytes. The value must be a multiple of 64. This parameter takes effect only if the parallel upload feature is enabled.
                /// </summary>
                [NameInMap("part_offset")]
                [Validation(Required=false)]
                public long? PartOffset { get; set; }

            }

            /// <summary>
            /// The serial number of a part.
            /// </summary>
            [NameInMap("part_number")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

        /// <summary>
        /// The share ID.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The ID of the upload task.
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
