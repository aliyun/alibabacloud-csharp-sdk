// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeObjectUploadRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency key for the upload request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The Base64-encoded MD5 hash value of the original file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yaNM/IXZgmmMasifdgcavQ==</para>
        /// </summary>
        [NameInMap("ContentMd5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// <para>The SHA-256 checksum of the original file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad</para>
        /// </summary>
        [NameInMap("ContentSha256")]
        [Validation(Required=false)]
        public string ContentSha256 { get; set; }

        /// <summary>
        /// <para>The HTTP media type for the upload.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/markdown</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The original file name, which is not used as the object ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy.md</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The target knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The size of the original file in bytes. This parameter reuses the existing maximum size limit for single-file uploads, which defaults to 100 MiB. If the size exceeds the limit, the InputTooLarge error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SizeBytes")]
        [Validation(Required=false)]
        public long? SizeBytes { get; set; }

    }

}
