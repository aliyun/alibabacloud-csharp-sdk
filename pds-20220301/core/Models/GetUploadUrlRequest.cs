// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d5b846942cf94fa72324c14a4bda34e81da635d</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The information about the file parts.</para>
        /// <para>This parameter is required.</para>
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
            /// <para>The SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.</para>
            /// </summary>
            [NameInMap("parallel_sha1_ctx")]
            [Validation(Required=false)]
            public GetUploadUrlRequestPartInfoListParallelSha1Ctx ParallelSha1Ctx { get; set; }
            public class GetUploadUrlRequestPartInfoListParallelSha1Ctx : TeaModel {
                /// <summary>
                /// <para>The first to fifth 32-bit variables of the SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.</para>
                /// </summary>
                [NameInMap("h")]
                [Validation(Required=false)]
                public List<long?> H { get; set; }

                /// <summary>
                /// <para>The size of the file part. Unit: bytes. The value must be a multiple of 64. This parameter takes effect only if the parallel upload feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10240</para>
                /// </summary>
                [NameInMap("part_offset")]
                [Validation(Required=false)]
                public long? PartOffset { get; set; }

            }

            [NameInMap("parallel_sha256_ctx")]
            [Validation(Required=false)]
            public GetUploadUrlRequestPartInfoListParallelSha256Ctx ParallelSha256Ctx { get; set; }
            public class GetUploadUrlRequestPartInfoListParallelSha256Ctx : TeaModel {
                [NameInMap("h")]
                [Validation(Required=false)]
                public List<long?> H { get; set; }

                [NameInMap("part_offset")]
                [Validation(Required=false)]
                public long? PartOffset { get; set; }

            }

            /// <summary>
            /// <para>The serial number of a part.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("part_number")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

        /// <summary>
        /// <para>The share ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The ID of the upload task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10166D06127B413BA1EC8ABB1144D111</para>
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
