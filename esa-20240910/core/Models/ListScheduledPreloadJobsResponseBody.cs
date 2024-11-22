// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListScheduledPreloadJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the prefetch tasks.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListScheduledPreloadJobsResponseBodyJobs> Jobs { get; set; }
        public class ListScheduledPreloadJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15685865xxx14622</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-01T08:53:13Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The domain names to be prefetched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testurl.com</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public string Domains { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid domain:test.com</para>
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// <para>The URL of the OSS object that stores a list of URLs that failed the conditional check for prefetching.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
            /// </summary>
            [NameInMap("FailedFileOss")]
            [Validation(Required=false)]
            public string FailedFileOss { get; set; }

            /// <summary>
            /// <para>The ID of the URL list file, which can be used during downloads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3b48621bccf3fe29e1a7</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The ID of the prefetch task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3af3621bccf3fe29e1a4</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The method to submit the URLs to be prefetched.</para>
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
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>190007158391808</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The number of submitted prefetch tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskSubmitted")]
            [Validation(Required=false)]
            public int? TaskSubmitted { get; set; }

            /// <summary>
            /// <para>The task type. Valid values: refresh and preload.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
