// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoCreativeGenerationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job creation time in UTC format (yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:34.001+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error code. This parameter is returned only when the job status is Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowTaskFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The job completion time in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T18:53:34.001+08:00</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The task results of the node. This parameter is valid only when the job status is Succeeded. Each element represents the output for a single language.</para>
        /// </summary>
        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public List<GetVideoCreativeGenerationJobResponseBodyJobResult> JobResult { get; set; }
        public class GetVideoCreativeGenerationJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <para>The online editing project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a6adbbd181437eb5030d3d93e0182d</para>
            /// </summary>
            [NameInMap("EditingProjectId")]
            [Validation(Required=false)]
            public string EditingProjectId { get; set; }

            /// <summary>
            /// <para>The media asset ID of the output video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9d7e982012c671f1b803e7f6d75a6302</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The output language. Valid values: CN, EN, and YUE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("OutputLanguage")]
            [Validation(Required=false)]
            public string OutputLanguage { get; set; }

            /// <summary>
            /// <para>The signed download URL of the output video. The URL is time-limited.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

        }

        /// <summary>
        /// <para>The job status. Valid values: Running, Succeeded, and Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom user data, which is returned as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12374214127312673137132</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
