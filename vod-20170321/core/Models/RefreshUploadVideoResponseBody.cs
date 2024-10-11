// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshUploadVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A43-7DF6-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload URL.</para>
        /// <remarks>
        /// <para> The returned upload URL is a Base64-encoded URL. You must decode the Base64-encoded upload URL before you use an SDK or call an API operation to upload media files. You need to parse UploadAddress only if you use the OSS SDK or call an OSS API operation to upload media files.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJTZWN1cml0eVRiQ0FJU3p3TjFxNkZ0NUIyeW****</para>
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// <para>The upload credential.</para>
        /// <remarks>
        /// <para> The returned upload credential is a Base64-encoded value. You must decode the Base64-encoded upload URL before you use an SDK or call an API operation to upload media files. You need to parse UploadAuth only if you use the OSS SDK or call an OSS API operation to upload media files.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FJU3p3TZ0NUIyeW****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6a23a870c8c4ffcd40cbd381333****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
