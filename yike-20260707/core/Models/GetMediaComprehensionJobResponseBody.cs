// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetMediaComprehensionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The media content understanding result object.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetMediaComprehensionJobResponseBodyJob Job { get; set; }
        public class GetMediaComprehensionJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The error code. This parameter is returned when the job status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is of the String type and is returned when the job status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified product does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The list of media asset IDs. If the input is a URL, the registered media asset IDs are returned.</para>
            /// </summary>
            [NameInMap("MediaIds")]
            [Validation(Required=false)]
            public List<string> MediaIds { get; set; }

            /// <summary>
            /// <para>The URL of the analysis result file. The file content is in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.json">http://xxxx.json</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: The job is created.</description></item>
            /// <item><description><b>Executing</b>: The job is being executed.</description></item>
            /// <item><description><b>Finished</b>: The job is completed.</description></item>
            /// <item><description><b>Failed</b>: The job failed.</description></item>
            /// <item><description><b>Deleted</b>: The job is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined parameter. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> The media content understanding object.</para>
        /// </summary>
        [NameInMap("MediaComprehensionJob")]
        [Validation(Required=false)]
        public GetMediaComprehensionJobResponseBodyMediaComprehensionJob MediaComprehensionJob { get; set; }
        public class GetMediaComprehensionJobResponseBodyMediaComprehensionJob : TeaModel {
            /// <summary>
            /// <para>The error code. This parameter is returned when the status is <c>Failed</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is of the String type and is returned when the job status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified product does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>afaa6f37457</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>307e9971f1</b></b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The analysis result. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;source_video_url\&quot;:\&quot;<a href="http://xxx.mp4%5C%5C%22,%5C%5C%22narrative_overview%5C%5C%22:%7B******%7D%7D">http://xxx.mp4\\&quot;,\\&quot;narrative_overview\\&quot;:{******}}</a>&quot;</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: The job is created.</description></item>
            /// <item><description><b>Executing</b>: The job is being executed.</description></item>
            /// <item><description><b>Finished</b>: The job is completed.</description></item>
            /// <item><description><b>Failed</b>: The job failed.</description></item>
            /// <item><description><b>Deleted</b>: The job is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The user-defined parameter. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
