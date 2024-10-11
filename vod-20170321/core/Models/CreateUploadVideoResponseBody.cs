// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-04D5-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload URL.</para>
        /// <remarks>
        /// <para>The returned upload URL is a Base64-encoded URL. You must decode the Base64-encoded URL before you use an SDK or call an API operation to upload media files. You need to parse UploadAddress only if you use the Object Storage Service (OSS) SDK or call an OSS API operation to upload media files.</para>
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
        /// <para>The returned upload credential is a Base64-encoded value. You must decode the Base64-encoded credential before you use an SDK or call an API operation to upload media files. You need to parse UploadAuth only if you use the OSS SDK or call an OSS API operation to upload media files.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJFbmRwb2ludCI6Imm****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video file. VideoId can be used as a request parameter when you call an operation for media asset management, media processing, or media review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f54b6e91d24d81d44****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
