// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UploadPartInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0CC175B9C0F1B6A831C399E269772661</para>
        /// </summary>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("part_number")]
        [Validation(Required=false)]
        public int? PartNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("part_size")]
        [Validation(Required=false)]
        public long? PartSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("upload_url")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
