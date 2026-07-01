// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitIProductionJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the algorithm function. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b>: Generates a smart cover.</para>
        /// </description></item>
        /// <item><description><para><b>VideoClip</b>: Creates a video summary.</para>
        /// </description></item>
        /// <item><description><para><b>VideoDelogo</b>: Removes logos from a video.</para>
        /// </description></item>
        /// <item><description><para><b>VideoDetext</b>: Removes text from a video.</para>
        /// </description></item>
        /// <item><description><para><b>CaptionExtraction</b>: Extracts captions from a video.</para>
        /// </description></item>
        /// <item><description><para><b>VideoGreenScreenMatting</b>: Performs green screen keying for a video.</para>
        /// </description></item>
        /// <item><description><para><b>FaceBeauty</b>: Applies beauty filters to faces in a video.</para>
        /// </description></item>
        /// <item><description><para><b>VideoH2V</b>: Converts a horizontal video to a vertical video.</para>
        /// </description></item>
        /// <item><description><para><b>MusicSegmentDetect</b>: Detects chorus segments in music.</para>
        /// </description></item>
        /// <item><description><para><b>AudioBeatDetection</b>: Detects the beat of an audio track.</para>
        /// </description></item>
        /// <item><description><para><b>AudioQualityAssessment</b>: Assesses audio quality.</para>
        /// </description></item>
        /// <item><description><para><b>SpeechDenoise</b>: Reduces noise in speech audio.</para>
        /// </description></item>
        /// <item><description><para><b>AudioMixing</b>: Mixes audio tracks.</para>
        /// </description></item>
        /// <item><description><para><b>MusicDemix</b>: Separates vocals from accompaniment in music.</para>
        /// </description></item>
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
        /// <para>The input media asset. You can specify an OSS file or a media asset ID.</para>
        /// <para>The requirements for input files vary by algorithm function. For more information, see the supplementary instructions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The algorithm job parameters, specified as a JSON-formatted string. The content of the JSON object varies by algorithm function. For more information, see the supplementary instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Model&quot;:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The ID of the algorithm model. If you do not specify this parameter, the system uses the default model for the selected function. We recommend leaving this parameter empty unless you need to use a specific alternative model.</para>
        /// <para>The following function offers an alternative model:</para>
        /// <list type="bullet">
        /// <item><description><para><c>VideoDetext</c></para>
        /// <list type="bullet">
        /// <item><description>Set <c>ModelId</c> to <c>algo-video-detext-new</c> to use an advanced subtitle removal algorithm. This model provides higher quality results but is slower and more expensive than the default model.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The name of the job, which can be up to 100 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output destination. You can specify an OSS file path or a media asset ID.</para>
        /// <para>The output files vary by algorithm function. For more information, see the supplementary instructions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

        /// <summary>
        /// <para>The configuration for job scheduling.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Custom user data. The system passes this data through and returns it as-is in the callback or response. The length cannot exceed 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
