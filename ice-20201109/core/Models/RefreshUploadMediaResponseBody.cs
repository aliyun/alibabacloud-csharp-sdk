// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class RefreshUploadMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2e77390f75271ec802f0674a2ce6***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload URL.</para>
        /// <remarks>
        /// <para>The returned upload URL is a Base64-encoded URL. You must decode the Base64-encoded upload URL before you use an SDK or call an API operation to upload media files. You need to parse UploadAddress only if you use Object Storage Service (OSS) SDK or call an OSS API operation to upload media files.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJTZWN1cml0a2VuIjoiQ0FJU3p3TjF****</para>
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// <para>The upload credential.</para>
        /// <remarks>
        /// <para>The returned upload credential is a Base64-encoded value. You must decode the Base64-encoded upload credential before you use an SDK or call an API operation to upload media files. You need to parse UploadAuth only if you use OSS SDK or call an OSS API operation to upload media files.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJFbmRwb2ludCI6Imm****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

    }

}
