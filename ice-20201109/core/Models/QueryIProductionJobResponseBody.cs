// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-07T07:16:11Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the job was complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-26T14:50:25Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The name of the algorithm that you want to use for the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: This algorithm intelligently generates a thumbnail image for a video.</description></item>
        /// <item><description><b>VideoClip</b>: This algorithm intelligently generates a summary for a video.</description></item>
        /// <item><description><b>VideoDelogo</b>: This algorithm removes logos from a video.</description></item>
        /// <item><description><b>VideoDetext</b>: This algorithm removes captions from a video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The input file.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyInput Input { get; set; }
        public class QueryIProductionJobResponseBodyInput : TeaModel {
            /// <summary>
            /// <para>The input file. If Type is set to OSS, set this parameter to the path of an OSS object. If Type is set to Media, set this parameter to the ID of a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object bucket in the path specifies an OSS bucket that resides in the same region as the intelligent production job. object in the path specifies the object path in OSS.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: Object Storage Service (OSS) object</description></item>
            /// <item><description>Media: media asset</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the intelligent production job.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The algorithm-specific parameters. The parameters are specified as JSON objects and vary based on the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Model&quot;:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The name of the intelligent production job.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output file.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyOutput Output { get; set; }
        public class QueryIProductionJobResponseBodyOutput : TeaModel {
            /// <summary>
            /// <para>The output file. If Type is set to OSS, set this parameter to the path of an OSS object. If Type is set to Media, set this parameter to the ID of a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object bucket in the path specifies an OSS bucket that resides in the same region as the intelligent production job. object in the path specifies the object path in OSS.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: OSS object</description></item>
            /// <item><description>Media: media asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The output files.</para>
        /// </summary>
        [NameInMap("OutputFiles")]
        [Validation(Required=false)]
        public List<string> OutputFiles { get; set; }

        /// <summary>
        /// <para>The URLs of the output files.</para>
        /// </summary>
        [NameInMap("OutputUrls")]
        [Validation(Required=false)]
        public List<string> OutputUrls { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The output of the algorithm. The output is in JSON format and varies based on the algorithm. For more information, see the &quot;Parameters of Result&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyScheduleConfig ScheduleConfig { get; set; }
        public class QueryIProductionJobResponseBodyScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54fdc9c9aab413caef0d1150f565e86</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job in the MPS queue to which the job is added.</para>
            /// <list type="bullet">
            /// <item><description>A value of 10 indicates the highest priority.</description></item>
            /// <item><description>Default value: <b>6</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Queuing: The job is waiting in the queue.</description></item>
        /// <item><description>Analysing: The job is in progress.</description></item>
        /// <item><description>Fail: The job failed.</description></item>
        /// <item><description>Success: The job was successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The user-defined data that is returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
