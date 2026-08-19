// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetURLUploadInfosRequest : TeaModel {
        /// <summary>
        /// <para>The list of upload task IDs (JobId). The list consists of one or more JobId values. A JobId is the value of the JobId parameter returned when you call the <a href="https://help.aliyun.com/document_detail/86311.html">UploadMediaByURL</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of 10 IDs are supported.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify either JobIds or UploadURLs. If both are specified, only JobIds is processed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86c1925fba0****,7afb201e7fa****,2cc4997378****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The list of source video file URLs. Separate multiple URLs with commas (,). A maximum of 10 URLs are supported.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>URL-encode the URLs before use.</description></item>
        /// <item><description>If the same URL video is uploaded multiple times, pass in a single URL for the query.</description></item>
        /// <item><description>You must specify either JobIds or UploadURLs. If both are specified, only JobIds is processed.</description></item>
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
