// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitIProductionJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the algorithm that you want to use for the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: This algorithm intelligently generates a thumbnail image for a video.</description></item>
        /// <item><description><b>VideoClip</b>: This algorithm intelligently generates a summary for a video.</description></item>
        /// <item><description><b>VideoDelogo</b>: This algorithm removes logos from a video.</description></item>
        /// <item><description><b>VideoDetext</b>: This algorithm removes captions from a video.</description></item>
        /// <item><description><b>CaptionExtraction</b>: This algorithm extracts captions from a video and generates the caption file.</description></item>
        /// <item><description><b>VideoGreenScreenMatting</b>: This algorithm performs green-screen image matting on a video and generates a new video.</description></item>
        /// <item><description><b>FaceBeauty</b>: This algorithm performs video retouching.</description></item>
        /// <item><description><b>VideoH2V</b>: This algorithm transforms a video from the landscape mode to the portrait mode.</description></item>
        /// <item><description><b>MusicSegmentDetect</b>: This algorithm detects the chorus of a song.</description></item>
        /// <item><description><b>AudioBeatDetection</b>: This algorithm detects rhythms.</description></item>
        /// <item><description><b>AudioQualityAssessment</b>: This algorithm assesses the audio quality.</description></item>
        /// <item><description><b>SpeechDenoise</b>: This algorithm performs noise reduction.</description></item>
        /// <item><description><b>AudioMixing</b>: This algorithm mixes audio streams.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The input file. The file can be an Object Storage Service (OSS) object or a media asset.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestInput Input { get; set; }
        public class SubmitIProductionJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file. The file can be an OSS object or a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[regionId].aliyuncs.com/object bucket in the path specifies an OSS bucket that resides in the same region as the intelligent production job. object in the path specifies the object path in OSS.</description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The algorithm-specific parameters. The parameters are specified as JSON objects and vary based on the algorithm. For more information, see the &quot;Parameters of JobParams&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Model&quot;:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The name of the intelligent production job. The name can be up to 100 characters in length.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output file. The file can be an OSS object or a media asset.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestOutput Output { get; set; }
        public class SubmitIProductionJobRequestOutput : TeaModel {
            [NameInMap("Biz")]
            [Validation(Required=false)]
            public string Biz { get; set; }

            /// <summary>
            /// <para>The output file. If Type is set to OSS, set this parameter to the path of an OSS object. If Type is set to Media, set this parameter to the ID of a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object bucket in the path specifies an OSS bucket that resides in the same region as the intelligent production job. object in the path specifies the object path in OSS.</description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: OSS object</description></item>
            /// <item><description>Media: media asset</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitIProductionJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5246b8d12a62433ab77845074039c3dc</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid values: 1 to 10. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The user-defined data that is returned in the response. The value can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
