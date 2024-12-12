// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListBatchMediaProducingJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried quick video production jobs.</para>
        /// </summary>
        [NameInMap("EditingBatchJobList")]
        [Validation(Required=false)]
        public List<ListBatchMediaProducingJobsResponseBodyEditingBatchJobList> EditingBatchJobList { get; set; }
        public class ListBatchMediaProducingJobsResponseBodyEditingBatchJobList : TeaModel {
            /// <summary>
            /// <para>The time when the job was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-09T06:38:09Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-09T06:36:48Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The editing configurations. For more information, see <a href="~~2692547#1be9bba03b7qu~~">EditingConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaConfig&quot;: {
            ///       &quot;Volume&quot;: 0
            ///   },
            ///   &quot;SpeechConfig&quot;: {
            ///       &quot;Volume&quot;: 1
            ///   },
            ///  &quot;BackgroundMusicConfig&quot;: {
            ///       &quot;Volume&quot;: 0.3
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            /// <summary>
            /// <para>The extended information of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The input configurations.</para>
            /// </summary>
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }

            /// <summary>
            /// <para>The ID of the quick video production job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>7ecbee4c6d9b8474498e</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Script: script-based editing job that mixes media assets.</description></item>
            /// <item><description>Smart_Mix: intelligent editing job that mixes media assets.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Script</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-09T06:37:58Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The output configurations. For more information, see <a href="~~2692547#447b928fcbuoa~~">OutputConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
            ///   &quot;Count&quot;: 20,
            ///   &quot;MaxDuration&quot;: 15,
            ///   &quot;Width&quot;: 1080,
            ///   &quot;Height&quot;: 1920,
            ///   &quot;Video&quot;: {&quot;Crf&quot;: 27}
            /// }</para>
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }

            /// <summary>
            /// <para>The job state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Finished</description></item>
            /// <item><description>Init</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Processing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
