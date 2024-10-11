// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the upload jobs. You can obtain the job IDs from PlayInfo in the response to the <a href="https://help.aliyun.com/document_detail/56124.html">GetPlayInfo</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify either JobIds or UploadUrls. If you specify both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>341c92e6c18dc435ee31253685****,0193d395194a83ad6ee2ef27a5b5****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The upload URLs of source video files. Separate multiple URLs with commas (,). You can specify a maximum of 10 URLs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must encode the URLs before you use the URLs.</description></item>
        /// <item><description>You must specify either JobIds or UploadUrls. If you specify both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("UploadUrls")]
        [Validation(Required=false)]
        public string UploadUrls { get; set; }

    }

}
