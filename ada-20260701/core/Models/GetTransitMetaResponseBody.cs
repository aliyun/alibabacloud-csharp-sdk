// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetTransitMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary download URL. If Network is not specified, null is returned. The URL may be unavailable if the file is not yet available. Do not write this URL to logs, store it for a long time, or forward it to irrelevant users.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://download.example.invalid/code-review.zip?signature=">https://download.example.invalid/code-review.zip?signature=</a><REDACTED></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the transit record. The value is a UTC UNIX timestamp in milliseconds, which is the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970. You can directly compare this value with the current UNIX timestamp in milliseconds without adding or subtracting 8 hours. Do not continue to use the record after this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787734800000</para>
        /// </summary>
        [NameInMap("ExpireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        /// <summary>
        /// <para>The opaque object path corresponding to the file. Callers must not parse or construct this value.</para>
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
        /// <para>The file size, in bytes. If no available file is detected, null may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The status of the transit file. A value of PENDING indicates that the file is not yet available, and the caller can query again later. A value of SUCCESS indicates that the file is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The transit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transit_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("TransitId")]
        [Validation(Required=false)]
        public string TransitId { get; set; }

    }

}
