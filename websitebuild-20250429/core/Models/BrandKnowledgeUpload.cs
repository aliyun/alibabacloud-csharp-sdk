// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeUpload : TeaModel {
        /// <summary>
        /// <para>The knowledge base document ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkd_example001</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary URL, specified as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795659000000</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <para>The fields that must be submitted as-is during form upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;example/document.pdf&quot;}</para>
        /// </summary>
        [NameInMap("FormFields")]
        [Validation(Required=false)]
        public Dictionary<string, string> FormFields { get; set; }

        /// <summary>
        /// <para>The HTTP request headers included in the upload request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Content-Type&quot;:&quot;application/pdf&quot;}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// <para>The HTTP method used for uploading the original document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The temporary destination URL for uploading the original document.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/upload">https://example.com/upload</a></para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
