// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the job was created, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-07T07:16:11Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the job was completed, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-26T14:50:25Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The name of the algorithm to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b>: smart cover</para>
        /// </description></item>
        /// <item><description><para><b>VideoClip</b>: video summary</para>
        /// </description></item>
        /// <item><description><para><b>VideoDelogo</b>: video logo removal</para>
        /// </description></item>
        /// <item><description><para><b>VideoDetext</b>: video text removal</para>
        /// </description></item>
        /// <item><description><para><b>CaptionExtraction</b>: caption extraction</para>
        /// </description></item>
        /// <item><description><para><b>VideoGreenScreenMatting</b>: green screen matting</para>
        /// </description></item>
        /// <item><description><para><b>FaceBeauty</b>: video beautification</para>
        /// </description></item>
        /// <item><description><para><b>VideoH2V</b>: horizontal-to-vertical video conversion</para>
        /// </description></item>
        /// <item><description><para><b>MusicSegmentDetect</b>: chorus detection</para>
        /// </description></item>
        /// <item><description><para><b>AudioBeatDetection</b>: beat detection</para>
        /// </description></item>
        /// <item><description><para><b>AudioQualityAssessment</b>: audio quality assessment</para>
        /// </description></item>
        /// <item><description><para><b>SpeechDenoise</b>: speech denoising</para>
        /// </description></item>
        /// <item><description><para><b>AudioMixing</b>: audio mixing</para>
        /// </description></item>
        /// <item><description><para><b>MusicDemix</b>: music source separation</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The input media.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyInput Input { get; set; }
        public class QueryIProductionJobResponseBodyInput : TeaModel {
            /// <summary>
            /// <para>The source file for the job. Set this to an OSS file URL if <c>Type</c> is <c>OSS</c>, or a media asset ID if <c>Type</c> is <c>Media</c>.
            /// Valid OSS URL formats:</para>
            /// <ol>
            /// <item><description><para>oss\://bucket/object</para>
            /// </description></item>
            /// <item><description><para>http(s)://bucket.oss-[RegionId].aliyuncs.com/object
            /// In these formats, <c>bucket</c> is the name of the OSS bucket in the same region as the current project, and <c>object</c> is the file path.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The input type. Valid values:</para>
            /// <ol>
            /// <item><description><para>OSS: An OSS file URL.</para>
            /// </description></item>
            /// <item><description><para>Media: A media asset ID.</para>
            /// </description></item>
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
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>A JSON object that contains the parameters for the algorithm job. The specific parameters vary depending on the selected algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Model&quot;:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output media.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyOutput Output { get; set; }
        public class QueryIProductionJobResponseBodyOutput : TeaModel {
            /// <summary>
            /// <para>The service that the media asset belongs to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMS</para>
            /// </summary>
            [NameInMap("Biz")]
            [Validation(Required=false)]
            public string Biz { get; set; }

            /// <summary>
            /// <para>The destination for the output. If the output <c>Type</c> is <c>OSS</c>, this parameter returns an OSS file URL. If the output <c>Type</c> is <c>Media</c>, it returns the specified or a newly generated media asset ID.</para>
            /// <para>Valid OSS URL formats:</para>
            /// <ol>
            /// <item><description><para>oss\://bucket/object</para>
            /// </description></item>
            /// <item><description><para>http(s)://bucket.oss-[RegionId].aliyuncs.com/object
            /// In these formats, <c>bucket</c> is the name of the OSS bucket in the same region as the current project, and <c>object</c> is the file path.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The OSS URL of the output file. This value is returned only when <c>Type</c> is <c>Media</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OSS: An OSS file URL.</para>
            /// </description></item>
            /// <item><description><para>Media: A media asset ID.</para>
            /// </description></item>
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
        /// <para>An array of output file paths.</para>
        /// </summary>
        [NameInMap("OutputFiles")]
        [Validation(Required=false)]
        public List<string> OutputFiles { get; set; }

        /// <summary>
        /// <para>The output media asset IDs.</para>
        /// </summary>
        [NameInMap("OutputMediaIds")]
        [Validation(Required=false)]
        public List<string> OutputMediaIds { get; set; }

        /// <summary>
        /// <para>An array of output file URLs.</para>
        /// </summary>
        [NameInMap("OutputUrls")]
        [Validation(Required=false)]
        public List<string> OutputUrls { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The algorithm output, returned as a JSON string. The structure of the output varies based on the <c>FunctionName</c>. For more information, see the additional notes below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The job configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public QueryIProductionJobResponseBodyScheduleConfig ScheduleConfig { get; set; }
        public class QueryIProductionJobResponseBodyScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54fdc9c9aab413caef0d1150f565e86</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The job\&quot;s priority within the pipeline.</para>
            /// <list type="bullet">
            /// <item><description><para>A larger value indicates a higher priority. The highest priority is 10.</para>
            /// </description></item>
            /// <item><description><para>Default: <b>6</b>.</para>
            /// </description></item>
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
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Queuing: The job is awaiting processing.</para>
        /// </description></item>
        /// <item><description><para>Analyzing: The job is being processed.</para>
        /// </description></item>
        /// <item><description><para>Fail: The job failed to complete.</para>
        /// </description></item>
        /// <item><description><para>Success: The job completed successfully.</para>
        /// </description></item>
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
        /// <para>The user data. The system returns this value unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
