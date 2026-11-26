// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeOriginal : TeaModel {
        /// <summary>
        /// <para>The temporary download URL used to access the original document.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/download/example.pdf">https://example.com/download/example.pdf</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary link, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795659000000</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

    }

}
