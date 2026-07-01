// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS URL of the file, without authentication parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://outin-***.oss-cn-north-2-gov-1.aliyuncs.com/sv/40360f05-181f63c3110-0004-cd8e-27f-de3c9.mp4">http://outin-***.oss-cn-north-2-gov-1.aliyuncs.com/sv/40360f05-181f63c3110-0004-cd8e-27f-de3c9.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The URL of the media asset.</para>
        /// <remarks>
        /// <para>This will be a CDN URL if a CDN domain is configured, or an OSS URL otherwise. If you receive a 403 error when accessing this URL in a browser, it is likely because URL authentication is enabled for the VOD domain. To resolve this, either disable URL authentication or generate a signed URL for access.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxq-live-playback.oss-cn-shanghai.aliyuncs.com/capture/5d96d2b4-111b-4e5d-a0e5-20f44405bb55.mp4">https://xxq-live-playback.oss-cn-shanghai.aliyuncs.com/capture/5d96d2b4-111b-4e5d-a0e5-20f44405bb55.mp4</a></para>
        /// </summary>
        [NameInMap("MediaURL")]
        [Validation(Required=false)]
        public string MediaURL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E84BE44-58A7-<b><b>-</b></b>-FBEBEA16EF94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload address.</para>
        /// <remarks>
        /// <para>The returned upload address is Base64-encoded and must be decoded before use. You only need to manually decode this address if you are using a native OSS SDK or an OSS API to perform the upload.</para>
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
        /// <para>The returned upload credential is Base64-encoded and must be decoded before use. You only need to manually decode this credential if you are using a native OSS SDK or an OSS API to perform the upload.</para>
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
