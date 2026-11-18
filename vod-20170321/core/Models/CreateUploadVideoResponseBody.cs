// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
        /// <para>The upload URL returned by the operation is Base64-encoded. When you call an SDK or API operation to upload the media asset, you must decode the URL before use. You only need to parse UploadAddress when you use the native OSS SDK or OSS API for upload.</para>
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
        /// <para>The upload credential returned by the operation is Base64-encoded. When you call an SDK or API operation to upload the media asset, you must decode the credential before use. You only need to parse UploadAuth when you use the native OSS SDK or OSS API for upload.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJFbmRwb2ludCI6Imm****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

        /// <summary>
        /// <para>The audio or video ID. You can use this ID as a request parameter for media asset management, media processing, and media review operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f54b6e91d24d81d44****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
