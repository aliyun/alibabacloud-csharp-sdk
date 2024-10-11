// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetURLUploadInfosRequest : TeaModel {
        /// <summary>
        /// <para>The one or more IDs of upload jobs. You can obtain the job IDs in the response parameter JobId of the <a href="https://help.aliyun.com/document_detail/86311.html">UploadMediaByURL</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must set one of the JobIds and the UploadURLs parameters. If you set both the JobIds and UploadURLs parameters, only the value of the JobIds parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86c1925fba0****,7afb201e7fa****,2cc4997378****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The one or more upload URLs of the source files. Separate multiple URLs with commas (,). You can specify a maximum of 10 URLs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must encode the URLs before you use the URLs.</description></item>
        /// <item><description>If a media file is uploaded multiple times, pass the URL of the media file to this parameter only once.</description></item>
        /// <item><description>You must set one of the JobIds and the UploadURLs parameters. If you set both the JobIds and UploadURLs parameters, only the value of the JobIds parameter takes effect.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.mp4</para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

    }

}
