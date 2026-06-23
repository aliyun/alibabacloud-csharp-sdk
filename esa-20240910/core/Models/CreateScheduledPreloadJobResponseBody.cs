// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15685865xxx14622</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>The time when the task was created, in ISO 8601 format (for example, 2024-01-01T00:00:00+08:00).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-05T10:04:20+0800</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The list of prefetch domains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testurl.com</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        /// <summary>
        /// <para>The error information. Multiple errors are separated by commas:</para>
        /// <list type="bullet">
        /// <item><description><b>InvalidUrl</b>: The URL format is invalid.</description></item>
        /// <item><description><b>InvalidDomain</b>: The domain ownership verification failed.</description></item>
        /// <item><description><b>QuotaExcess</b>: The quota limit has been exceeded.</description></item>
        /// <item><description><b>OtherErrors</b>: Other errors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidDomain</para>
        /// </summary>
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// <para>The OSS address of the failed file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
        /// </summary>
        [NameInMap("FailedFileOss")]
        [Validation(Required=false)]
        public string FailedFileOss { get; set; }

        /// <summary>
        /// <para>The URL list file ID, used for downloading.</para>
        /// 
        /// <b>Example:</b>
        /// <para>665d3b48621bccf3fe29e1a7</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>665d3af3621bccf3fe29e1a4</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The URL insertion method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("InsertWay")]
        [Validation(Required=false)]
        public string InsertWay { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>190007158391808</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The number of URLs that have been submitted to the system for prefetch tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskSubmitted")]
        [Validation(Required=false)]
        public int? TaskSubmitted { get; set; }

        /// <summary>
        /// <para>The task type (refresh/prefetch).</para>
        /// 
        /// <b>Example:</b>
        /// <para>preload</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The total number of URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UrlCount")]
        [Validation(Required=false)]
        public int? UrlCount { get; set; }

        /// <summary>
        /// <para>The number of submitted URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UrlSubmitted")]
        [Validation(Required=false)]
        public int? UrlSubmitted { get; set; }

    }

}
