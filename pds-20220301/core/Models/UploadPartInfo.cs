// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UploadPartInfo : TeaModel {
        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0CC175B9C0F1B6A831C399E269772661&quot;</para>
        /// </summary>
        [NameInMap("etag")]
        [Validation(Required=false)]
        public string Etag { get; set; }

        /// <summary>
        /// <para>The internal upload URL that is used for internal access over a virtual private cloud (VPC). If the intelligent domain name feature is enabled, this parameter is not required. This parameter is returned in the upload_url parameter based on the request. If you want to use this parameter, contact Photo and Drive Service (PDS) technical support.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data-vpc.aliyunpds.com/xxx/xxx?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx&partNumber=1&uploadId=0CC175B9C0F1B6A831C399E269772661">https://data-vpc.aliyunpds.com/xxx/xxx?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx&amp;partNumber=1&amp;uploadId=0CC175B9C0F1B6A831C399E269772661</a></para>
        /// </summary>
        [NameInMap("internal_upload_url")]
        [Validation(Required=false)]
        public string InternalUploadUrl { get; set; }

        /// <summary>
        /// <para>The Secure Hash Algorithm 1 (SHA-1) context of the previous part. This parameter takes effect only if the parallel upload feature is enabled.</para>
        /// </summary>
        [NameInMap("parallel_sha1_ctx")]
        [Validation(Required=false)]
        public UploadPartInfoParallelSha1Ctx ParallelSha1Ctx { get; set; }
        public class UploadPartInfoParallelSha1Ctx : TeaModel {
            /// <summary>
            /// <para>The first to fifth 32-bit variables in the SHA-1 context of the previous part. This parameter takes effect only if the parallel upload feature is enabled.</para>
            /// </summary>
            [NameInMap("h")]
            [Validation(Required=false)]
            public List<long?> H { get; set; }

            /// <summary>
            /// <para>The total size of all the previous parts. Unit: bytes. The value must be a multiple of 64. This parameter takes effect only if the parallel upload feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("part_offset")]
            [Validation(Required=false)]
            public long? PartOffset { get; set; }

        }

        /// <summary>
        /// <para>The SHA-256 context of the previous part.</para>
        /// </summary>
        [NameInMap("parallel_sha256_ctx")]
        [Validation(Required=false)]
        public UploadPartInfoParallelSha256Ctx ParallelSha256Ctx { get; set; }
        public class UploadPartInfoParallelSha256Ctx : TeaModel {
            /// <summary>
            /// <para>The first to eighth 32-bit variables in the SHA-256 context of the previous part.</para>
            /// </summary>
            [NameInMap("h")]
            [Validation(Required=false)]
            public List<long?> H { get; set; }

            /// <summary>
            /// <para>The total size of all the previous parts. Unit: bytes. The value must be a multiple of 64.</para>
            /// </summary>
            [NameInMap("part_offset")]
            [Validation(Required=false)]
            public long? PartOffset { get; set; }

        }

        /// <summary>
        /// <para>The serial number of the file part.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("part_number")]
        [Validation(Required=false)]
        public int? PartNumber { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("part_size")]
        [Validation(Required=false)]
        public long? PartSize { get; set; }

        /// <summary>
        /// <para>The upload URL. By default, the validity period of the URL is 15 minutes. If the URL expires, you must call the GetUploadUrl operation to obtain another URL. If the intelligent domain name feature is enabled, the internal_upload_url value is returned within the parameter based on the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/xxx/xxx?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx&partNumber=1&uploadId=0CC175B9C0F1B6A831C399E269772661">https://data.aliyunpds.com/xxx/xxx?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx&amp;partNumber=1&amp;uploadId=0CC175B9C0F1B6A831C399E269772661</a></para>
        /// </summary>
        [NameInMap("upload_url")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
