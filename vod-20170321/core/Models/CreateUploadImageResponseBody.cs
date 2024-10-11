// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS URL of the file. The URL does not contain the information used for URL signing. You can specify FileUrl when you call the <a href="https://help.aliyun.com/document_detail/98617.html">AddWatermark</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/cover/2017-34DB-4F4C-9373-003AA060****.png">http://example.aliyundoc.com/cover/2017-34DB-4F4C-9373-003AA060****.png</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The ID of the image file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f46e91d24d81d4****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// <remarks>
        /// <para>If the returned URL is inaccessible from a browser and the HTTP 403 status code is returned, the URL signing feature in ApsaraVideo VOD is enabled. To resolve this issue, you can disable the <a href="https://help.aliyun.com/document_detail/86090.html">URL signing</a> feature or <a href="https://help.aliyun.com/document_detail/57007.html">generate a signed URL</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/cover/2017-34DB-4F4C-9373-003AA060****.png">http://example.aliyundoc.com/cover/2017-34DB-4F4C-9373-003AA060****.png</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-AEF6-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload URL.</para>
        /// <remarks>
        /// <para>The returned upload URL is a Base64-encoded URL. You must decode the Base64-encoded URL before you use an SDK or call an API operation to upload auxiliary media assets. You need to parse UploadAddress only if you use the OSS SDK or call an OSS API operation to upload auxiliary media assets.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJTZWN1cmuIjoiQ0FJU3p3TjF****</para>
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// <para>The upload credential.</para>
        /// <remarks>
        /// <para>The returned upload credential is a Base64-encoded value. You must decode the Base64-encoded credential before you use an SDK or call an API operation to upload auxiliary media assets. You need to parse UploadAuth only if you use the OSS SDK or call an OSS API operation to upload auxiliary media assets.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJFbmmRCI6Im****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

    }

}
