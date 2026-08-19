// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsRequest : TeaModel {
        /// <summary>
        /// <para>The list of task IDs. You can obtain the task ID (JobId) from the PlayInfo struct returned by the <a href="https://help.aliyun.com/document_detail/56124.html">GetPlayInfo</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of 10 IDs are supported.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify either JobIds or UploadUrls. If both are specified, only JobIds is processed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>341c92e6c18dc435ee31253685****,0193d395194a83ad6ee2ef27a5b5****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The list of source video upload URLs. Separate multiple URLs with commas (,). A maximum of 10 URLs are supported.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>URL-encode the URLs before use.</description></item>
        /// <item><description>You must specify either JobIds or UploadUrls. If both are specified, only JobIds is processed.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("UploadUrls")]
        [Validation(Required=false)]
        public string UploadUrls { get; set; }

    }

}
