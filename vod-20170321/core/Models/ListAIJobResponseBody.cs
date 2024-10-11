// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class ListAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<ListAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class ListAIJobResponseBodyAIJobListAIJob : TeaModel {
                /// <summary>
                /// <para>The error code. This parameter is returned if the value of Status is fail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The time when the job was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-28T02:04:47Z</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-28T02:04:32Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The returned data. The value is a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/89863.html">AITemplateConfig</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;OrigASRData&quot;:{&quot;AsrTextList&quot;:[{&quot;EndTime&quot;:700,&quot;StartTime&quot;:0,&quot;Text&quot;:&quot;Yes.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:85},{&quot;EndTime&quot;:3750,&quot;StartTime&quot;:1630,&quot;Text&quot;:&quot;No.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:28},{&quot;EndTime&quot;:5910,&quot;StartTime&quot;:4020,&quot;Text&quot;:&quot;Of course.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:95},{&quot;EndTime&quot;:12750,&quot;StartTime&quot;:10090,&quot;Text&quot;:&quot;Message.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:45},{&quot;EndTime&quot;:25230,&quot;StartTime&quot;:13590,&quot;Text&quot;:&quot;Hello, good afternoon.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:20},{&quot;EndTime&quot;:30000,&quot;StartTime&quot;:28220,&quot;Text&quot;:&quot;Yes.&quot;,&quot;ChannelId&quot;:0,&quot;SpeechRate&quot;:33}],&quot;Duration&quot;:&quot;30016&quot;}}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a718a3a1e8bb42ee3bc88921e94****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The ID of the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3D3D12340d9401fab46a0b847****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The error message. This parameter is returned if the value of Status is fail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The status of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: The job is successful.</description></item>
                /// <item><description><b>fail</b>: The job failed.</description></item>
                /// <item><description><b>init</b>: The job is being initialized.</description></item>
                /// <item><description><b>Processing</b>: The job is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AIMediaDNA</b>: video fingerprinting</description></item>
                /// <item><description><b>AIVideoTag</b>: smart tagging</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AIVideoTag</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the jobs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistAIJobIds")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyNonExistAIJobIds NonExistAIJobIds { get; set; }
        public class ListAIJobResponseBodyNonExistAIJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8233A0E4-E112-44*****58-2BCED1B88173</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
