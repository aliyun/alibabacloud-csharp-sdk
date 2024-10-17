// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetUrlUploadInfosRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the upload jobs. You can specify one or more job IDs. You can obtain the job IDs from the response parameter JobId of the <a href="https://help.aliyun.com/document_detail/86311.html">UploadMediaByURL</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 job IDs.</description></item>
        /// <item><description>Separate the job IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify either JobIds or UploadURLs. If you specify both parameters, only the value of JobIds takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>df2ac80b481346daa1db6a7c40edc7f8</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The upload URLs of the source files. You can specify a maximum of 10 URLs. Separate the URLs with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The URLs must be encoded.</para>
        /// </description></item>
        /// <item><description><para>If a media file is uploaded multiple times, we recommend that you specify the URL of the media file only once in this parameter.</para>
        /// </description></item>
        /// <item><description><para>You must specify either JobIds or UploadURLs. If you specify both parameters, only the value of JobIds takes effect.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://media.w3.org/2010/05/sintel/trailer.mp4">https://media.w3.org/2010/05/sintel/trailer.mp4</a></para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

    }

}
