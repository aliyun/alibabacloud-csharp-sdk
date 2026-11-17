// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetCollaborationGroupOutputItemPreviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The common business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERR.Robject.Auth.TenantAccessDenied</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The text content or preview prompt. This field can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Technical solution</h1>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Indicates whether the preview is downgraded to a download preview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("degraded")]
        [Validation(Required=false)]
        public bool? Degraded { get; set; }

        /// <summary>
        /// <para>The short-term signed download URL. This field can be empty. If the URL expires, call this operation again.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/download/document.md">https://example.com/download/document.md</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The file name extension. This field can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md</para>
        /// </summary>
        [NameInMap("fileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The file name. This field can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codex-r2-a-baseline.md</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The output detail ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51469466</para>
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>The common error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access denied to tenant 2147483647 because the user does not belong to the tenant</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The preview type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTENT</para>
        /// </summary>
        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        /// <summary>
        /// <para>The short-term preview URL. This field can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/preview/document">https://example.com/preview/document</a></para>
        /// </summary>
        [NameInMap("previewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9cf6cb3-3f5c-4994-a8a1-c93379a6f5cf</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
