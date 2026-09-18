// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetTransitMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary download URL. If <c>Network</c> is not specified, <c>null</c> is returned. If the file is not yet available, the URL may not be accessible. Do not write this URL to logs, persist it for long-term use, or share it with unauthorized users.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://download.example.invalid/code-review.zip?signature=">https://download.example.invalid/code-review.zip?signature=</a><REDACTED></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the Transit record, expressed as a UTC UNIX timestamp in milliseconds (the number of milliseconds elapsed since 1970-01-01 00:00:00 UTC). You can compare this value directly with the current UNIX timestamp in milliseconds without adding or subtracting 8 hours. Do not use the record after this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787734800000</para>
        /// </summary>
        [NameInMap("ExpireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        /// <summary>
        /// <para>The opaque object path of the file. Do not parse or manually construct this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-bundle/tenant-demo/user-demo/20260904120000_code-review.zip</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The file size in bytes. <c>null</c> may be returned if no available file has been detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The Transit file status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PENDING: The file is not yet available. You can query again later.</description></item>
        /// <item><description>SUCCESS: The file is available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Transit ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>transit_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("TransitId")]
        [Validation(Required=false)]
        public string TransitId { get; set; }

    }

}
