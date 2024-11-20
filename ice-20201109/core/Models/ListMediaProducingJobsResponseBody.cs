// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaProducingJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// <para>Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The queried media editing and production jobs.</para>
        /// </summary>
        [NameInMap("MediaProducingJobList")]
        [Validation(Required=false)]
        public List<ListMediaProducingJobsResponseBodyMediaProducingJobList> MediaProducingJobList { get; set; }
        public class ListMediaProducingJobsResponseBodyMediaProducingJobList : TeaModel {
            /// <summary>
            /// <para>The template material parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Text1&quot;:&quot;text&quot;,&quot;Text0&quot;:&quot;text&quot;,&quot;Media1&quot;:&quot;mediaId&quot;,&quot;Media0&quot;:&quot;mediaId&quot;}</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The response code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-21T16:40:30Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-21T16:40:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The duration of the output file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15.5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the online editing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>8750b54e3c976a47da6f</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The media asset ID of the output file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ce4ea70f52471edab61f7e7d6786302</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The URL of the output file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://your-bucket.oss-cn-shanghai.aliyuncs.com/your-video.mp4">http://your-bucket.oss-cn-shanghai.aliyuncs.com/your-video.mp4</a></para>
            /// </summary>
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }

            /// <summary>
            /// <para>The returned message. Note: Pay attention to this parameter if the job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated InputFile is bad</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-21T16:41:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>faa3b542f5a6135217e3</b></b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The job state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sucess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the online editing template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb786a39c5d44cecb23d8c864facffc1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The user-defined data in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
